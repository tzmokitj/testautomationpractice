using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class AuthenticationPage
    {
        readonly IWebDriver driver;
        public By authPage = By.Id("authentication");
        public By emailAddress = By.Id("email");
        public By password = By.Id("passwd");
        public By signInBtn = By.Id("SubmitLogin");
        public AuthenticationPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(authPage));

        }
    }
}
