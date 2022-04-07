using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using projectmars1.Pages1;
using projectmars1.Utilities;


namespace projectmars1.Utilities
{
    public class CommonDriver
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            // open chrome browser
             driver = new ChromeDriver();
             driver.Manage().Window.Maximize();
            
            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }
        public void CloseTestRun()
        {
            driver.Close();
        }
                      

    }
}
