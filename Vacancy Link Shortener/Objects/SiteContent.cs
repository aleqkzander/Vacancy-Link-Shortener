namespace Vacancy_Link_Shortener.Objects
{
    public class SiteContent(string url, string title)
    {
        private string _url = url;
        private string _title = title;

        public string Url() { return _url; }
        public string Title() { return _title; }
    }
}
