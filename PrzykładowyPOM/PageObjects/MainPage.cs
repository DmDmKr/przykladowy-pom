using System;
using OpenQA.Selenium;

namespace PrzykładowyPOM
{
    internal class MainPage
    {
        private IWebDriver _driver;

        public MainPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal MainPage GoTo()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com");
            return new MainPage(_driver);
        }

        internal ProductPage GoToProduct(string productName)
        {
            _driver.FindElement(By.CssSelector("ul#homefeatured img[title='" + productName + "']")).Click();
            return new ProductPage(_driver);
        }
    }
}