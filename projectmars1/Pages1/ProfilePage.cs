using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using projectmars1.Utilities;

namespace projectmars1.Pages1
{
    public class ProfilePage
    {                                         
        public void CreateProfile(IWebDriver driver)
        {
            Thread.Sleep(6000);
           // Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[1]/div/a[2]", 40);
            // adding  new language
            
            // go to profile page 
            IWebElement Profile = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]"));  
            Profile.Click();
           // Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]", 40);
            Thread.Sleep(6000);
            // click on  Languages to add new language on profile page  
            IWebElement selectLanguages = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            selectLanguages.Click();

            // now click on addnew 
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]"));
            addnewButton.Click();
           // Wait.WaitToBeVisible(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 32);
            Thread.Sleep(6000);

            // type to add Language to add new language 
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.Click();
            addLanguage.SendKeys("English");

            
            // click on choose language levels teardown to choose level ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
            chooseLanguageLevel.Click();

            // click on conversational level
            IWebElement conversationalLevel= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            conversationalLevel.Click();

            // click on add button to add given new langaguage and level 
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Wait.WaitToBeVisible(driver, "Xpath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]", 32);
            //Thread.Sleep(1000);

            // to check added data is sucessfull or not 
            IWebElement addedData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));

            // option 1 
            Assert.That(addedData.Text == "Conversational", "Added data and expected data do not match");

            // option 2 
            //  if(addedData.Text == "Conversational")
            //  {
            //    Assert.Pass("language is added successfully");    
            //
            //  }
            //  else
            //  {
            //     Assert.Fail("language is failed");
            //  }


        }
        public void EditProfile(IWebDriver driver)
        {
            // updating  created langaguage

            // click on  edit icon to edit exiting langaguge

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            // click on add langagaue to update to new laguage
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

            // to check updated data is sucessfull or not 
            IWebElement updatedData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));

            // option 1 
            Assert.That(updatedData.Text == "Fluent", "upaded data and excepted data do not match");

           
        }
        public void DeleteProfile(IWebDriver driver)
        {
            // delete updated record 

            // click on delete icon to delete updated record
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]"));
            Thread.Sleep(2000);
            deleteButton.Click();

            // to check deleted data is sucessful or not 
            IWebElement deletedData = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[4]"));

            // option 1 
            Assert.That(deletedData.Text == "Fluent", "deleted data and excepted data do not match");

           

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
