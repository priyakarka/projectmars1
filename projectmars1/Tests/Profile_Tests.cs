using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using projectmars1.Utilities;
using projectmars1.Pages1;

namespace projectmars1.Pages1
{
    [TestFixture]
    public class Profile_Tests: CommonDriver
    {        
               
            // open chrome browser
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();

            
        

        [Test, Order (1), Description("check if language is created")]
        public void CreateProfile_Test()
        {
           // Create page object initialization and definition
           ProfilePage profilePageObj = new ProfilePage();
           profilePageObj.CreateProfile(driver);
        }

        [Test, Order (2), Description("check if language is edited")]
        public void EditProfile_Test()
        {
            // Edit already addedProfile
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.EditProfile(driver);
        }

        [Test, Order (3), Description("check if  existing language is deleted")]
        public void DeleteProfile_Test()
        {
            // Delete created Profile
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.DeleteProfile(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            // SignOut from Profile page
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.SignoutProfile(driver);
            driver.Quit();
                     

        }

    }


}
