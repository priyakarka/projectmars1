using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace projectmars1.Pages1
{
    internal class Profile_Tests
    {
        static void Main(string[] args)
        {

            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Profile page object initialization and definition
            ProfilePage profilePageObj = new ProfilePage();
            profilePageObj.CreateProfile(driver);

            // Edit Profile
            profilePageObj.EditProfile(driver);

            // Delete Profile
            profilePageObj.DeleteProfile(driver);

            // SignOut Profile
            profilePageObj.SignoutProfile(driver);


        }
    }
}
