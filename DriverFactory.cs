using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace pocsalesman
{
    public class DriverFactory
    {
        public static IWebDriver _driver;

        // Construtor da classe. 
        public DriverFactory()
        {
            // Inicializa o browser utilizando o ChromeDriver que está no caminho /Users/Maximiliano/Documents
            ChromeDriverService service = ChromeDriverService.CreateDefaultService("/Users/Maximiliano/Documents/");
            
            // Faz criação de porta para abrir o browser.
            service.Port = new Random().Next(64000, 64800);
            
            // Inicializa o IWebDriver do selenium, é ele que disponibiliza as consultas e manipulacoes das paginas. 
            _driver = new ChromeDriver(service);
            
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Manage().Window.Maximize();
        }

        // Navega para determinada URL
        public void NavigateToUrl(String url)
        {            
            _driver.Navigate().GoToUrl(url);
        }

        // Finaliza driver e serviço.
        public static void Close()
        {
            _driver.Quit();
        }

        // Disponibiliza driver.
        public IWebDriver GetWebDriver()
        {
            return _driver;
        }
    }
}