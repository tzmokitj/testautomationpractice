using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAutomationPractice.Pages
{
    class PInfoPage
    {
        readonly IWebDriver driver;
        public By pInfoPage = By.Id("identity");
        public By pInfoLastName = By.Id("lastname");
        public By pInfoCurrentPassword = By.Id("old_passwd");
        public By pInfoSaveBtn = By.XPath("//button[@name='submitIdentity']");

        public PInfoPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(pInfoPage));
        }
    }
}
