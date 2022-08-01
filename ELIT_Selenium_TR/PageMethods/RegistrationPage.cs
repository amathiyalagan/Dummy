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
    class RegistartionPage
    {
        private IWebDriver driver;

        string signup = "//button[text()='Create Supplier Account']";
        string agree = "//span[text()='I Agree']";
        string companyname = "//label[text()='Company Name*']//parent::div/div/input";
        string body = "//label[text()='Company Name*']";
        string licensenumber = "//label[text()='License Number*']//parent::div/div/input";
        string establishment_year = "//label[text()='Establishment Year*']//parent::div/div/label/div/div/input";
        string issuedate = "//label[text()='Issue Date*']//parent::div/div/label/div/div/input";
        string expirydate = "//label[text()='Expiry Date']//parent::div/div/label/div/div/input";
        string fileupload = "//input[@type='file']";
        string title = "//label[text()='Title*']//parent::div/div/select";
        string firstname = "//label[text()='First Name*']//parent::div/div/input";
        string middlename = "//label[text()='Middle Name']//parent::div/div/input";
        string lastname = "//label[text()='Last Name*']//parent::div/div/input";
        string email = "//label[text()='Email Address*']//parent::div/div/input";
        string phonenumber = "//label[text()='Phone Number*']//parent::div/div/div/input";
        string alternativenumber = "//label[text()='Alternative Number']//parent::div/div/div/input";
        string submit = "//span[text()='Submit']";
        string goback = "//span[text()='Go Back']";
        public RegistartionPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string text)
        {
            driver.Navigate().GoToUrl(text);
        }

        public void Signup()
        {
            Thread.Sleep(1000);
            driver.FindElement(By.XPath(signup)).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(agree)));
        }

        public void Agree()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(agree)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Companyname(string CompanyName)
        {
           driver.FindElement(By.XPath(companyname)).SendKeys(CompanyName);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(body)).Click();
            Thread.Sleep(4500);
        }

        public void Licensenumber(string licenseNumber)
        {
            driver.FindElement(By.XPath(licensenumber)).SendKeys(licenseNumber);
            Thread.Sleep(1000);
        }

        public void Establishment_Year(string establishment_Year)
        {
            driver.FindElement(By.XPath(establishment_year)).SendKeys(establishment_Year);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(establishment_year)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Issuedate(string issueDate)
        {
            driver.FindElement(By.XPath(issuedate)).SendKeys(issueDate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(issuedate)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void ExpiryDate(string expiryDate)
        {
            driver.FindElement(By.XPath(expirydate)).SendKeys(expiryDate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(expirydate)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void FileUpload(string fileUpload)
        {
            driver.FindElement(By.XPath(fileupload)).SendKeys(fileUpload);
        }

        public void Title(string TITLE)
        {
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(title)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);
			
			
            new SelectElement(driver.FindElement(By.XPath(title))).SelectByText(TITLE);
            Thread.Sleep(500);
        }

        public void FirstName(string firstName)
        {
            driver.FindElement(By.XPath(firstname)).SendKeys(firstName);
            Thread.Sleep(1000);
        }

        public void MiddleName(string middleName)
        {
            driver.FindElement(By.XPath(middlename)).SendKeys(middleName);
            Thread.Sleep(1000);
        }

        public void LastName(string lastName)
        {
            driver.FindElement(By.XPath(lastname)).SendKeys(lastName);
            Thread.Sleep(1000);
        }

        public void EmailAddress(string emailAddress)
        {
            driver.FindElement(By.XPath(email)).SendKeys(emailAddress);
            Thread.Sleep(1000);
        }

        public void PhoneNumber(string phoneNumber)
        {
            driver.FindElement(By.XPath(phonenumber)).SendKeys(phoneNumber);
            Thread.Sleep(1000);
        }

        public void AlternativeNumber(string alternativeNumber)
        {
            driver.FindElement(By.XPath(alternativenumber)).SendKeys(alternativeNumber);
            Thread.Sleep(1000);
        }

        public void SubmitClick()
        {
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(submit)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(700);
			
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(3500);
        }

        public void LoginPage()
        {
            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element1 = wait1.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(goback)));
            Actions action1 = new Actions(driver);
            action1.MoveToElement(element1).Click().Perform();
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
