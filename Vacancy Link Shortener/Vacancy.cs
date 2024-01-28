using Vacancy_Link_Shortener.Platforms;

namespace Vacancy_Link_Shortener
{
    public class Vacancy
    {
        private int _id;
        private string _title;
        private string _company;
        private string[] _regions;
        private PlatformStellencha _platform;

        public Vacancy(int id, string title, string company, string[] regions, PlatformStellencha platform)
        {
            _id = id;
            _title = title;
            _company = company;
            _regions = regions;
            _platform = platform;
        }

        public SiteContent GetSiteContent()
        {
            /*
             * The platform will setup the required fields
             */

            return new SiteContent(BuildUrl(), BuildTitle());
        }

        private string BuildUrl()
        {
            return _platform.BuildUrl(_id, _title, _company);
        }

        private string BuildTitle()
        {
            return _platform.BuildTitle(_regions, _title, _company);
        }
    }
}
