using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.PageMethods
{
    class SupplierPasswordCreation
    {
        private IWebDriver driver;

        string password = "(//input[@type='password'])[1]";
        string reenter_password = "(//input[@type='password'])[2]";
        string create_password = "//span[text()='Set New Password']";
        string profile_icon = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public SupplierPasswordCreation(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string text)
        {
            driver.Navigate().GoToUrl(text);
            Thread.Sleep(2500);
            driver.Navigate().Refresh();

        }

        public void Password(string PASSWORD)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(password)));
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(password)).SendKeys(PASSWORD);
            Thread.Sleep(2000);
        }

        public void Reenter_Password(string rePassword)
        {
            driver.FindElement(By.XPath(reenter_password)).SendKeys(rePassword);
            Thread.Sleep(1000);
        }

        public void Submit_Password()
        {
            driver.FindElement(By.XPath(create_password)).Click();
            Thread.Sleep(3000);
        }

        public void Profile()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(profile_icon)));
            Thread.Sleep(2200);
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Logout()
        {
            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(1000);
        }

        public void ErrorValidation()
        {

            string validation_error = "//span[@class='field-validation-error-text '] | //span[@class='field-validation-error-text'] | //div[contains(@class,'Toastify__toast--error')]";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var ve = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(validation_error)));
            Actions action = new Actions(driver);
            action.MoveToElement(ve).Perform();

            bool isvalidationPresent = ve.Displayed;
            if (isvalidationPresent)
            {
                string error = driver.FindElement(By.XPath(validation_error)).GetAttribute("innerHTML");
                throw new InvalidOperationException(error);
            }
        }

        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
