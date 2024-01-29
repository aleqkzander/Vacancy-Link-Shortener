using Vacancy_Link_Shortener.Objects;
using Vacancy_Link_Shortener.Platforms;

Vacancy stellenchaVacancy = new
    ( 12345, "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.", ["München", "Dresden", "Berlin"],
    new Stellencha());

Vacancy jobsMitBizzVanacy = new
    (12345, "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.", ["Berlin", "Hamburg", "Frankfurt", "Köln", "Bayern"],
    new JobsMitBizz());

Vacancy jobDealerVacancy = new
    (12345, "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.", ["München", "Dresden", "Berlin"],
    new JobDealer());

List<Vacancy> vacancies = [stellenchaVacancy, jobsMitBizzVanacy, jobDealerVacancy];

foreach(Vacancy vacancy in vacancies)
{
    Console.WriteLine(vacancy.GetSiteContent().Url() + "\n"
    + vacancy.GetSiteContent().Title() + "\n\n");
}
