using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading;

namespace SeleniumWebAutomation.WebDriver
{
    public class Driver
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static Actions action;
        private static FileStream stream;
        private static StreamReader reader;

        public static void DriverStart()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();            
        }

        public static void DriverQuit()
        {
            driver.Quit();
        }
        
        public static void GetAllCookies()
        {
            ReadOnlyCollection<Cookie> cookies = driver.Manage().Cookies.AllCookies;
        }

        public static void GoToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static IWebElement FindElementXpath(string xPath)
        {
            return driver.FindElement(By.XPath(xPath));
        }

        public static IWebElement FindElementId(string id)
        {
            return driver.FindElement(By.Id(id));
        }

        public static ReadOnlyCollection<IWebElement> FindElementsXpath(string xPath)
        {
            return driver.FindElements(By.XPath(xPath));
        }

        public static void Wait(int second)
        {
            Thread.Sleep(second * 1000);
        }

        public static void MoveToElement(IWebElement element)
        {
            action = new Actions(driver);
            action.MoveToElement(element).Build().Perform();
        }

        public static void NewTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }
        
        public static void NewTab2()
        {
            driver.SwitchTo().DefaultContent();
        }

        public static void JavaScriptClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript("arguments[0].click()", element);
        }

        public static void ElementIsVisible(By locator,int second)
        {
            try
            {
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(second));
                wait.Until(ExpectedConditions.ElementIsVisible(locator));
            }
            catch 
            {

                throw new ElementNotVisibleException("Element bulunamadı !!!");
            }
        }

        public static string FileRead(string path)
        {
            stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);
            return reader.ReadToEnd();
        }
    }
}
