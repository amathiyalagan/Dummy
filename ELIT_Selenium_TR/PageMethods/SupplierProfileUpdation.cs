using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ELIT_Selenium_TR.PageMethods
{
    class SupplierProfileUpdation
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";


        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string profile = "//label/span[text()='Profile']";

        string financial_details = "//div[text()='Financial Details']";
        string ceo_name = "//label[text()='CEO Name']//parent::div/div/input";
        string control_year = "//label[text()='Control Year*']//parent::div/div/label/div/div/input";
        string ceo_title = "//label[text()='CEO Title']//parent::div/div/input";
        string total_employees = "//label[text()='Total Employees*']//parent::div/div/input";
        string line_of_business = "//label[text()='Line Of Business*']//parent::div/div/input";
        string financial_analysis_year = "//label[text()='Financial Analysis Year*']//parent::div/div/label/div/div/input";
       string fiscal_year_end = "//label[text()='Fiscal Year End*']//parent::div/div/label/div/div/input";
        string current_year_revenue = "//label[text()='Current Year Revenue*']//parent::div/div/input";
        string potential_revenue = "//label[text()='Potential Revenue*']//parent::div/div/input";
        string mission_statement = "//label[text()='Mission Statement']//parent::div/div/textarea";
        string fd_Save = "//span[text()='Save']";


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

        string products_services = "(//div[text()='Products & Services'])";
        string ps_reposition = "(//div[text()='Bank Details'])";
        string ps_categoryname = "(//label[text()='Category Name']//parent::div/div/div/div/div/input)";
        string ps_subcategoryname = "(//label[text()='Sub Category Name']//parent::div/div/div/div/div/input)";
        string ps_add = "(//span[text()='Add'])[1]";

        string Certificates = "//div[text()='Certificates']";

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

        string questionnaries = "(//div[text()='Questionnaires'])";
        string questionnaries_reposition = "(//div[text()='References'])";
        string questionnaries_q1option = "(//table)/tbody/tr[1]/td[2]/div/div/select";
        string questionnaries_q2option = "(//table)/tbody/tr[2]/td[2]/div/div/select";

        string references = "(//div[text()='References'])";
        string reference_companyname = "(//label[text()='Company Name*']//parent::div/div/input)";
        string reference_country = "(//label[text()='Country*']//parent::div/div/div/div/div/input)[2]";
        string reference_contactname = "(//label[text()='Contact Name*']//parent::div/div/input)";
        string reference_emailaddress = "(//label[text()='Email Address*']//parent::div/div/input)";
        string reference_phonenumber = "(//label[text()='Phone Number*']//parent::div/div/div/input)";
        string reference_altnumber = "(//label[text()='Alternative Number']//parent::div/div/div/input)";
        string reference_position = "(//label[text()='Position']//parent::div/div/div/div/div/input)";
        string reference_add = "(//span[text()='Add'])[3]";

        string attachments = "(//button[text()='Attachments'])";
        string attachments_addattachment = "(//span[text()='Add Attachment'])";
        string attachment_title = "(//label[text()='Title*']//parent::div/div/input)";
        string attachment_documenttype = "(//label[text()='Document Type*']//parent::div/div/select)";
        string attachment_filebrowse = "//span[text()='Browse']";
        string attachment_doccategory = "(//label[text()='Document Category*']//parent::div/div/select)";
        string attachment_description = "(//label[text()='Description*']//parent::div/div/textarea)";
        string attachment_atcsubmit = "(//span[text()='Submit'])";

        string profile_click = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public SupplierProfileUpdation(IWebDriver driver)
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

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Company Name']")));
        }

        //Financial Details

        public void Financial_Details()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(financial_details)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(800);

        }

        public void FD_CEO_Name(string ceoName)
        {
            driver.FindElement(By.XPath(ceo_name)).Click();

            driver.FindElement(By.XPath(ceo_name)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ceo_name)).SendKeys(ceoName);
            Thread.Sleep(1000);
        }

        public void FD_Control_YearM(string controlYear)
        {
            driver.FindElement(By.XPath(control_year)).Click();

            driver.FindElement(By.XPath(control_year)).SendKeys(Keys.Control + "a" + Keys.Control);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(control_year)).SendKeys(controlYear);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(control_year)).SendKeys(OpenQA.Selenium.Keys.Enter);

        }

        public void FD_Ceo_Title(String ceoTitle)
        {
            driver.FindElement(By.XPath(ceo_title)).Click();

            driver.FindElement(By.XPath(ceo_title)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ceo_title)).SendKeys(ceoTitle);
            Thread.Sleep(800);
        }

        public void FD_Total_Employee(string totalEmployees)
        {
            driver.FindElement(By.XPath(total_employees)).Click();

            driver.FindElement(By.XPath(total_employees)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(total_employees)).SendKeys(totalEmployees);
            Thread.Sleep(1000);
        }

        public void FD_Line_of_Business(string lineOfBusiness)
        {
            driver.FindElement(By.XPath(line_of_business)).Click();

            driver.FindElement(By.XPath(line_of_business)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(line_of_business)).SendKeys(lineOfBusiness);
            Thread.Sleep(800);
        }

        public void FD_Financial_Analysis_YearM(string financialAnalysisYear)
        {
            driver.FindElement(By.XPath(financial_analysis_year)).Click();

            driver.FindElement(By.XPath(financial_analysis_year)).SendKeys(Keys.Control + "a" + Keys.Control);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(financial_analysis_year)).SendKeys(financialAnalysisYear);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(financial_analysis_year)).SendKeys(OpenQA.Selenium.Keys.Enter);

        }

        public void FD_Fiscal_Year_EndM(string fiscalYearEnd)
        {
            driver.FindElement(By.XPath(fiscal_year_end)).Click();

            driver.FindElement(By.XPath(fiscal_year_end)).SendKeys(Keys.Control + "a" + Keys.Control);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(fiscal_year_end)).SendKeys(fiscalYearEnd);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(fiscal_year_end)).SendKeys(OpenQA.Selenium.Keys.Enter);

        }

        public void FD_Current_Year_Revenue(string currentYearRevenue)
        {
            driver.FindElement(By.XPath(current_year_revenue)).Click();

            driver.FindElement(By.XPath(current_year_revenue)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(current_year_revenue)).SendKeys(currentYearRevenue);
            Thread.Sleep(800);
        }

        public void FD_Potential_Revenue(string potentialRevenue)
        {
            driver.FindElement(By.XPath(potential_revenue)).Click();

            driver.FindElement(By.XPath(potential_revenue)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(potential_revenue)).SendKeys(potentialRevenue);
        }

        public void FD_Mission_Statement(string missionStatement)
        {
            driver.FindElement(By.XPath(mission_statement)).Click();

            driver.FindElement(By.XPath(mission_statement)).Clear();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(mission_statement)).SendKeys(missionStatement);
            Thread.Sleep(1000);
        }

        public void Financial_Details_Save()
        {
            driver.FindElement(By.XPath(fd_Save)).Click();
            Thread.Sleep(3500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(contact_information)));
        }

        //Contact Information

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

        //recall Contact_Information()

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

        public void AddressBook_CountryM(string addressBookCountryM)
        {
            driver.FindElement(By.XPath(address_country)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(address_country)).SendKeys(addressBookCountryM);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(address_country)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
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
            Thread.Sleep(500);

            //driver.FindElement(By.XPath(address_addressline3)).Click();
            //Thread.Sleep(500);

            driver.FindElement(By.XPath(address_state)).SendKeys(addressBookStateM);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(address_state)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

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

        //recall AddressBook()

        public void Products_Services()
        {
            driver.FindElement(By.XPath(products_services)).Click();
            Thread.Sleep(800);
        }

        public void PS_Reposition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(ps_reposition)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void PS_CategorynameM(string psCategoryName)
        {
            driver.FindElement(By.XPath(ps_categoryname)).SendKeys(psCategoryName);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ps_categoryname)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ps_categoryname)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void PS_SubcategorynameM(string psSubCategoryName)
        {
            driver.FindElement(By.XPath(ps_subcategoryname)).SendKeys(psSubCategoryName);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ps_subcategoryname)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ps_subcategoryname)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void PS_Add()
        {
            driver.FindElement(By.XPath(ps_add)).Click();
            Thread.Sleep(2500);
        }

        //Certificates

        public void Certificate()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Certificates)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            driver.FindElement(By.XPath(Certificates)).Click();
            Thread.Sleep(4500);
        }

        public void Add_Certificates(string name, string number, string agency, string EstYear, string IssueDate, string ExpiryDate)
        {
            IWebElement table = driver.FindElement(By.XPath("(//table)[2]/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Certificate Table is : " + RowCount);
            Console.WriteLine("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            IWebElement C_Add = driver.FindElement(By.XPath("(//span[text()='Add'])[2]"));
            C_Add.Click();
            Thread.Sleep(1500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            IWebElement C_Name = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input"));
            Actions action = new Actions(driver);
            action.MoveToElement(C_Name).Perform();
            C_Name.Click();
            Thread.Sleep(800);

            C_Name.SendKeys(name);
            Thread.Sleep(1500);
            C_Name.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            C_Name.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement C_CheckBox = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[2]/div/div/label/span"));
            C_CheckBox.Click();
            Thread.Sleep(500);

            IWebElement C_Number = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[3]/div/div/input"));
            C_Number.SendKeys(number);
            Thread.Sleep(800);

            IWebElement C_Agency = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[4]/div/div/input"));
            C_Agency.SendKeys(agency);
            Thread.Sleep(800);

            IWebElement C_EstYear = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/label/div/div/input"));
            C_EstYear.SendKeys(EstYear);
            Thread.Sleep(800);
            C_EstYear.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement C_IssueDate = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[6]/div/div/label/div/div/input"));
            C_IssueDate.SendKeys(IssueDate);
            Thread.Sleep(800);
            C_IssueDate.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement C_ExpiryDate = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[7]/div/div/label/div/div/input"));
            C_ExpiryDate.SendKeys(ExpiryDate);
            Thread.Sleep(800);
            C_ExpiryDate.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement div_to_scroll = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[9]//*[name()='svg'][contains(@class,'editIconTable')]"));
            driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", div_to_scroll);
            Thread.Sleep(500);

            IWebElement C_SubmitAction = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[9]//*[name()='svg'][contains(@class,'editIconTable')]"));
            C_SubmitAction.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[9]//*[name()='svg'][contains(@class,'editIconTable')]")));
            Thread.Sleep(3000);
        }
        //Bank Details

        public void Bank_Details()
        {

            driver.FindElement(By.XPath(bank_details)).Click();
            Thread.Sleep(800);
        }

        public void BD_Country(string bdCountry)
        {
            driver.FindElement(By.XPath(bd_country)).SendKeys(bdCountry);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_country)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_country)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            driver.FindElement(By.XPath(bd_country)).SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void BD_BankName(string bdBankName)
        {
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(bdBankName);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_bankname)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void BD_BranchName(string bdBranchName)
        {
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(bdBranchName);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_branchname)).SendKeys(OpenQA.Selenium.Keys.Enter);
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
            driver.FindElement(By.XPath(bd_currency)).SendKeys(bdCurrency);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_currency)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_currency)).SendKeys(OpenQA.Selenium.Keys.Enter);
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
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(bdAccountType);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_accnotype)).SendKeys(OpenQA.Selenium.Keys.Enter);
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
            driver.FindElement(By.XPath(bd_startdate)).SendKeys(OpenQA.Selenium.Keys.Enter);
        }

        public void BD_EndDate(string bdEnddate)
        {
            driver.FindElement(By.XPath(bd_enddate)).SendKeys(bdEnddate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(bd_enddate)).SendKeys(OpenQA.Selenium.Keys.Enter);
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

        public void BD_Reposition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(bank_details)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void Questionnnaires()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(questionnaries)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void Questionnaires_reposition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(questionnaries_reposition)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void Questionnaires_Question1(string text)
        {
            driver.FindElement(By.XPath(questionnaries_q1option)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(questionnaries_q1option)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(questionnaries_q1option)).SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        public void Questionnaires_Question2(string text)
        {
            driver.FindElement(By.XPath(questionnaries_q2option)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(questionnaries_q2option)).SendKeys(text);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(questionnaries_q2option)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void References()
        {
            driver.FindElement(By.XPath(references)).Click();
            Thread.Sleep(500);
        }

        public void Reference_Companyname(string refernceCompanyname)
        {
            driver.FindElement(By.XPath(reference_companyname)).SendKeys(refernceCompanyname);
            Thread.Sleep(500);
        }

        public void Reference_Country(string refernceCountry)
        {
            driver.FindElement(By.XPath(reference_country)).SendKeys(refernceCountry);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(reference_country)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(reference_country)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Reference_Contactname(string referenceContactname)
        {
            driver.FindElement(By.XPath(reference_contactname)).SendKeys(referenceContactname);
            Thread.Sleep(500);
        }

        public void Reference_Emailaddress(string referenceEmailaddress)
        {
            driver.FindElement(By.XPath(reference_emailaddress)).SendKeys(referenceEmailaddress);
            Thread.Sleep(500);
        }

        public void Reference_Phonenumber(string referencePhonenumber)
        {
            driver.FindElement(By.XPath(reference_phonenumber)).SendKeys(referencePhonenumber);
            Thread.Sleep(500);
        }

        public void Reference_Alternativenumber(string referenceAltnumber)
        {
            driver.FindElement(By.XPath(reference_altnumber)).SendKeys(referenceAltnumber);
        }

        public void Reference_Position(string referencePosition)
        {
            driver.FindElement(By.XPath(reference_position)).Click(); 
            Thread.Sleep(800);

            driver.FindElement(By.XPath(reference_position)).SendKeys(referencePosition);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(reference_position)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            driver.FindElement(By.XPath(reference_position)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1200);
        }

        public void Reference_Add()
        {
            driver.FindElement(By.XPath(reference_add)).Click();
            Thread.Sleep(2500);
        }


        public void Attachments()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(attachments)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Attachemnt_AddAttachment()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(attachments_addattachment)));

            driver.FindElement(By.XPath(attachments_addattachment)).Click();
            Thread.Sleep(500);
        }

        public void Attachment_AtcTitle(string attachmentTitle)
        {
            driver.FindElement(By.XPath(attachment_title)).SendKeys(attachmentTitle);
            Thread.Sleep(500);
        }

        public void Attachment_DocType(string attachmentDocumenttype)
        {
            driver.FindElement(By.XPath(attachment_documenttype)).SendKeys(attachmentDocumenttype);
            Thread.Sleep(500);

            new SelectElement(driver.FindElement(By.XPath(attachment_documenttype))).SelectByText(attachmentDocumenttype);
            Thread.Sleep(800);
        }

        public void Attachment_FileBrowseBD(string filePath)
        {
            driver.FindElement(By.XPath(attachment_filebrowse)).Click();
            Thread.Sleep(1000);
            SendKeys.SendWait(filePath);
            Thread.Sleep(1500);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(1500);
        }

        public void Attachment_FileBrowseTR()
        {
            driver.FindElement(By.XPath(attachment_filebrowse)).Click();
            Thread.Sleep(1000);
            SendKeys.SendWait("C:\\Users\\srchi\\OneDrive\\Desktop\\SupplierDetailsELIT.txt)");
            Thread.Sleep(1500);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(1500);

        }

        public void Attachment_DocCategoryBD(string attachmentDoccategory)
        {
            driver.FindElement(By.XPath(attachment_doccategory)).SendKeys(attachmentDoccategory);
            Thread.Sleep(500);

            new SelectElement(driver.FindElement(By.XPath(attachment_doccategory))).SelectByText(attachmentDoccategory);
            Thread.Sleep(800);
        }

        public void Attachment_DocCategoryTR(string text)
        {
            driver.FindElement(By.XPath(attachment_doccategory)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(attachment_doccategory)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Attachment_Description(string attachmentDescription)
        {
            driver.FindElement(By.XPath(attachment_description)).SendKeys(attachmentDescription);
            Thread.Sleep(500);
        }

        public void Attachment_DocSubmit()
        {
            driver.FindElement(By.XPath(attachment_atcsubmit)).Click();
            Thread.Sleep(2500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));   
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(attachments_addattachment)));
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
