using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class CartSummaryPage
    {
        readonly IWebDriver driver;
        public By cartSummaryPage = By.Id("order");
        public By cartItem = By.CssSelector("td.cart_description");
        
        public CartSummaryPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartSummaryPage));
        }
    }
}
