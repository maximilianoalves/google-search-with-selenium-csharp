using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Xunit;

namespace pocsalesman
{
    public class SearchTest : IDisposable
    {

        public void Dispose()
        {
            DriverFactory.Close();      
        }
        
        [Fact]
        public void TestSearchGoogle()
        {
            SearchPage.GotoBaseUrl();
            SearchPage.FillSearchField();
            Thread.Sleep(10000);
        }
    }
}