using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pocsalesman 
{
    public class SearchPage: BasePage
    {
       
        static IWebDriver _driver = _driverFactory.GetWebDriver();

       public static void FillSearchField() {
            IWebElement webElement = null;
            webElement = _driver.FindElement(By.Name("q"));                       
            webElement.SendKeys("algo");      
       }
    }
}