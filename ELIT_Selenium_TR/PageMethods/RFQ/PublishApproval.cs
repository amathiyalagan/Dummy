using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.PageMethods.RFQ.Simple
{
    public class PublishApproval
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string documnet_publish = "//span[text()='Document Publish']";
        string document_search = "//input[@placeholder='Search']";
        string select_rfq = "//table/tbody/tr[1]";
        string Aaction = "//span[text()='Action']";
        string approve = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string reject = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')]";
        string comments = "//label[contains(text(),'Comments')]//parent::div/div/textarea";
        string Publish_approval = "//span[text()='Approve']";
        string Publish_rejection = "//span[text()='Reject']";
        string Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public PublishApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url                                                                       );
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

        public void Approval_Notifications()
        {
            driver.FindElement(By.XPath(approvalnotification)).Click();
            Thread.Sleep(1500);
        }

        public void Document_Publish()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(documnet_publish)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);

        }

        public void Document_search(string documentSearch)
        {
            driver.FindElement(By.XPath(document_search)).SendKeys(documentSearch);
            Thread.Sleep(1000);
        }

        public void Select_RFQ()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(select_rfq)));
            element.Click();
            Thread.Sleep(2500);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Aaction)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }

        public void Accept_RFQ()
        {
            driver.FindElement(By.XPath(approve)).Click();
            Thread.Sleep(800);
        }

        public void Reject_RFQ()
        {
            driver.FindElement(By.XPath(reject)).Click();
            Thread.Sleep(500);
        }

        public void Comments(string approveComments)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(approveComments);
            Thread.Sleep(800);
        }

        public void Publish_Approval()
        {
            driver.FindElement(By.XPath(Publish_approval)).Click();
            Thread.Sleep(3500);
        }

        public void Publish_Rejection()
        {
            driver.FindElement(By.XPath(Publish_rejection)).Click();
            Thread.Sleep(3500);
        }

        public void LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Profile)));
            element.Click();
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
