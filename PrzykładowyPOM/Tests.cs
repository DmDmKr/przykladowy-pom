using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace PrzykładowyPOM
{
    public class Tests
    {
        private IWebDriver _driver;
        [SetUp]
        public void SetUpDriver()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }
        [TearDown]
        public void QuitDriver()
        {
            _driver.Quit();
        }

        [Test]
        public void AddToCartTest()
        {
            MainPage mainPage = new MainPage(_driver);
            string productName = "Blouse";
            int numberOfItemsInCart = mainPage.GoTo().GoToProduct(productName).AddToCart().GoToCart().GetNumberOfItems();
            Assert.AreEqual(1, numberOfItemsInCart);
        }
    }
}
