using OpenQA.Selenium;
using TestProject2.Helper;
using TestProject2.Tests.PageObjects;

namespace TestProject2.Tests.PageSteps;

public class AboutUsSteps(IWebDriver webDriver) : AboutUsPage
{
    private readonly SeleniumHelper _browser = new(webDriver);

    public void Click(string name)
    {
        _browser.ClickElement(NavIconCta(name));
    }
}