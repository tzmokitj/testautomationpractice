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
        private readonly PersonData personData;
        public MyAccountSteps(PersonData personData)
        {
            this.personData = personData;
        }
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

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.email, ut.GenerateRandomEmail());
            ut.ClickOnElement(ap.createAcc);
        }

        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.EnterTextInElement(sup.firstName, TestConstants.FirstName);
            ut.EnterTextInElement(sup.lastName, TestConstants.LastName);
            personData.FullName = TestConstants.FirstName  + " " + TestConstants.LastName;
            ut.EnterTextInElement(sup.password, TestConstants.Password);
            ut.EnterTextInElement(sup.address, TestConstants.Address);
            ut.EnterTextInElement(sup.city, TestConstants.City);
            ut.DropdownSelect(sup.state, TestConstants.State);
            ut.EnterTextInElement(sup.zipCode, TestConstants.ZipCode);
            ut.EnterTextInElement(sup.phone, TestConstants.MobilePhone);


        }

        [When(@"user submits the sign up form")]
        public void WhenUserSubmitsTheSignUpForm()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            
            Assert.True(ut.TextPresentInElement(personData.FullName),"User's full name is not displayed in the header");
        }



    }



}
