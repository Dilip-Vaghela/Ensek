using OpenQA.Selenium;
using TestProject2.Helper;
using TestProject2.Tests.PageObjects;
using TestProject2.Tests.PageSteps;

namespace TestProject2.Tests.TestScripts;

public class AboutUsPageTests : TestBaseDesktop
{
    private SeleniumHelper _browser;
    private AboutUsSteps _aboutUsSteps;

    public AboutUsPageTests(string profile, string browser) : base(profile, browser)
    {
    }

    [Test,
     Description("Test Case – Ensek | Header | CTAs"),
     TestCase("Home", BaseUrl + "/"),
     TestCase("About", BaseUrl + "/Home/About"),
     TestCase("Contact", BaseUrl + "/Home/Contact"),
     TestCase("Register", BaseUrl + "/Account/Register"),
     TestCase("Log in", BaseUrl + "/Account/Login")
    ]
    public void Test_Ensek_header_CTAs(string name, string path)
    {
        _browser = new SeleniumHelper(WebDriver);
        _aboutUsSteps = new AboutUsSteps(WebDriver);

        _browser.Goto(BaseUrl);
        _aboutUsSteps.Click(name);
        _browser.WaitForPageUrl(path);
    }
}