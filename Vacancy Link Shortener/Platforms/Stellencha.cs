using Vacancy_Link_Shortener.AbstractClasses;

namespace Vacancy_Link_Shortener.Platforms
{
    public class Stellencha : Platform
    {
        private string _platform = "STELLENCHA_OS";
        private string _baseurl = "https://www.stellencha.os/stellen";

        public override string BuildUrl(int id, string title, string company, string[] regions)
        {
            string _company = RemoveSpecialChars(company);
            string _title = RemoveSpecialChars(title);
            return $"{_baseurl}/{_company}/{id}/{_title}/";
        }

        public override string BuildTitle(string[] regions, string title, string company)
        {
            string regioninfo = CreateRegionInfo(regions);
            return $"{title} | {company} | {regioninfo} | {ExtractPlatformName(_platform)}";
        }

        private string RemoveSpecialChars(string input)
        {
            string trimedInput = input
             .Replace(' ', '-')
             .Replace("(", "")
             .Replace(")", "")
             .Replace("&", "-")
             .Replace("/", "-")
             .Replace("%", "")
             .Replace(",", "")
             .Replace(".", "")
             .Replace("--", "")
             .Replace("_", ".");
            return trimedInput;
        }

        private string CreateRegionInfo(string[] regions)
        {
            string regioninfo = string.Empty;

            for (int region = 0; region < regions.Length; region++)
            {
                if (region == regions.Length - 1)
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

        private string ExtractPlatformName(string platform)
        {
            return platform.ToLower().Replace("_", ".");
        }
    }
}
