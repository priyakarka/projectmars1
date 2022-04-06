using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using projectmars1.Utilities;

namespace projectmars1.Pages1
{
    [TestFixture]
    internal class Profile_Tests:  CommonDriver
    {        
        [SetUp]
        public void LoginFunction()
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
        }

        [Test]
        public void CreateProfile_Test()
        {
           // Create page object initialization and definition
           ProfilePage profilePageObj = new ProfilePage();
           profilePageObj.CreateProfile(driver);
        }

        [Test]
        public void EditProfile_Test()
        {
            // Edit Profile
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfile(driver);
        }

        [Test]
        public void DeleteProfile_Test()
        {
            // Delete Profile
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteProfile(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {
            // SignOut Profile
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.SignoutProfile(driver);


        }

    }


}
