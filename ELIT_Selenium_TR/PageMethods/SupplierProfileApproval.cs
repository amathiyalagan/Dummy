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
    class SupplierProfileApproval
    {
        private IWebDriver driver;
        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string supplier_profile = "//span[text()='Supplier Profile']";
        string approval_search = "//input[@placeholder='Search']";

        string select = "//table/tbody/tr[1]";
        string supplier_type = "/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div[1]/div/div[9]/div/div/div/div/input";
        string supplier_type_select = "*//li[text()='Supplier']";
        string Aaction = "//span[text()='Action']";
        string approve_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string comments = "//label[contains(text(),'Comments')]//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string reject = "//span[text()='Reject']";
        string profile_click = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public SupplierProfileApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            Thread.Sleep(500);
        }

        public void UserName(String userName)
        {
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
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(1000);
        }

        public void Approval()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(approval + "//parent::div[text()='Approval']")).Click();
            Thread.Sleep(1000);
        }

        public void Approval_Notification()
        {
            driver.FindElement(By.XPath(approvalnotification)).Click();
            Thread.Sleep(3000);
        }

        public void Supplier_Profile()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier_profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2000);
        }

        public void Approval_Search(string approvalSearch)
        {
            driver.FindElement(By.XPath(approval_search)).SendKeys(approvalSearch);
            Thread.Sleep(800);
        }

        public void Select_Profile()
        {
            driver.FindElement(By.XPath(select)).Click();
            Thread.Sleep(2500);
        }

        public void Reject_SupplierProfile()
        {
           // driver.FindElement(By.XPath(reject_supplier_profile)).Click();
        }

        public void Supplier_Type()
        {
            driver.FindElement(By.XPath(supplier_type)).SendKeys("Supp");
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier_type_select)).Click();
            Thread.Sleep(800);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Aaction)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Approve()
        {
            driver.FindElement(By.XPath(approve_action)).Click();
            Thread.Sleep(500);
        }

        public void Comments(string approveComemnts)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(approveComemnts);
            Thread.Sleep(500);
        }

        public void Approved()
        {
            driver.FindElement(By.XPath(approve)).Click();
            Thread.Sleep(2000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));
        }

        public void Reject()
        {
            driver.FindElement(By.XPath(reject_action)).Click();
            Thread.Sleep(500);
        }

        public void Rejected()
        {
            driver.FindElement(By.XPath(reject)).Click();
            Thread.Sleep(2000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select)));
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

        public void LogOut()
        {
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(profile_click)).Click();
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
