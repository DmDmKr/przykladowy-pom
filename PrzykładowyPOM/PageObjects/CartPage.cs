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

        private By _itemRow = By.CssSelector("tbody>tr");


        internal int GetNumberOfItems()
        {
            return _driver.FindElements(_itemRow).Count;
        }
    }
}