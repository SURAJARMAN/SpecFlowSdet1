using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowSdet1.StepDefinitions
{
    [Binding]
    public class CreateORGStepDefinitions
    {
        IWebDriver driver;
        [Given(@"launch the browser and enter the url")]
        public void GivenLaunchTheBrowserAndEnterTheUrl()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:8888/");
        }

        [Given(@"in login page enter the url and password and click on login button")]
        public void GivenInLoginPageEnterTheUrlAndPasswordAndClickOnLoginButton()
        {
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();
        }

        [When(@"in home page click on oraganisation link")]
        public void WhenInHomePageClickOnOraganisationLink()
        {
            driver.FindElement(By.XPath("//td[@class='small']//a[contains(text(),'Organizations')]")).Click();
        }

        [When(@"in organisation page click on organisation image")]
        public void WhenInOrganisationPageClickOnOrganisationImage()
        {
            driver.FindElement(By.XPath("//img[@title='Create Organization...']")).Click();
        }

        [When(@"in create new org page enter the ""([^""]*)"" name")]
        public void WhenInCreateNewOrgPageEnterTheName(string or)
        {

            driver.FindElement(By.XPath("//input[@name='accountname']")).SendKeys(or);
            driver.FindElement(By.Name("button")).Click();

        }

        //[Then(@"verify ""([^""]*)"" is created or not")]
        //public void ThenVerifyIsCreatedOrNot(string organisation)
        //{
        //    driver.FindElement(By.XPath("//td[@class='small']//a[contains(text(),'Organizations')]")).Click();
        //   String  text=driver.FindElement(By.Id("massdelete")).Text;
        //    Console.WriteLine(text);
        //    if (text.Contains(organisation))
        //    {
        //        Assert.Pass();
        //    }
        //}
    } 
}
