namespace Vacancy_Link_Shortener
{
    public class Platform
    {
        private string _platform;
        private string _baseurl;

        public Platform(string platform, string baseurl)
        {
            _platform = platform;
            _baseurl = baseurl;
        }

        public string GetPlatform() { return _platform.ToLower().Replace("_", "."); }
        public string GetBaseUrl() { return _baseurl; }
    }
}
