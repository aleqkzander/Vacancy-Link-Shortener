namespace Vacancy_Link_Shortener.AbstractClasses
{
    public abstract class Platform
    {
        public abstract string BuildUrl(int id, string title, string company, string[] regions);

        public abstract string BuildTitle(string[] regions, string title, string company);
    }
}
