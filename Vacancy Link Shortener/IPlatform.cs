namespace Vacancy_Link_Shortener
{
    public interface IPlatform
    {
        public string GetPlatform();
        public string GetBaseUrl();
        public string BuildUrl(string _id, string _title, string _company);
        public string BuildTitle(string[] regions, string title, string company);
        public string RemoveSpecialChars(string input);
        public string CreateRegionInfo(string[] regions);
    }
}
