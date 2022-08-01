using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ELIT_Selenium_TR.PageMethods.Demo_Admin
{
    class Adding_External_User
    {
        private IWebDriver driver;

        string username = "//input[@placeholder='Enter Username']";
        string password = "//input[@placeholder='Enter Password']";
        string signin = "//button[text()='Login Now']";
        string general = "/html/body/div[1]/div[2]/aside/ul/li[2]/div";
        string users = "/html/body/div[1]/div[2]/aside/ul/li[2]/ul/li[1]/label";

        string create_external_user = "/html/body/div[1]/div[3]/div[1]/div/div/ul/li[2]/button";
        string supplier_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[1]/div[1]/div/div/div/div/input";
        string contact_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[1]/div[2]/div/div/div/div/input";
        string title = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[1]/div/select";
        string first_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[2]/div/input";
        string middle_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[3]/div/input";
        string last_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[4]/div/input";
        string position = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[5]/div/input";
        string email_address = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[6]/div/input";
        string phone_number = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[7]/div/input";
        string alternate_phone_number = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[8]/div/input";
        string role_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[9]/div/div/div/div/input";
        string image = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[10]/div/button";
        string user_name = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[11]/div/input";

        string add = "/html/body/div[1]/div[3]/div[1]/div/div/div[1]/div[2]/div[2]/div[12]/button[1]";

        string title_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div.col-sm-3.mt8.englishText > div > span";
        string firstname_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(2) > div > span";
        string lastname_validations = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(4) > div > span";
        string position_validation = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(5) > div > span";
        string email_validations = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(6) > div > span";
        string phone_validations = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(7) > div > span";
        string role_validations = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(9) > div > span";
        string username_validations = "#root > div.al-main > div.al-content > div > div > div.panel.color_highlight_bg.color_highlight_text.with-scroll.animated.zoomIn > div.panel-body > div:nth-child(2) > div:nth-child(11) > div > span";

        string profile = "/html/body/div[1]/div[1]/div[2]/button";
        string logout = "/html/body/div[5]/div[3]/ul/li[3]";

        public Adding_External_User(IWebDriver driver)
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

        public void User()
        {
            driver.FindElement(By.XPath(users)).Click();
            Thread.Sleep(1500);
        }

        public void Create_ExternalUser()
        {
            driver.FindElement(By.XPath(create_external_user)).Click();
            Thread.Sleep(1000);
        }

        public void Supplier_Name(string text)
        {
            driver.FindElement(By.XPath(supplier_name)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Contact_Name(string text)
        {
            driver.FindElement(By.XPath(contact_name)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Title(string text)
        {
            driver.FindElement(By.XPath(title)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(title)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void First_Name(string text)
        {
            driver.FindElement(By.XPath(first_name)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Middle_Name(string text)
        {
            driver.FindElement(By.XPath(middle_name)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Last_Name(string text)
        {
            driver.FindElement(By.XPath(last_name)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Position(string text)
        {
            driver.FindElement(By.XPath(position)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Email_Address(string text)
        {
            driver.FindElement(By.XPath(email_address)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Phone_Number(string text)
        {
            driver.FindElement(By.XPath(phone_number)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Alternate_Number(string text)
        {
            driver.FindElement(By.XPath(alternate_phone_number)).SendKeys(text);
            Thread.Sleep(800);
        }

        public void Role_Name(string text)
        {
            driver.FindElement(By.XPath(role_name)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(role_name)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(role_name)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(role_name)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

        }

        public void Image()
        {
            driver.FindElement(By.XPath(image)).Click();
            Thread.Sleep(1000);
            SendKeys.SendWait("C:\\Users\\csrik\\Desktop\\ELIT_Validations.txt");
            Thread.Sleep(1500);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(500);
        }

        public void User_UserName(string text)
        {
            driver.FindElement(By.XPath(user_name)).SendKeys(text);
            Thread.Sleep(800);
            
        }

        public void Add()
        {
            driver.FindElement(By.XPath(add)).Click();
            Thread.Sleep(800);
        }

        public bool TitleValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please select Title ";
                string actual_error = driver.FindElement(By.CssSelector(title_validation)).GetAttribute("innerHTML");
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

        public bool FirstNameValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide First Name ";
                string actual_error = driver.FindElement(By.CssSelector(firstname_validation)).GetAttribute("innerHTML");
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

        public bool LastNameValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Last Name ";
                string actual_error = driver.FindElement(By.CssSelector(lastname_validations)).GetAttribute("innerHTML");
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

        public bool PositionValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Position ";
                string actual_error = driver.FindElement(By.CssSelector(position_validation)).GetAttribute("innerHTML");
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

        public bool EmailAddressValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Email Address ";
                string actual_error = driver.FindElement(By.CssSelector(email_validations)).GetAttribute("innerHTML");
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

        public bool PhoneNumberValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Phone Number ";
                string actual_error = driver.FindElement(By.CssSelector(phone_validations)).GetAttribute("innerHTML");
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

        public bool RoleNameValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Role Name ";
                string actual_error = driver.FindElement(By.CssSelector(role_validations)).GetAttribute("innerHTML");
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

        public bool UserNameValidation()
        {
            bool Error;

            try
            {
                string expected_error = " Please provide Username ";
                string actual_error = driver.FindElement(By.CssSelector(username_validations)).GetAttribute("innerHTML");
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
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(title)));

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
