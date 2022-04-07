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
            
            
            Wait.WaitToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div", 4);

            // now click on addnew 
            IWebElement addnewButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            addnewButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input", 5);
            

            // type to add Language to add new language 
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.SendKeys("English");

            
            // click on choose language levels teardown to choose level ////*[@id="account-profile-section"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]
            IWebElement chooseLanguageLevel = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[1]"));
            chooseLanguageLevel.Click();

            // click on conversational level
            IWebElement conversationalLevel= driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]"));
            conversationalLevel.Click();
            Thread.Sleep(1000);

            // click on add button to add given new langaguage and level 
            IWebElement addButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addButton.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]", 4);
            

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
            Wait.WaitToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)", 4);
            // updating  created langaguage

            // click on  edit icon to edit exiting langaguge

            IWebElement editButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
            editButton.Click();
            Thread.Sleep(2000);

            // click on add langagaue to update to new laguage
            IWebElement addLangagueUpdate = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            addLangagueUpdate.Click();
            addLangagueUpdate.Clear();
            addLangagueUpdate.SendKeys("Telugu");
            addLangagueUpdate.Click();

            // click on chooselanguagelevel as fluent
            IWebElement chooseLanguageLevel = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select > option:nth-child(4)"));
            chooseLanguageLevel.Click();
            Thread.Sleep(2000);
            


            // click on update button to update new record
            IWebElement updateButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateButton.Click();
            Thread.Sleep(2000);

            // to check updated data is sucessfull or not 
            IWebElement updateData = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select > option:nth-child(4)"));
            

            // option 1 
            Assert.That(updateData.Text == "Fluent", "upaded data and excepted data do not match");

           
        }
        public void DeleteProfile(IWebDriver driver)
        {
           Wait.WaitToBeClickable(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(2)", 4);
            // delete updated record 

            // click on delete icon to delete updated record
            IWebElement deleteButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(2)"));
            deleteButton.Click();
            Thread.Sleep(2000);

            // to check delete data is sucessful or not 
              IWebElement deleteData = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select > option:nth-child(4)"));
            Thread.Sleep(1000);

            // option 1 
            Assert.That(deleteData.Text == "Fluent", "deleted data and excepted data do not match");


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
