using TestProject2.Helper;

namespace TestProject2.Tests.TestScripts;

public class AboutUsPageTests: TestBaseDesktop
{
    public AboutUsPageTests(string profile, string browser) : base(profile, browser) { }
    
    [Test]
    public void test()
    {
        SeleniumHelper browser = new SeleniumHelper(WebDriver);
        browser.Goto("https://ensekautomationcandidatetest.azurewebsites.net/");
        
    }
}