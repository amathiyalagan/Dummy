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
    class BankAccountApproval
    {
        private IWebDriver driver;
        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string profile = "//label/span[text()='Profile']";

        string bank_details = "//div[text()='Bank Details']";
        string bd_country = "(//label[text()='Country*']//parent::div/div/div/div/div/input)";
        string bd_bankname = "(//label[text()='Bank Name*']//parent::div/div/div/div/div/input)";
        string bd_branchname = "(//label[text()='Branch Name*']//parent::div/div/div/div/div/input)";
        string bd_typevalues = "(//label[text()='Type Values*']//parent::div/div/input)";
        string bd_rfcidentifier = "(//label[text()='RFC Identifier']//parent::div/div/input)";
        string bd_alternateaccnumber = "(//label[text()='Account Alternate Name']//parent::div/div/input)";
        string bd_shortname = "(//label[text()='Short Name']//parent::div/div/input)";
        string bd_accountnumber = "(//label[text()='Account Number*']//parent::div/div/input)";
        string bd_iban = "(//label[text()='IBAN Number']//parent::div/div/input)";
        string bd_currency = "(//label[text()='Currency*']//parent::div/div/div/div/div/input)";
        string bd_checknumber = "(//label[text()='Check Digits']//parent::div/div/input)";
        string bd_account_suffix = "(//label[text()='Account Suffix']//parent::div/div/input)";
        string bd_accnotype = "(//label[text()='Account Type*']//parent::div/div/div/div/div/input)";
        string bd_description = "(//label[text()='Description*']//parent::div/div/textarea)";
        string bd_startdate = "(//label[text()='Start Date']//parent::div/div/label/div/div/input)";
        string bd_enddate = "(//label[text()='End Date']//parent::div/div/label/div/div/input)";
        string bd_contactname = "(//label[text()='Contact Name']//parent::div/div/input)";
        string bd_phonenumber = "(//label[text()='Phone Number']//parent::div/div/div/input)";
        string bd_faxnumber = "(//label[text()='Fax Number']//parent::div/div/input)";
        string bd_emailaddress = "(//label[text()='Email Address']//parent::div/div/input)";
        string bd_add = "(//span[text()='Add'])[2]";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string bank_account = "//span[text()='Bank Account Approval']";
        string bank_account_search = "//input[@placeholder='Search']";
        string select_bank_account = "//table/tbody/tr[1]";
        string action = "//span[text()='Action']";
        string approve_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string comments = "//label[text()='Comments*']//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string reject = "//span[text()='Reject']";

        string profile_click = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public BankAccountApproval(IWebDriver driver)
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

        public void Supplier()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
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

        public void Bank_Details()
        {

            driver.FindElement(By.XPath(bank_details)).Click();
            Thread.Sleep(800);
        }

        public void BD_Country(string bdCountry)
        {
            driver.FindElement(By.XPath(bd_country)).Click();
            Thread.Sleep(800); 
            driver.FindElement(By.XPath(bd_country)).SendKeys(bdCountry);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(bd_country)).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_country)).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_country)).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        public void BD_BankName(string bdBankName)
        {
            driver.FindElement(By.XPath(bd_bankname)).Click();
            Thread.Sleep(800);
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(bdBankName);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void BD_BranchName(string bdBranchName)
        {
            driver.FindElement(By.XPath(bd_branchname)).Click();
            Thread.Sleep(800);
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(bdBranchName);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void BD_TypeValues(string bdTypeValues)
        {
            driver.FindElement(By.XPath(bd_typevalues)).SendKeys(bdTypeValues);
            Thread.Sleep(500);
        }

        public void BD_RFCIdentifier(string bdRFCIdentifier)
        {
            driver.FindElement(By.XPath(bd_rfcidentifier)).SendKeys(bdRFCIdentifier);
            Thread.Sleep(500);
        }

        public void BD_AccountAlternateName(string BbdAccountAlternateName)
        {
            driver.FindElement(By.XPath(bd_alternateaccnumber)).SendKeys(BbdAccountAlternateName);
            Thread.Sleep(500);
        }

        public void BD_ShortName(string bdShortName)
        {
            driver.FindElement(By.XPath(bd_shortname)).SendKeys(bdShortName);
            Thread.Sleep(500);
        }

        public void BD_ACCNO(string bdAccno)
        {
            driver.FindElement(By.XPath(bd_accountnumber)).SendKeys(bdAccno);
            Thread.Sleep(500);
        }

        public void BD_Iban(string bdIban)
        {
            driver.FindElement(By.XPath(bd_iban)).Click();
            driver.FindElement(By.XPath(bd_iban)).SendKeys(bdIban);
            Thread.Sleep(500);
        }

        public void BD_Currency(string bdCurrency)
        {
            driver.FindElement(By.XPath(bd_currency)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_currency)).SendKeys(bdCurrency);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_currency)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_currency)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void BD_CheckDigit(string bdCheckDigit)
        {
            driver.FindElement(By.XPath(bd_checknumber)).SendKeys(bdCheckDigit);
            Thread.Sleep(500);
        }

        public void BD_AccountSuffix(string bdAccountSuffix)
        {
            driver.FindElement(By.XPath(bd_account_suffix)).SendKeys(bdAccountSuffix);
            Thread.Sleep(500);
        }

        public void BD_AccountType(string bdAccountType)
        {
            driver.FindElement(By.XPath(bd_accnotype)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(bdAccountType);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void BD_Description(string bdDescription)
        {
            driver.FindElement(By.XPath(bd_description)).SendKeys(bdDescription);
            Thread.Sleep(500);
        }

        public void BD_Startdate(string bdStartdate)
        {
            driver.FindElement(By.XPath(bd_startdate)).SendKeys(bdStartdate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_startdate)).SendKeys(Keys.Enter);
        }

        public void BD_EndDate(string bdEnddate)
        {
            driver.FindElement(By.XPath(bd_enddate)).SendKeys(bdEnddate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_enddate)).SendKeys(Keys.Enter);
        }

        public void BD_Contactname(string bdContactname)
        {
            driver.FindElement(By.XPath(bd_contactname)).SendKeys(bdContactname);
            Thread.Sleep(500);
        }

        public void BD_Phonenumber(string bdPhonenumber)
        {
            driver.FindElement(By.XPath(bd_phonenumber)).SendKeys(bdPhonenumber);
            Thread.Sleep(500);
        }

        public void BD_FaxNumber(string bdFaxnumber)
        {
            driver.FindElement(By.XPath(bd_faxnumber)).SendKeys(bdFaxnumber);
            Thread.Sleep(500);
        }

        public void BD_Emailaddress(string bdEmailaddress)
        {
            driver.FindElement(By.XPath(bd_emailaddress)).SendKeys(bdEmailaddress);
            Thread.Sleep(500);
        }

        public void BD_Add()
        {
            driver.FindElement(By.XPath(bd_add)).Click();
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

        public void Navigate_Bank_Account()
        {
            driver.FindElement(By.XPath(bank_account)).Click();
            Thread.Sleep(1000);
        }

        public void Bank_Account_Search(string documentSearch)
        {
            driver.FindElement(By.XPath(bank_account_search)).SendKeys(documentSearch);
            Thread.Sleep(800);
        }

        public void Select_Bank_Account()
        {
            driver.FindElement(By.XPath(select_bank_account)).Click();
            Thread.Sleep(1000);
        }

        public void Action()
        {
            driver.FindElement(By.XPath(action)).Click();
            Thread.Sleep(500);
        }

        public void Approve()
        {
            driver.FindElement(By.XPath(approve_action)).Click();
            Thread.Sleep(500);
        }

        public void Comments(string text)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(text);
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
            driver.FindElement(By.XPath(profile_click)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(1500);
        }
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
