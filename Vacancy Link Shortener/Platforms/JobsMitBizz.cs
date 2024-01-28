using Vacancy_Link_Shortener.AbstractClasses;

namespace Vacancy_Link_Shortener.Platforms
{
    public class JobsMitBizz : Platform
    {
        private string _baseurl = "https://www.jobs-mit.biz/Jobs";

        public override string BuildUrl(int id, string title, string company, string[] regions)
        {
            string _region = CreateRegionInfoForUrl(regions);
            string _title = RemoveSpecialChars(title);
            return $"{_baseurl}/{_region}/{id}/{_title}/";
        }

        public override string BuildTitle(string[] regions, string title, string company)
        {
            string regioninfo = CreateRegionInfo(regions);

            return $"Jetzt Bewerben! - {title} @ {regioninfo}";
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
             .Replace("_", ".")
             .Replace("ü", "ue"); ;

            return trimedInput;
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
                    _region += $"{regions[region]}-";
                }
            }

            string cleanedRegion = _region.Replace("ü", "ue");

            return cleanedRegion;
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
                else if (region == regions.Count() - 2)
                {
                    regioninfo += $"{regions[region]} und ";
                }
                else
                {
                    regioninfo += $"{regions[region]}, ";
                }
            }

            return regioninfo;
        }
    }
}
