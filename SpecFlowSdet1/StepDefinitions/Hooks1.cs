using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace SpecFlowSdet1.StepDefinitions
{
    [Binding]
    public sealed class Hooks1
    {
      //public  IWebDriver driver;
       //[ Before]
       //public void Launch()
       // {
       //     //driver = new ChromeDriver();
       //     //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
       //     //driver.Navigate().GoToUrl("http://localhost:8888/");
       //     Console.WriteLine("before");
       // }
       // [After]
       // public void Break()
       // {
       //     Console.WriteLine("After");
       //     //driver.Quit();
       // }
        [BeforeTestRun]
        public static void Break2()
        {
            Console.WriteLine("BeforeTestRun");
            
        }
        [BeforeScenario]
        public void Break3()
        {
            Console.WriteLine("BeforeScenario");

        }
        [BeforeScenarioBlock]
        public void Break4()
        {
            Console.WriteLine("BeforeScenarioBlock");

        }
        [AfterScenario]
        public void Break5()
        {
            Console.WriteLine("AfterScenario");

        }
        [AfterTestRun]
        public static void Break7()
        {
            Console.WriteLine("AfterTestRun");

        }
        [AfterScenarioBlock]
        public void Break6()
        {
            Console.WriteLine("AfterScenarioBlock");

        }
        [BeforeFeature]
        public static void Break8()
        {
            Console.WriteLine("AfterScenarioBlock");

        }
        [AfterFeature]
        public static  void Break9()
        {
            Console.WriteLine("AfterScenarioBlock");

        }
    }
}