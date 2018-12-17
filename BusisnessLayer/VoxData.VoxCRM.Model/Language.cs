using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace VoxData.VoxCRM.Models
{
    public class Language
    {
        private readonly static Language instance = new Language();

        public static Language Instance
        {
            get
            {
                return instance;
            }
        }

        public Func<tLanguage> SessionLanguage;

        public delegate void SameTag(string Tag);
        public SameTag OnSameTag;

        volatile ConcurrentDictionary<int, ConcurrentDictionary<string, vTagLanguage>> Texts;

        private Language()
        {
            this.Texts = new ConcurrentDictionary<int, ConcurrentDictionary<string, vTagLanguage>>();
        }

        public bool ContainsLanguage(tLanguage tlanguage)
        {
            return this.ContainsLanguage(tlanguage.IDLanguage);
        }

        public bool ContainsLanguage(int IDLanguage)
        {
            return this.Texts.ContainsKey(IDLanguage);
        }

        public void UpdateTexts(List<vTagLanguage> texts, tLanguage tlanguage)
        {
            if (!this.ContainsLanguage(tlanguage))
            {
                IEnumerable<KeyValuePair<string, vTagLanguage>> values = texts.Select(x => new KeyValuePair<string, vTagLanguage>(x.vchTagName, x));
                this.Texts[tlanguage.IDLanguage] = new ConcurrentDictionary<string, vTagLanguage>(values);
            }
            else
            {
                texts.ForEach(x => this.Texts[tlanguage.IDLanguage][x.vchTagName] = x);
            }
        }

        public IEnumerable<vTagLanguage> GetTexts(tLanguage tLanguage)
        {
            return this.GetTexts(tLanguage.IDLanguage);
        }

        public IEnumerable<vTagLanguage> GetTexts(int IDLanguage)
        {
            if (this.Texts[IDLanguage] != null)
                return this.Texts[IDLanguage].Select(x => x.Value).ToList();
            else
                return new List<vTagLanguage>();
        }

        public string GetText(tLanguage tLanguage, string Tag)
        {
            if (tLanguage != null && this.Texts.ContainsKey(tLanguage.IDLanguage))
            {
                if(!this.Texts[tLanguage.IDLanguage].ContainsKey(Tag))
                {
                    if (this.OnSameTag != null)
                    {
                        this.OnSameTag(Tag);
                        return Tag;
                    }
                    return Tag + "_NOT_FOUND"; ;
                }

                return this.Texts[tLanguage.IDLanguage][Tag].vchText;
            }

            return Tag + "_NOT_FOUND";
        }

        public string GetText(string Tag)
        {
            tLanguage tLanguage = null;
            if (this.SessionLanguage != null)
                tLanguage = this.SessionLanguage();

            return this.GetText(tLanguage, Tag);
        }
    }

}
