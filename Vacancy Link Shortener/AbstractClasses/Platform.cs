namespace Vacancy_Link_Shortener.AbstractClasses
{
    public abstract class Platform
    {
        public abstract string BuildUrl(int _id, string _title, string _company);

        public abstract string BuildTitle(string[] regions, string title, string company);
    }
}
