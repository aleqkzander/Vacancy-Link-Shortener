namespace Vacancy_Link_Shortener
{
    public class SiteContent(string url, string title)
    {
        private string _url = url;
        private string _title = title;

        public string GetUrl() { return _url; }
        public string GetTitle() { return _title; }
    }
}
