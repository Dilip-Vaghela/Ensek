using OpenQA.Selenium;
using TestProject2.Helper;
using TestProject2.Tests.PageObjects;

namespace TestProject2.Tests.PageSteps;

public class AboutUsSteps : AboutUsPage
{
    private readonly SeleniumHelper _browser;

    public AboutUsSteps(IWebDriver webDriver)
    {
        _browser = new SeleniumHelper(webDriver);
    }
    public void Click(string name)
    {
        _browser.ClickElement(NavIconCta(name));
    }
}