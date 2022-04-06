using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using projectmars1.Utilities;

namespace projectmars1.Pages1
{
    internal class ProfilePage
    {
        public void CreateProfile(IWebDriver driver)                   
        {                                                    
            // adding  profile records

            // go to profile page 
            IWebElement Profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 2000);
            Profile.Click();

            // click on  Languages on profile page 
            IWebElement Languages = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
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
            Thread.Sleep(2000);         
                                  
        }

        public void EditProfile(IWebDriver driver)
        {
            // update created langaguage

            // click on  edit icon to edit exiting langaguge

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(2000);

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
            Thread.Sleep(2000);
            
        } 

        public void DeleteProfile(IWebDriver driver)
        {
            // delete updated record 

            // click on delete icon to delete updated record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Thread.Sleep(2000);
            deleteButton.Click();

        }

        public void SignoutProfile(IWebDriver driver)
        {
            // siging out of the page once deleting is done 

            // Signout of the page 
            IWebElement SignOutButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/a[2]/button"));
            Thread.Sleep(3000);
            SignOutButton.Click();
        }
               
    }
}
