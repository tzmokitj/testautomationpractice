using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class SignUpPage
    {
        readonly IWebDriver driver;
        public By signUpPage = By.Id("account-creation_form");
        public By registerBtn = By.Id("submitAccount");
        public By firstName = By.Id("customer_firstname");
        public By lastName = By.Id("customer_lastname");
        public By password = By.Id("passwd");
        public By address = By.Id("address1");
        public By city = By.Id("city");
        public By state = By.Id("id_state");
        public By zipCode  = By.Id("postcode");
        public By phone = By.Id("phone_mobile");


        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signUpPage));

        }

    }

}
