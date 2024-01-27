using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Vacancy_Link_Shortener
{
    internal class PlatformStellencha : AbstractPlatform
    {
        private string _platform;
        private string _baseurl;

        public PlatformStellencha(string platform, string baseurl) : base(platform, baseurl)
        {
            _platform = platform;
            _baseurl = baseurl;
        }

        public override string BuildTitle(string[] regions, string title, string company)
        {
            string regioninfo = CreateRegionInfo(regions);
            return $"{title} | {company} | {regioninfo} | {_platform}";
        }

        public override string BuildUrl(string _id, string _title, string _company)
        {
            string baseurl = _baseurl;
            string company = RemoveSpecialChars(_company);
            string title = RemoveSpecialChars(_title);
            return $"{baseurl}/{company}/{_id}/{title}/";
        }

        public override string CreateRegionInfo(string[] regions)
        {
            string regioninfo = string.Empty;

            for (int region = 0; region < regions.Count(); region++)
            {
                if (region == regions.Count() - 1)
                {
                    regioninfo += $"{regions[region]}";
                }
                else
                {
                    regioninfo += $"{regions[region]}, ";
                }
            }

            return regioninfo;
        }

        public override string GetBaseUrl()
        {
            return _baseurl;
        }

        public override string GetPlatform()
        {
            return _platform.ToLower().Replace("_", ".");
        }

        public override string RemoveSpecialChars(string input)
        {
            input
             .ToLower()
             .Replace(' ', '-')
             .Replace("(", "")
             .Replace(")", "")
             .Replace("&", "-")
             .Replace("/", "-")
             .Replace("%", "")
             .Replace(",", "")
             .Replace(".", "")
             .Replace("--", "");

            return input;
        }
    }
}
