using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;

namespace VoxData.VoxCRM.Service.CRIStatistics
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            CRIService criService = new CRIService();
            criService.Start();
            Console.ReadKey();
            criService.Stop();
#else

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new CRIService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
