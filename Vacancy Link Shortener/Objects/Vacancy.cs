using Vacancy_Link_Shortener.AbstractClasses;

namespace Vacancy_Link_Shortener.Objects
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
            /*
             * A platform class is designed to organize and structure data, with its build methods returning the structured data.
             * To create a new platform, derive from the base platform class and override the necessary methods.
             */

            return new SiteContent
                (
                _platform.BuildUrl(_id, _title, _company, _regions).ToLower(), 
                _platform.BuildTitle(_regions, _title, _company)
                );
        }
    }
}
