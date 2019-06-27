using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace pocsalesman 
{
    public class BasePage 
    {
        public static DriverFactory _driverFactory = new DriverFactory();

        public static void GotoBaseUrl() {
             _driverFactory.NavigateToUrl("https://www.google.com.br");
        }
    }
}