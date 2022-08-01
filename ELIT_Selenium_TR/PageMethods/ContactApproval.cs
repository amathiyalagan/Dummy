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
    class ContactApproval
    {
        private IWebDriver driver;
        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string profile = "//label/span[text()='Profile']";
        string contact_information = "//div[text()='Contact Information']";
        string contact_information_wait = "/html/body/div[1]/div[3]/div[1]/div/div/div[4]/div[2]/div/div/div/div/div";
        string title = "//label[text()='Title*']//parent::div/div/select";
        string contact_firstname = "//label[text()='First Name*']//parent::div/div/input";
        string contact_middlename = "//label[text()='Middle Name']//parent::div/div/input";
        string contact_lastname = "//label[text()='Last Name*']//parent::div/div/input";
        string contact_email = "//label[text()='Email Address*']//parent::div/div/input";
        string contact_phonenumber = "//label[text()='Phone Number*']//parent::div/div/div/input";
        string contact_alternatenumber = "//label[text()='Alternative Number']//parent::div/div/div/input";
        string contact_faxnumber = "(//label[text()='Fax Number']//parent::div/div/input)[1]";
        string contact_position = "//label[text()='Position']//parent::div/div/div/div/div/input";
        string contact_authorized_signatory = "//span[text()='Authorized Signatory']";
        string contact_add = "(//span[text()='Add'])[1]";


        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";
        string conatct_approval = "//span[text()='Contact Approval']";
        string contact_approval_search = "//input[@placeholder='Search']";
        string select_contact = "//table/tbody/tr[1]";
        string action = "//span[text()='Action']";
        string approve_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string comments = "//label[text()='Comments*']//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string reject = "//span[text()='Reject']";
        string profile_click = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public ContactApproval(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1500);
        }

        public void UserName(string userName)
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
        public void Supplier()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(supplier + "//parent::div[text()='Supplier']")).Click();
            Thread.Sleep(1500);
        }

        public void SupplierProfile()
        {
            driver.FindElement(By.XPath(Supplierprofile)).Click();
            Thread.Sleep(500);
        }

        public void Profile()
        {
            driver.FindElement(By.XPath(profile)).Click();
            Thread.Sleep(2000);
        }

        public void Contact_Information()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(contact_information)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(contact_information)).Click();
            Thread.Sleep(500);

        }

        public void Contact_Wait()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(contact_information_wait)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void CI_Title(string ciTitle)
        {
            driver.FindElement(By.XPath(title)).Click();
            Thread.Sleep(500);
            new SelectElement(driver.FindElement(By.XPath(title))).SelectByText(ciTitle);
            Thread.Sleep(2500);
        }

        public void CI_First_Name(string ciFirstName)
        {
            driver.FindElement(By.XPath(contact_firstname)).SendKeys(ciFirstName);
            Thread.Sleep(800);
        }

        public void CI_Middle_Name(string ciMiddleName)
        {
            driver.FindElement(By.XPath(contact_middlename)).SendKeys(ciMiddleName);
            Thread.Sleep(800);
        }

        public void CI_last_Name(string ciLastName)
        {
            driver.FindElement(By.XPath(contact_lastname)).SendKeys(ciLastName);
            Thread.Sleep(800);
        }

        public void CI_Email_Address(string ciEmailAddress)
        {
            driver.FindElement(By.XPath(contact_email)).SendKeys(ciEmailAddress);
            Thread.Sleep(800);
        }

        public void CI_Phone_Number(string ciPhoneNumber)
        {
            driver.FindElement(By.XPath(contact_phonenumber)).SendKeys(ciPhoneNumber);
            Thread.Sleep(800);
        }

        public void CI_Alternative_Number(string ciAlternativeNumber)
        {
            driver.FindElement(By.XPath(contact_alternatenumber)).SendKeys(ciAlternativeNumber);
            Thread.Sleep(800);
        }

        public void CI_Fax_Number(string ciFaxNumber)
        {
            driver.FindElement(By.XPath(contact_faxnumber)).SendKeys(ciFaxNumber);
            Thread.Sleep(800);
        }

        public void CI_Position()
        {
            driver.FindElement(By.XPath(contact_position)).SendKeys("Sales");
            Thread.Sleep(500);

            driver.FindElement(By.XPath(contact_position)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(contact_position)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void CI_PositionM(string ciPositionM)
        {
            driver.FindElement(By.XPath(contact_position)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(contact_position)).SendKeys(ciPositionM);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(contact_position)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(contact_position)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

        }

        public void CI_Authorized_Signatory()
        {
            driver.FindElement(By.XPath(contact_authorized_signatory)).Click();
            Thread.Sleep(800);
        }

        public void CI_Add()
        {
            driver.FindElement(By.XPath(contact_add)).Click();
            Thread.Sleep(2500);
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


        public void Navigate_ContactApproval()
        {
            driver.FindElement(By.XPath(conatct_approval)).Click();
            Thread.Sleep(1000);
        }

        public void Contact_Search(string documentSearch)
        {
            driver.FindElement(By.XPath(contact_approval_search)).SendKeys(documentSearch);
            Thread.Sleep(800);
        }

        public void Select_Contact ()
        {
            driver.FindElement(By.XPath(select_contact)).Click();
            Thread.Sleep(1000);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions aAction = new Actions(driver);
            aAction.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Approve()
        {
            driver.FindElement(By.XPath(approve_action)).Click();
            Thread.Sleep(500);
        }

        public void Comments(string aComments)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(aComments);
            Thread.Sleep(500);
        }

        public void Approved()
        {
            driver.FindElement(By.XPath(approve)).Click();
            Thread.Sleep(2000);
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
        }

        public void LogOut()
        {
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(profile_click)));
            Actions aAction = new Actions(driver);
            aAction.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(500);
        }

        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
