using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestAutomationPractice.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();

        public object Timespan { get; private set; }

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GenerateRandomEmail()
        {
            return string.Format("email{0}@mailnator.com", RandomName.Next(10000, 100000));
        }
        public void ClickOnElement(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
        }
        public void DropdownSelect(By select, string option)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = driver.FindElement(select);
            var selectElement = new SelectElement(dropdown);
            //Thread.Sleep(2000);
            selectElement.SelectByText(option);
        }
        public void EnterTextInElement(By locator, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);

        }
        public bool ElementIsDisplayed(By locator) {
            var wait = new WebDriverWait(driver,TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Displayed;

            }

        public string ReturnTextFromElement(By locator)
        {
            return driver.FindElement(locator).GetAttribute("textContent");
        }

        public bool TextPresentInElement(string text)
        {
            By textElement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement)).Displayed;
        }
        public bool TextPresentInElement2(string text)
        {
            By textElement = By.XPath("//*/td[2]/p/a");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement)).Displayed;
        }

        public IList<IWebElement> ReturnCategoryList(string catName)
        {
            By catOption = By.CssSelector(".sf-menu [title='" + catName + "']");
            IList<IWebElement> category = driver.FindElements(catOption);
            return category;
        }
        public string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[RandomName.Next(s.Length)]).ToArray());
        }


    }
    
}

