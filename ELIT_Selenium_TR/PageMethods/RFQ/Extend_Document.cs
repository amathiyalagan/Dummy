using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.PageMethods.RFQ
{
    public class Extend_Document
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string sourcing = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-cubes')]";
        string quotation = "//span[text()='Quotation']";

        string active_doc = "//div[text()='Active']";
        string doc_search = "//input[@placeholder='Search']";
        string document = "//table/tbody/tr[1]/td/span";
        string doc_action = "//span[text()='Action']";
        string req_extend = "//button[text()='Request for Extend Document']";

        string doc_Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string doc_logout = "//span[text()='Logout']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string doc_extension = "//button[contains(.,'Document Extension')]";
        string approval_doc_search = "//input[@placeholder='Search']";
        string approval_accept_closedoc = "//table/tbody/tr[1]";
        string approval_action = "//span[text()='Action']";
        string approval_action_select = "//div[contains(@class,'MuiPaper-root MuiMenu-paper')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string reject_action_select = "//div[contains(@class,'MuiPaper-root MuiMenu-paper')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string approval_comments = "//label[text()='Comments']//parent::div/div/textarea";
        string approval_approve = "//span[text()='Approve']";
        string approval_reject = "//span[text()='Reject']";

        string approver_Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string approver_logout = "//span[text()='Logout']";

        string extend = "//button[text()='Extend Document']";
        string close_date = "//label[text()='Close Date']//parent::div/div/div/div/input";
        string extend_document = "//span[text()='Extend Document']";


        public Extend_Document(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
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

        public void Sourcing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(sourcing)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);


            driver.FindElement(By.XPath(sourcing + "//parent::div[text()='Sourcing']")).Click();
            Thread.Sleep(1500);
        }

        public void Quotation()
        {
            driver.FindElement(By.XPath(quotation)).Click();
            Thread.Sleep(1500);
        }

        public void Active_Document()
        {

            driver.FindElement(By.XPath(active_doc)).Click();
            Thread.Sleep(3500);
        }

        public void Active_Doc_Search(string activeRfqSearch)
        {
            driver.FindElement(By.XPath(doc_search)).SendKeys(activeRfqSearch);
            Thread.Sleep(800);
        }

        public void Document()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(document)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3500);
        }

        public void Doc_Action()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_action)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);
        }

        public void Doc_Extend_Req()
        {
            driver.FindElement(By.XPath(req_extend)).Click();
            Thread.Sleep(2500);
        }

        public void Buyer_Profile()
        {
            Thread.Sleep(1500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);
        }

        public void Buyer_LogOut()
        {
            driver.FindElement(By.XPath(doc_logout)).Click();
            Thread.Sleep(500);
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
            Thread.Sleep(1500);
        }

        public void Document_Extension()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_extension)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);
        }

        public void Doc_Extension_Search(string documentSearch)
        {
            driver.FindElement(By.XPath(approval_doc_search)).SendKeys(documentSearch);
            Thread.Sleep(1000);
        }

        public void Document_Extend()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval_accept_closedoc)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }

        public void Approval_Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval_action)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Approval_Action_Select()
        {
            driver.FindElement(By.XPath(approval_action_select)).Click();
            Thread.Sleep(500);
        }

        public void Reject_Action_Select()
        {
            driver.FindElement(By.XPath(reject_action_select)).Click();
            Thread.Sleep(800);
        }

        public void Approval_Comments(string approveComemnts)
        {
            driver.FindElement(By.XPath(approval_comments)).SendKeys(approveComemnts);
            Thread.Sleep(500);
        }

        public void Approver_Action()
        {
            driver.FindElement(By.XPath(approval_approve)).Click();
            Thread.Sleep(4500);
        }

        public void Approver_Action_Reject()
        {
            driver.FindElement(By.XPath(approval_reject)).Click();
            Thread.Sleep(2500);
        }

        public void Reject_Comments(string text)
        {
            driver.FindElement(By.XPath(approval_comments)).SendKeys(text);
            Thread.Sleep(500);
        }

        public void Approver_Profile()
        {
            Thread.Sleep(1500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approver_Profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(800);
        }

        public void Approver_LogOut()
        {
            driver.FindElement(By.XPath(approver_logout)).Click();
            Thread.Sleep(500);
        }

        public void Doc_Extend()
        {
            driver.FindElement(By.XPath(extend)).Click();
            Thread.Sleep(800);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(close_date)));
        }

        public void Doc_Extend_CloseDate(string closeDate)
        {
            driver.FindElement(By.XPath(close_date)).SendKeys(Keys.Control + "a");
            driver.FindElement(By.XPath(close_date)).SendKeys(Keys.Clear);

            Thread.Sleep(1800);

            driver.FindElement(By.XPath(close_date)).SendKeys(closeDate);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(close_date)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);
        }

        public void Extend_Documents()
        {
            driver.FindElement(By.XPath(extend_document)).Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));
            Thread.Sleep(2800);
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
