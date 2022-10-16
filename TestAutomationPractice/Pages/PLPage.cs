using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class PLPage
    {
        readonly IWebDriver driver;
        public By plPage = By.Id("category");
        public By firstProduct = By.ClassName("product_img_link");
        public PLPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(plPage));
        }
    }
}
