using OpenQA.Selenium;
using TestProject2.Helper;

namespace TestProject2.Tests;

//Local drivers
[TestFixture("Local", "Desktop - Chrome")]
//[TestFixture("Local", "Desktop - Firefox")]
//[TestFixture("Local", "Desktop - Edge")]
//[TestFixture("Local", "Desktop - IE")]

//Browserstack
//[TestFixture("Browserstack", "Safari-Latest")]
//[TestFixture("Browserstack", "Safari-13")]
//[TestFixture("Browserstack", "Safari-12")]
//[TestFixture("Browserstack", "Safari-11")]
//[TestFixture("Browserstack", "Chrome-Latest")]
//[TestFixture("Browserstack", "Chrome-Beta")]
//[TestFixture("Browserstack", "Edge-Latest")]
//[TestFixture("Browserstack", "Edge-Beta")]
//[TestFixture("Browserstack", "FireFox-Latest")]
//[TestFixture("Browserstack", "FireFox-Beta")]
//[TestFixture("Browserstack", "IE11-Latest")]

//Nunit attributes
[Parallelizable(ParallelScope.All)]
[FixtureLifeCycle(LifeCycle.InstancePerTestCase)]
public class TestBaseDesktop
{
    private readonly string _profile;
    private readonly string _browser;
    public IWebDriver WebDriver;
    public const string BaseUrl = "https://ensekautomationcandidatetest.azurewebsites.net";

    public TestBaseDesktop(string profile, string browser)
    {
        _profile = profile;
        _browser = browser;
    }

    [SetUp]
    public void Setup()
    {
        WebDriver = new DriverHelpers().CreateDriver(_profile, _browser) ?? throw new InvalidOperationException();
        WebDriver.Manage().Window.Maximize();
    }

    [TearDown]
    public void TearDown()
    {
        new SeleniumHelper(WebDriver).Quit();
    }
}