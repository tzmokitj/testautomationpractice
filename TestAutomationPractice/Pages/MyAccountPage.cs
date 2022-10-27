using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class MyAccountPage
    {
        readonly IWebDriver driver;
        public By myAccountPage = By.Id("my-account");
        public By signOutBtn = By.ClassName("logout");
        public By myPersonalInformation = By.XPath("//a[@title='Information']");
        public MyAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(myAccountPage));
        }
    }
}
