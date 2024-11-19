using OpenQA.Selenium;
using TestProject2.Helper;

namespace TestProject2.Tests.PageObjects
{

    public class AboutUsPage
    {
        public By NavIconCta(string name) => 
            By.XPath($"//*[@class='navbar-collapse collapse']//li[*]/a [text()='{name}']");

    }
}