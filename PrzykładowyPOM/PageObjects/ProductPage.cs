using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PrzykładowyPOM
{
    internal class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        internal ProductPage AddToCart()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.FindElement(By.CssSelector("#add_to_cart>button")).Click();
            _wait.Until(d => _driver.FindElement(By.CssSelector("i.icon-ok")));            
            return new ProductPage(_driver);
        }

        internal CartPage GoToCart()
        {
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement proceedToCheckoutButton = _driver.FindElement(By.CssSelector("a[title='Proceed to checkout']"));
            _wait.Until(d => proceedToCheckoutButton.Displayed == true);
            proceedToCheckoutButton.Click();
            return new CartPage(_driver);
        }
    }
}