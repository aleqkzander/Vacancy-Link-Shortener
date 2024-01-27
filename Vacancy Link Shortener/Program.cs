using Vacancy_Link_Shortener;

Vacancy vacancy = new
    (
    12345,
    "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.",
    ["München", "Dresden", "Berlin"],
    new Platform("STELLENCHA_OS", "https://www.stellencha.os/stellen")
    );

Vacancy jobmitbiz = new
    (
    12345,
    "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.",
    ["München", "Dresden", "Berlin"],
    new Platform("JOBS_MIT_BIZ", "https://www.jobs-mit.biz/Jobs")
    );

Vacancy jobdealer = new
    (
    12345,
    "Junior Software Developer (m/w/d) - 100% remote",
    "Software & More Inc.",
    ["München", "Dresden", "Berlin"],
    new Platform("JOB_DEALER", "https://www.job.dealer/job")
    );

SiteContent content = jobmitbiz.GetSiteContent();

Console.WriteLine(
    $"URL {content.GetUrl()}\n" +
    $"Title {content.GetTitle()}"
    );
