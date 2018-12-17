using System;
using System.Data;
using System.Globalization;
using System.Linq;
using VoxData.VoxCRM.DAO.Tables;

namespace VoxData.VoxCRM.GeneralFunctions
{
    public static class Parameter
    {

        #region tParameter - SET

        public static void set(string ParameterName, string ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString(), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, int ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString(), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, long ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString(), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, bool ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString().ToLower(), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, DateTime ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString("yyyy-MM-dd HH:mm:ss"), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, DateTime ParameterValue, string format, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString(format), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, TimeSpan ParameterValue, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            set(ParameterName, ParameterValue.ToString(), ParameterValue.GetType().Name, DTtParameter, InsertIfNotFound);
        }
        public static void set(string ParameterName, string ParameterValue, string ParameterType, DataTable DTtParameter = null, bool InsertIfNotFound = false)
        {
            tParameter tp = new tParameter();
            try
            {
                get(ParameterName, DTtParameter);

                tp.Update(ParameterName, ParameterValue, ParameterType);

                if (DTtParameter != null)
                {
                    DataRow[] DR = DTtParameter.Select("IDParameter = '" + ParameterName + "'");
                    DR[0]["vchValue"] = ParameterType;
                }
            }
            catch (Exception ex)
            {
                if (InsertIfNotFound && ex.InnerException != null && ex.InnerException.GetType() == typeof(ArgumentException))
                {
                    try
                    {
                        tp.Insert(ParameterName, ParameterValue, ParameterType);
                    }
                    catch (Exception ex2)
                    {
                        throw new Exception("Ocorreu uma excessão no SET {" + ParameterName + "}", ex2);
                    }
                }
                else
                {
                    throw new Exception("Ocorreu uma excessão no SET {" + ParameterName + "}", ex);
                }
                
            }
            finally
            {
                tp.Dispose();
            }
        }

        #endregion

        #region tParameter - GET

        private static string get(string ParameterName, DataTable DTtParameter = null)
        {
            tParameter tpta = new tParameter();
            try
            {
                if (DTtParameter != null)
                {
                    DataRow[] DR = DTtParameter.Select("IDParameter = '" + ParameterName + "'");

                    if (DR.Count() == 1)
                        return DR[0]["vchValue"].ToString();
                    else
                        throw new ArgumentException("Parâmetro inexistente ou inacessível");
                }
                else
                {
                    tpta.GetDataByID(ParameterName);

                    if (tpta.Count() == 1)
                        return tpta.Columns.vchValue;
                    else
                        throw new ArgumentException("Parâmetro inexistente ou inacessível");

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu uma excessão no GET {" + ParameterName + "}", ex);
            }
            finally
            {
                tpta.Dispose();
            }
        }
        public static bool getBool(string ParameterName, DataTable DTtParameter = null)
        {

            string s = get(ParameterName, DTtParameter);

            if (!String.IsNullOrEmpty(s))
                return bool.Parse(s);
            else
                return false;

        }
        public static long getLong(string ParameterName, DataTable DTtParameter = null)
        {

            string s = get(ParameterName, DTtParameter);

            if (!String.IsNullOrEmpty(s))
                return long.Parse(s);
            else
                return long.MinValue;

        }
        public static int getInt(string ParameterName, DataTable DTtParameter = null)
        {
            string s = get(ParameterName, DTtParameter);

            if (!String.IsNullOrEmpty(s))
                return int.Parse(s);
            else
                return int.MinValue;
        }
        public static string getString(string ParameterName, DataTable DTtParameter = null)
        {

            return get(ParameterName, DTtParameter);

        }
        public static DateTime getDateTime(string ParameterName)
        {

            return getDateTime(ParameterName, "yyyy-MM-dd HH:mm:ss");

        }
        public static DateTime getDateTime(string ParameterName, string format)
        {
            String value = get(ParameterName);
            DateTime retorno = DateTime.MinValue;
            DateTime.TryParseExact(value, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out retorno);
            return retorno;

        }
        public static TimeSpan getTime(string ParameterName, DataTable DTtParameter = null)
        {
            string s = get(ParameterName, DTtParameter);

            if (!String.IsNullOrEmpty(s))
                return TimeSpan.Parse(s);
            else
                return TimeSpan.MinValue;
        }

        public static tParameter.tParameterTable getAll(string tag)
        {
            tParameter tparameter = new tParameter();
            try
            {
                if (string.IsNullOrEmpty(tag))
                    tparameter.GetData();
                else
                    tparameter.GetDataLike(tag);

                return tparameter.Table;
            }
            finally
            {
                tparameter.Dispose();
            }
        }

        #endregion

    }

}
