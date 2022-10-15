using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);
        [Given(@"User clicks on Sign in option")]
        public void GivenUserClicksOnOption()
        {
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenFillsAndOptions()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.emailAddress,TestConstants.Username);
            ut.EnterTextInElement(ap.password,TestConstants.Password);
        }
        
        [When(@"clicks Sign in option")]
        public void WhenClicksOption()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(ap.signInBtn);
        }
        
        [Then(@"user will be logged in")]
        public void ThenAppropriatePageIsDisplayed()
        {
            MyAccountPage mp = new MyAccountPage(Driver);
            Assert.True(ut.ElementIsDisplayed(mp.signOutBtn), "User is not logged in");

        }
      

    }



}
