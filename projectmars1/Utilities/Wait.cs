using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace projectmars1.Utilities
{
    internal class Wait
    {
        public static void WaitToBeClickable(IWebDriver driver, string locator, string locaterValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(locaterValue)));
            }

           
           
        }
        

        public static void WaitToBeVisible(IWebDriver driver, string locator, string locaterValue, int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, seconds));

            if (locator == "Xpath")
            {
                wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locaterValue)));
            }

            


        }
       


    }
}
