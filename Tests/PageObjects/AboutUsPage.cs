using OpenQA.Selenium;
using TestProject2.Helper;

namespace TestProject2.Tests.PageObjects
{

    public class AboutUsPage()
    {
        private SeleniumHelper _brower;

        public AboutUsPage(IWebDriver webDriver) : this()
        {
            _brower = new SeleniumHelper(webDriver);
        }
        
    }
}