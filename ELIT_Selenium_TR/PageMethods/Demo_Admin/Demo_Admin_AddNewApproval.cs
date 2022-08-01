using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumExtras;
using NUnit.Framework;

namespace ELIT_Selenium_TR.PageMethods.Demo_Admin
{
    class Demo_Admin_AddNewApproval
    {
        private IWebDriver driver;

        string username = "//input[@placeholder='Enter Username']";
        string password = "//input[@placeholder='Enter Password']";
        string signin = "//button[text()='Login Now']";
        string general = "/html/body/div[1]/div[2]/aside/ul/li[2]/div";
        string approval_creation = "/html/body/div[1]/div[2]/aside/ul/li[2]/ul/li[2]/label";

        string approval_types_dd = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[1]/div/div/div/div/div/button";
        string approval_types = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[1]/div/div/div/div/input";
        string authorized_persons_dd = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div/div/div/div/div/button";
        string authorized_persons = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div/div/div/div/input";
        string levels_dd = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[3]/div/div/div/div/div/button";
        string levels = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[3]/div/div/div/div/input";
        string submit = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[4]/button[2]";

        string at_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(1) > div > span";
        string ap_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div > span";
        string level_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(3) > div > span";
        string profile = "/html/body/div[1]/div[1]/div[2]/button";
        string logout = "/html/body/div[5]/div[3]/ul/li[3]";



        public Demo_Admin_AddNewApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://149.202.70.54:4914/");
            Thread.Sleep(500);
        }

        public void UserName(String text)
        {
            driver.FindElement(By.XPath(username)).SendKeys(text);
            Thread.Sleep(500);
        }

        public void Password(string text)
        {
            driver.FindElement(By.XPath(password)).SendKeys(text);
            Thread.Sleep(500);
        }

        public void SignIn()
        {
            driver.FindElement(By.XPath(signin)).Click();
            Thread.Sleep(1000);
        }

        public void General()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(general)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Approval_Creation()
        {
            driver.FindElement(By.XPath(approval_creation)).Click();
            Thread.Sleep(1500);
        }

        public void Approval_Type(string text)
        {

            driver.FindElement(By.XPath(approval_types_dd)).Click();
            Thread.Sleep(2500);

            driver.FindElement(By.XPath(approval_types)).SendKeys(text);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(approval_types)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(approval_types)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Authorized_Person(string text)
        {
            driver.FindElement(By.XPath(authorized_persons_dd)).Click();
            Thread.Sleep(2500);

            driver.FindElement(By.XPath(authorized_persons)).SendKeys(text);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(authorized_persons)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(authorized_persons)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Level(string text)
        {
            driver.FindElement(By.XPath(levels_dd)).Click();
            Thread.Sleep(2500);

            driver.FindElement(By.XPath(levels)).SendKeys(text);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(levels)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(levels)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Submit()
        {
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(3500);
        }

        public bool ApprovalTypeValidation()
        {
            bool Error;

            try
            {
                string expected_error = "Please provide Approval Type";
                string actual_error = driver.FindElement(By.CssSelector(at_validation)).GetAttribute("innerHTML");
                Assert.AreEqual(expected_error, actual_error);

                Error = true;
                return Error;
            }
            catch (AssertionException exc)
            {
                Console.WriteLine(exc.Message);
                Error = false;
                return Error;
            }
        }

        public bool Authorized_Person_Validation()
        {
            bool Error;

            try
            {
                string expected_error = "Please provide Authorized Person";
                string actual_error = driver.FindElement(By.CssSelector(ap_validation)).GetAttribute("innerHTML");
                Assert.AreEqual(expected_error, actual_error);

                Error = true;
                return Error;
            }
            catch (AssertionException exc)
            {
                Console.WriteLine(exc.Message);
                Error = false;
                return Error;
            }
        }

        public bool Level_Validation()
        {
            bool Error;

            try
            {
                string expected_error = "Please provide Level";
                string actual_error = driver.FindElement(By.CssSelector(level_validation)).GetAttribute("innerHTML");
                Assert.AreEqual(expected_error, actual_error);

                Error = true;
                return Error;
            }
            catch (AssertionException exc)
            {
                Console.WriteLine(exc.Message);
                Error = false;
                return Error;
            }
        }

        public void LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval_types)));

            driver.FindElement(By.XPath(profile)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(500);
        }


        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
