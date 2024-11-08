using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SeleniumTests.Steps
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver? driver;

        [Given(@"I navigate to the login page")]
        public void GivenINavigateToTheLoginPage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com"); 
        }

        [When(@"I enter valid credentials")]
        public void WhenIEnterValidCredentials()
        {
            driver.FindElement(By.Id("username")).SendKeys("yourUsername"); // Replace with your username
            driver.FindElement(By.Id("password")).SendKeys("yourPassword"); // Replace with your password
            driver.FindElement(By.Id("loginButton")).Click(); // Replace with your login button ID
        }

        [Then(@"I should see the dashboard")]
        public void ThenIShouldSeeTheDashboard()
        {
            Assert.IsTrue(driver.Title.Contains("Dashboard"), "The dashboard title is not present."); // Adjust as needed
            driver?.Quit();
        }
    }
}
