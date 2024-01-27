namespace Vacancy_Link_Shortener
{
    public class Vacancy
    {
        private int _id;
        private string _title;
        private string _company;
        private string[] _regions;
        private Platform _platform;

        public Vacancy(int id, string title, string company, string[] regions, Platform platform)
        {
            _id = id;
            _title = title;
            _company = company;
            _regions = regions;
            _platform = platform;
        }

        public SiteContent GetSiteContent()
        {
            return new SiteContent(GetUrl(), GetTitle());
        }

        private string GetUrl()
        {
            string baseurl = _platform.GetBaseUrl();
            string company = RemoveSpecialChars(_company);
            string title = RemoveSpecialChars(_title);
            return $"{baseurl}/{company}/{_id}/{title}/";
        }

        private string GetTitle()
        {
            string regioninfo = CreateRegionInfo();
            return $"{_title} | {_company} | {regioninfo} | {_platform.GetPlatform()}";
        }

        private string RemoveSpecialChars(string input)
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

        private string CreateRegionInfo()
        {
            string regioninfo = string.Empty;

            for (int region = 0; region < _regions.Count(); region++)
            {
                if (region == _regions.Count() - 1)
                {
                    regioninfo += $"{_regions[region]}";
                }
                else
                {
                    regioninfo += $"{_regions[region]}, ";
                }
            }

            return regioninfo;
        }
    }
}
