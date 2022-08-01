using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ELIT_Selenium_TR.PageMethods.Raise_Invoice
{
    public class RaiseInvoiceApproval
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";
        string invoice_approval = "//button[contains(.,'Invoice Approval')]";

        string search = "//input[@placeholder='Search']";
        string select = "//table/tbody/tr[1]";
        string action = "//span[text()='Action']";
        string action_approve = "//button[text()='Approve']";
        string action_reject = "//button[text()='Reject']";
        string comments = "//label[text()='Comments']//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject = "//span[text()='Reject')]";

        string profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public RaiseInvoiceApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void UserName(String userName)
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(username)).SendKeys(userName);
            Thread.Sleep(500);
        }

        public void Password(string PASSWORD)
        {
            driver.FindElement(By.XPath(password)).SendKeys(PASSWORD);
            Thread.Sleep(500);
        }

        public void SignIn()
        {
            driver.FindElement(By.XPath(login)).Click();
            Thread.Sleep(1000);
        }

        public void Approval()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(approval + "//parent::div[text()='Approval']")).Click();
            Thread.Sleep(1500);
        }

        public void Approval_notification()
        {
            driver.FindElement(By.XPath(approvalnotification)).Click();
            Thread.Sleep(800);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(search)));
        }

        public void Invoice_Approval()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(invoice_approval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Search(string documentSearch)
        {
            driver.FindElement(By.XPath(search)).SendKeys(documentSearch);
            Thread.Sleep(800);
        }

        public void Select()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));

            driver.FindElement(By.XPath(select)).Click();
            Thread.Sleep(1500);
        }

        public void Action()
        {
            driver.FindElement(By.XPath(action)).Click();
            Thread.Sleep(500);
        }

        public void Action_Approve()
        {
            driver.FindElement(By.XPath(action_approve)).Click();
            Thread.Sleep(500);
        }

        public void Approve()
        {
            driver.FindElement(By.XPath(approve)).Click();
            Thread.Sleep(1500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Shipment Date*']")));
        }

        public void Action_Reject()
        {
            driver.FindElement(By.XPath(action_reject)).Click();
            Thread.Sleep(500);
        }

        public void Reject()
        {
            driver.FindElement(By.XPath(reject)).Click();
            Thread.Sleep(1500);
        }

        public void Comments(string aComments)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(aComments);
            Thread.Sleep(800);
        }

        public void LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(500);
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
