namespace Vacancy_Link_Shortener
{
    public abstract class AbstractPlatform : IPlatform
    {
        private string _platform;
        private string _baseurl;

        public AbstractPlatform(string platform, string baseurl)
        {
            _platform = platform;
            _baseurl = baseurl;
        }

        public abstract string GetPlatform();

        public abstract string GetBaseUrl();

        public abstract string BuildUrl(string _id, string _title, string _company);

        public abstract string BuildTitle(string[] regions, string title, string company);

        public abstract string RemoveSpecialChars(string input);

        public abstract string CreateRegionInfo(string[] regions);
    }
}
