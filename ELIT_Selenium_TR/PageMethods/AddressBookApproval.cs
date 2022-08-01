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
    class AddressBookApproval
    {
        private IWebDriver driver;
        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string profile = "//label/span[text()='Profile']";

        string addressbook = "//div[text()='Address Book']";
        string addressbook_name = "//label[text()='Name*']//parent::div/div/input";
        string address_alternatename = "(//label[text()='Alternate Name']//parent::div/div/input)[2]";
        string address_country = "(//label[text()='Country*']//parent::div/div/div/div/div/input)[1]";
        string address_addressline1 = "(//label[text()='Address Line 1*']//parent::div/div/input)";
        string address_addressline2 = "(//label[text()='Address Line 2']//parent::div/div/input)";
        string address_addressline3 = "(//label[text()='Address Line 3']//parent::div/div/input)";
        string address_addressline4 = "(//label[text()='Address Line 4']//parent::div/div/input)";
        string address_city = "(//label[text()='City*']//parent::div/div/input)";
        string address_state = "(//label[text()='State*']//parent::div/div/div/div/div/input)";
        string address_pobox = "(//label[text()='P.O. Box*']//parent::div/div/input)";
        string address_email = "(//label[text()='Email Address*']//parent::div/div/input)";
        string address_phonenumber = "(//label[text()='Phone Number*']//parent::div/div/div/input)";
        string address_alternatenumber = "(//label[text()='Alternative Number']//parent::div/div/div/input)";
        string address_ordering = "(//span[text()='Ordering'])";
        string address_add = "(//span[text()='Add'])[1]";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        string address_book = "//span[text()='Address Book Approval']";
        string address_book_search = "//input[@placeholder='Search']";
        string select_address_book = "//table/tbody/tr[1]";
        string action = "//span[text()='Action']";
        string approve_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string comments = "//label[text()='Comments*']//parent::div/div/textarea";
        string approve = "//span[text()='Approve']";
        string reject_action = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string reject = "//span[text()='Reject']";
        string profile_click = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public AddressBookApproval(IWebDriver driver)
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

        public void AddressBook()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(addressbook)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            driver.FindElement(By.XPath(addressbook)).Click();
            Thread.Sleep(800);
        }

        public void AddressBook_Name(string addressBookName)
        {
            driver.FindElement(By.XPath(addressbook_name)).SendKeys(addressBookName);
            Thread.Sleep(800);
        }

        public void AddressBook_AlternateName(string addressBookAlternateName)
        {
            driver.FindElement(By.XPath(address_alternatename)).SendKeys(addressBookAlternateName);
            Thread.Sleep(800);
        }

        public void AddressBook_Country(string text)
        {
            driver.FindElement(By.XPath(address_country)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(address_country)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(address_country)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(address_country)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(address_country)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void AddressBook_CountryM(string addressBookCountryM)
        {
            driver.FindElement(By.XPath(address_country)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(address_country)).SendKeys(addressBookCountryM);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(address_country)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);

            driver.FindElement(By.XPath(address_country)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void AddressBook_AddressLine1(string addressBookAddressLine1)
        {
            driver.FindElement(By.XPath(address_addressline1)).SendKeys(addressBookAddressLine1);
            Thread.Sleep(800);
        }

        public void AddressBook_AddressLine2(string addressBookAddressLine2)
        {
            driver.FindElement(By.XPath(address_addressline2)).SendKeys(addressBookAddressLine2);
            Thread.Sleep(800);
        }

        public void AddressBook_AddressLine3(string addressBookAddressLine3)
        {
            driver.FindElement(By.XPath(address_addressline3)).SendKeys(addressBookAddressLine3);
            Thread.Sleep(500);
        }

        public void AddressBook_AddressLine4(string addressBookAddressLine4)
        {
            driver.FindElement(By.XPath(address_addressline4)).SendKeys(addressBookAddressLine4);
            Thread.Sleep(500);
        }

        public void AddressBook_City(string addressBookCity)
        {
            driver.FindElement(By.XPath(address_city)).SendKeys(addressBookCity);
            Thread.Sleep(500);
        }

        public void AddressBook_StateM(string addressBookStateM)
        {
            driver.FindElement(By.XPath(address_state)).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(address_state)).SendKeys(addressBookStateM);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(address_state)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);

            driver.FindElement(By.XPath(address_state)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void AddressBook_POBox(string addressBookPOBox)
        {
            driver.FindElement(By.XPath(address_pobox)).SendKeys(addressBookPOBox);
            Thread.Sleep(800);
        }

        public void AddressBook_Email(string addressBookEmail)
        {
            driver.FindElement(By.XPath(address_email)).SendKeys(addressBookEmail);
            Thread.Sleep(800);
        }

        public void AddressBook_Phone(string addressBookPhone)
        {
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(address_phonenumber)).SendKeys(addressBookPhone);
            Thread.Sleep(800);
        }

        public void AddressBook_AlternativePhonenumber(string AddressBook_Alternativenumber)
        {
            driver.FindElement(By.XPath(address_alternatenumber)).SendKeys(AddressBook_Alternativenumber);
            Thread.Sleep(800);
        }

        public void AddressBook_Ordering()
        {
            driver.FindElement(By.XPath(address_ordering)).Click();
            Thread.Sleep(500);
        }

        public void AddressBook_Add()
        {
            driver.FindElement(By.XPath(address_add)).Click();
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

        public void Sidemenu()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("")));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
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
            Thread.Sleep(1500);
        }

        public void Navigate_Address_Book()
        {
            driver.FindElement(By.XPath(address_book)).Click();
            Thread.Sleep(1500);
        }

        public void Address_Book_Search(string documentSearch)
        {
            driver.FindElement(By.XPath(address_book_search)).SendKeys(documentSearch);
            Thread.Sleep(800);
        }

        public void Select_Address_Book()
        {
            driver.FindElement(By.XPath(select_address_book)).Click();
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
