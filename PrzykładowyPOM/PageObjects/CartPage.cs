using System;
using OpenQA.Selenium;

namespace PrzykładowyPOM
{
    internal class CartPage
    {
        private IWebDriver _driver;

        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal int GetNumberOfItems()
        {
            return _driver.FindElements(By.CssSelector("tbody>tr")).Count;
        }
    }
}