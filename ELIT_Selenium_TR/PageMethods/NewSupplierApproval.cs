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
    class NewSupplierApproval
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string approval_type = "//span[text()='Supplier Registration']";
        string approval_search = "//input[@placeholder='Search']";

        string select = "//table/tbody/tr[1]";
        string Aaction = "//span[text()='Action']";
        string approval_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string comments = "//label[contains(text(),'Comments')]//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string reject = "//span[text()='Reject']";
        string profile_icon = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public NewSupplierApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string text)
        {
            driver.Navigate().GoToUrl(text);
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
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(1000);
        }

        public void Approval()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            driver.FindElement(By.XPath(approval + "//parent::div[text()='Approval']")).Click();
            Thread.Sleep(1000);
        }

        public void Approval_Notification()
        {
            driver.FindElement(By.XPath(approvalnotification)).Click();
            Thread.Sleep(3000);
        }

        public void Approval_Type()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval_type)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Approval_Search(string searchRequest)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));

            driver.FindElement(By.XPath(approval_search)).SendKeys(searchRequest);
            Thread.Sleep(800);
        }
       
        public void Select_Suppiier()
        {
            driver.FindElement(By.XPath(select)).Click();
            Thread.Sleep(2000);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Aaction)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void ApprovalAction()
        {
            driver.FindElement(By.XPath(approval_action)).Click();
            Thread.Sleep(1000);
        }

        public void Comments(string approveComemnts)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(approveComemnts);
            Thread.Sleep(1000);
        }

        public void Approve_Supplier()
        {
            driver.FindElement(By.XPath(approve)).Click();
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));
        }

        public void RejectAction()
        {
            driver.FindElement(By.XPath(reject_action)).Click();
        }

        public void Reject_Supplier()
        {
            driver.FindElement(By.XPath(reject)).Click();
            Thread.Sleep(3000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));
        }

        public void LogOut()
        {
            driver.FindElement(By.XPath(profile_icon)).Click();
            Thread.Sleep(800);
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
