using Vacancy_Link_Shortener.AbstractClasses;

namespace Vacancy_Link_Shortener.Platforms
{
    public class JobDealer : Platform
    {
        private string _platform = "JOB_DEALER";
        private string _baseurl = "https://www.job.dealer/job";

        public override string BuildUrl(int id, string title, string company, string[] regions)
        {
            string _region = CreateRegionInfoForUrl(regions);
            string _company = RemoveSpecialChars(company);
            string _title = RemoveSpecialChars(title);
            return $"{_baseurl}/{id}_{_title}_bei_{_company}_in_{_region}";
        }

        public override string BuildTitle(string[] regions, string title, string company)
        {
            string regioninfo = CreateRegionInfo(regions);

            return $"{title} bei {company} in {regioninfo} von deinem {ExtractPlatformName(_platform)}";
        }

        private string CreateRegionInfoForUrl(string[] regions)
        {
            string _region = string.Empty;

            for (int region = 0; region < regions.Length; region++)
            {
                if (region == regions.Length - 1)
                {
                    _region += $"{regions[region]}";
                }
                else
                {
                    _region += $"{regions[region]}_";
                }
            }

            return RemoveSpecialChars(_region);
        }

        private string RemoveSpecialChars(string input)
        {
            string trimedInput = input
             .Replace(' ', '_')
             .Replace("-", "")
             .Replace("__", "_")
             .Replace("%", "")
             .Replace("(", "")
             .Replace("/", "_")
             .Replace(")", "")
             .Replace("&_", "")
             .Replace(".", "")
             .Replace("ü", "ue");

            return trimedInput;
        }

        private string CreateRegionInfo(string[] regions)
        {
            string regioninfo = string.Empty;

            for (int region = 0; region < regions.Length; region++)
            {
                if (region == regions.Count() - 1)
                {
                    regioninfo += $"{regions[region]}";
                }
                else if (region == regions.Length - 2)
                {
                    regioninfo += $"{regions[region]} oder ";
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
