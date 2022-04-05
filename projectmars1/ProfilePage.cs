using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace projectmars1
{
    internal class ProfilePage
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //lauch turnup portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // click on signInbutton
            IWebElement signInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signInButton.Click();

            //  identify emailaddress and enter valid details
            IWebElement emailaddress = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddress.SendKeys("karkapriyanka@gmail.com");

            //  identify password and enter valid details
            IWebElement password = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            password.SendKeys("testing");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();
            Thread.Sleep(1000);

            // check user is logged in successfully
            IWebElement Hipriyanka = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            if (Hipriyanka.Text == "Hipriyanka")
            {
                Console.WriteLine("logged in sucessfull, test passed.");
            }
            else
            {
                Console.WriteLine("login failed, test failed.");
            }

            // adding  profile records

            // go to profile page 
            IWebElement profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            profile.Click();

            // click on  Languages on profile page 
            IWebElement Languages = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[1]/h3"));
            Languages.Click();

            // click on addnewbutton
            IWebElement AddnewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            AddnewButton.Click();

            // click on add Language to add language
            IWebElement AddLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            AddLanguage.SendKeys("English");

            // click on choose language levels teardown
            IWebElement ChooseLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            ChooseLanguageLevel.Click();

            IWebElement Conversational = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            Conversational.Click();

            // click on add button to add 
            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(1000);

            // update created langaguage

            // click on  edit icon to edit exiting langaguge

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(1000);
            
            // click on add langagaue to update to new one 
            IWebElement addLangagueUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            addLangagueUpdate.Clear();
            addLangagueUpdate.SendKeys("Telugu");
            
            // click on choose language levels as fluent
            IWebElement chooseLanguageLevelUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));
            chooseLanguageLevelUpdate.Click();
            

            // click on update button to update new record
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
            Thread.Sleep(1000);

            // delete updated record 

            // click on delete icon to delete updated record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            deleteButton.Click();
            Thread.Sleep(1000);


        }
    }
}
