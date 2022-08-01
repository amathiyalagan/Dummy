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
    public class RaiseInvoice
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string purchaseorder = "//label/span[text()='Purchase Order']";

        string po_search = "//input[@placeholder='Search']";

        string raiseinvoice = "//button[text()='Raise Invoice']";
        string line_select = "(//span[@class='MuiIconButton-label'])[8]";
        string create_invoice = "//select";
        string invoicenumber = "//label[text()='Invoice Number*']//parent::div/div/input";
        string invoicedate = "//label[text()='Invoice Date*']//parent::div/div/div/div/input";
        string description = "//label[text()='Description*']//parent::div/div/textarea";
        string fileupload = "//input[@type='file']";

        string action = "//span[text()='Action']";
        string submit = "//button[text()='Submit']";

        public RaiseInvoice(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
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
            driver.FindElement(By.XPath(login)).Click();
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

        public void PurchaseOrder()
        {
            driver.FindElement(By.XPath(purchaseorder)).Click();
            Thread.Sleep(2000);
        }

        public void PO_Search(string text)
        {
            driver.FindElement(By.XPath(po_search)).SendKeys(text);
            Thread.Sleep(2500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='" + text + "']")));

            driver.FindElement(By.XPath("//td[text()='" + text + "']")).Click();
            Thread.Sleep(3500);
        }

        public void Raise_Invoice()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, -250)");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(raiseinvoice)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);
        }

        public void Line_Select()
        {
            var element = driver.FindElement(By.XPath(line_select));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            element.Click();
            Thread.Sleep(1000);
        }

        public void Create_Invoice(string createInvoice)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_invoice)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            new SelectElement(driver.FindElement(By.XPath(create_invoice))).SelectByText(createInvoice);
            Thread.Sleep(2500);
        }

        public void Invoice_Number(string invoiceNumber)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(invoicenumber)));

            driver.FindElement(By.XPath(invoicenumber)).SendKeys(invoiceNumber);
            Thread.Sleep(500);

            driver.FindElement(By.XPath("//label[text()='Invoice Number*']")).Click();
        }

        public void Invoice_Date(string invoiceDate)
        {
            driver.FindElement(By.XPath(invoicedate)).SendKeys(invoiceDate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(invoicedate)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Invoice_Description(string invoiceDescription)
        {
            driver.FindElement(By.XPath(description)).SendKeys(invoiceDescription);
            Thread.Sleep(800);
        }

        public void FileUpload(string riFileupload)
        {
            driver.FindElement(By.XPath(fileupload)).SendKeys(riFileupload);
        }

        public void Invoice_Lines()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 800)");
            Thread.Sleep(2000);
        }

        public void Invoice_Lines_Pager()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//table/tfoot/tr/td/div//*[name()='svg']")).Click();
            Thread.Sleep(800);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//div[@id='menu-']/div/ul/li[@data-value='20']")));
            element.Click();
            Thread.Sleep(800);
        }


        public void Invoice_Lines_Details()
        {
            IWebElement table = driver.FindElement(By.XPath("(//table)/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Certificate Table is : " + RowCount);
            Console.WriteLine("(//table)/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);


            for (int i = 1; i <= RowCount; i++)
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr[" + i + "]/td[9]")));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                IWebElement AQ = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[6]"));
                string Available_Quantity = Convert.ToString(AQ.GetAttribute("innerHTML"));

                try
                {
                    string Invoice_Quantity = Available_Quantity;

                    driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[7]/div/div/input")).SendKeys(Invoice_Quantity);
                    Thread.Sleep(800);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    ErrorValidation();
                }

            }

        }

        public void Action()
        {
            driver.FindElement(By.XPath(action)).Click();
            Thread.Sleep(800);
        }

        public void Submit()
        {
            driver.FindElement(By.XPath(submit)).Click();
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

        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
