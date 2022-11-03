using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSdet1.StepDefinitions
{
    [Binding]
    public class VtigerStepDefinitions
    {
        WebDriver driver;
        
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();
        }

        [Given(@"Enter the url")]
        public void GivenEnterTheUrl()
        {
            driver.Navigate().GoToUrl("http://localhost:8888/");
        }

        //[When(@"in Login page enter valid username and valid password")]
        //public void WhenInLoginPageEnterValidUsernameAndValidPassword()
        //{
        //    //driver.FindElement(By.Name("user_name")).SendKeys("admin");
        //    //driver.FindElement(By.Name("user_password")).SendKeys("admin");
            
        //}

        [When(@"in Login page enter valid username ""([^""]*)""and valid password ""([^""]*)""")]
        [When(@"in Login page enter valid username ""([^""]*)"" and valid password ""([^""]*)""")]
        public void WhenInLoginPageEnterValidUsernameAndValidPassword(string usn, string pwd)
        {
            driver.FindElement(By.Name("user_name")).SendKeys(usn);
            driver.FindElement(By.Name("user_password")).SendKeys(pwd);
            //driver.FindElement(By.Id("submitButton")).Click();
        }
        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Id("submitButton")).Click();
        }

        [Then(@"verify home page is displayed or not")]
        public void ThenVerifyHomePageIsDisplayedOrNot()
        {
            //String actual = driver.Title;
            //actual = actual.Trim();
            //Assert.True(actual.Contains("Administrator - Home - vtiger CRM 5 - Commercial Open Source CRM"));

        }
    }
}
