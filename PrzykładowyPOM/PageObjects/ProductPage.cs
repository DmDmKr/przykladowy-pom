using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace PrzykładowyPOM
{
    internal class ProductPage
    {
        private IWebDriver _driver;
        private WebDriverWait _wait => new WebDriverWait(_driver, TimeSpan.FromSeconds(5));

        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By _addToCartButton = By.CssSelector("#add_to_cart>button");
        private By _addedToCartIcon = By.CssSelector("i.icon-ok");
        private By _goToCartButton = By.CssSelector("a[title='Proceed to checkout']");

        internal ProductPage AddToCart()
        {
            _driver.FindElement(_addToCartButton).Click();
            _wait.Until(d => _driver.FindElement(_addedToCartIcon));            
            return new ProductPage(_driver);
        }

        internal CartPage GoToCart()
        {
            IWebElement proceedToCheckoutButton = _driver.FindElement(_goToCartButton);
            _wait.Until(d => proceedToCheckoutButton.Displayed == true);
            proceedToCheckoutButton.Click();
            return new CartPage(_driver);
        }
    }
}