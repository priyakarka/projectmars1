using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using projectmars1.Pages1;
using projectmars1.Utilities;
using TechTalk.SpecFlow;

namespace projectmars1.StepDefinitions
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {



        [Given(@"I logged into Turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [When(@"I add '([^']*)' details in language")]
        public void WhenIAddDetailsInLanguage(string language)
        {
            // Profile create page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfileDetails(driver, language);

        }

        [Then(@"the '([^']*)' and level details should be successfully")]
        public void ThenTheAndLevelDetailsShouldBeSuccessfully(string Tamil)
        {

            Thread.Sleep(2000);
            ProfilePage profilePageObj = new ProfilePage();

            string newaddedData = profilePageObj.GetaddedData(driver);

            Assert.That(newaddedData == "Conversational", "Added data and expected data do not match");



        }



        [When(@"I update '([^']*)' details on an existing language")]
        public void WhenIUpdateDetailsOnAnExistingLanguage(string language)
        {
            // Profile create page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfileDetails(driver, language);
        }

        [Then(@"the language details should have the updated '([^']*)'")]
        public void ThenTheLanguageDetailsShouldHaveTheUpdated(string Telugu)
        {
            Thread.Sleep(2000);
            ProfilePage profilePageObj = new ProfilePage();
            string newupdateData = profilePageObj.GetupdateData(driver);
            Assert.That(newupdateData == "Fluent", "upaded data and excepted data do not match");
        }

        [When(@"I delete '([^']*)' details of updated language")]
        public void WhenIDeleteDetailsOfUpdatedLanguage(string language)
        {
            // Profile create page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteProfileDetails(driver, language);
        }

        [Then(@"the language details should have  deleted '([^']*)'")]
        public void ThenTheLanguageDetailsShouldHaveDeleted(string language)
        {
            Thread.Sleep(2000);
            ProfilePage profilePageObj = new ProfilePage();
            string newdeleteData = profilePageObj.GetdeleteData(driver);
            Assert.That(newdeleteData != "Fluent", "delete data and expected data do not match");
        }
                     
          

    }
}

