using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class PDPage
    {
        readonly IWebDriver driver;
        public By pdPage = By.Id("product");
        public By quantity = By.Id("quantity_wanted");
        public By productName = By.XPath("//h1[@itemprop='name']");
        public By addToCartBtn = By.Id("add_to_cart");
        public By ProceedToCheckout = By.XPath("//a[@title='Proceed to checkout']");

        public PDPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pdPage));
        }
    }
}