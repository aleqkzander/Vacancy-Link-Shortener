using Vacancy_Link_Shortener;
using Vacancy_Link_Shortener.Platforms;

PlatformStellencha stellencha = new();

Vacancy stellenchaVacancy = new
    ( 12345, "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.", ["München", "Dresden", "Berlin"],
    stellencha);

Console.WriteLine(stellenchaVacancy.GetSiteContent().GetUrl() + "\n" + stellenchaVacancy.GetSiteContent().GetTitle());

//Vacancy jobmitbiz = new
//    (
//    12345,
//    "Junior Software Developer (m/w/d) - 100% remote",
//    "Software & More Inc.",
//    ["München", "Dresden", "Berlin"],
//    new Platform("JOBS_MIT_BIZ", "https://www.jobs-mit.biz/Jobs")s
//    );

//Vacancy jobdealer = new
//    (
//    12345,
//    "Junior Software Developer (m/w/d) - 100% remote",
//    "Software & More Inc.",
//    ["München", "Dresden", "Berlin"],
//    new Platform("JOB_DEALER", "https://www.job.dealer/job")
//    );  