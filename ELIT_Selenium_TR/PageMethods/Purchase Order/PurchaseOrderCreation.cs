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

namespace ELIT_Selenium_TR.PageMethods.Purchase_Order
{
    public class PurchaseOrderCreation
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string orders = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string po = "//span[text()='Purchase Order']";

        string create = "//span[text()='Create']";
        string header_title = "//label[text()='Title*']/parent::div/div/input";
        string operating_unit = "//label[text()='Operating Unit*']/parent::div/div/div/div/div/input";
        string order_type = "//label[text()='Order Type*']/parent::div/div/div/div/div/input";
        string supplier = "//label[text()='Supplier*']/parent::div/div/div/div/div/input";
        string supplier_site = "//label[text()='Supplier Site*']/parent::div/div/div/div/div/input";
        string supplier_contact = "//label[text()='Supplier Contact*']/parent::div/div/div/div/div/input";
        string currency_code = "//label[text()='Currency Code']/parent::div/div/div/div/div/input";
        string nts = "//label[text()='Note To Approver*']/parent::div/div/textarea";
        string file_upload = "//input[@type='file']";

        string t_c = "//div[text()='Terms And Conditions']";
        string tc_billtolocation = "//label[text()='Bill To Location*']/parent::div/div/div/div/div/input";
        string tc_shiptolocation = "//label[text()='Ship To Location*']/parent::div/div/div/div/div/input";
        string tc_paymentterms = "//label[text()='Payment Terms*']/parent::div/div/div/div/div/input";
        string tc_frightterms = "//label[text()='Freight Terms*']/parent::div/div/div/div/div/input";
        string tc_carrier = "//label[text()='Carrier']/parent::div/div/div/div/div/input";

        string lines = "//div[text()='Lines']";
        string linecreate_select = "//span[text()='Action']/ancestor::div/div/select";
        string linecreate_go = "//span[text()='Go']";

        string cl_linetype = "//label[text()='Line Type*']/parent::div/div/div/div/div/input";
        string cl_item = "//label[text()='Item*']/parent::div/div/div/div/div/input";
        string cl_Category = "//label[text()='Category*']/parent::div/div/div/div/div/input";
        string cl_UOM = "//label[text()='UOM*']/parent::div/div/div/div/div/input";
        string cl_quantity = "//label[text()='Quantity*']/parent::div/div/input";
        string cl_unitprice = "//label[text()='Unit Price*']/parent::div/div/input";
        string cl_stlocation = "(//label[text()='Ship To Location*']/parent::div/div/div/div/div/input)[2]";
        string cl_bestprice = "//label[text()='Best Price']/parent::div/div/input";
        string cl_avgprice = "//label[text()='Average Price']/parent::div/div/input";
        string cl_currentprice = "//label[text()='Current Price']/parent::div/div/input";
        string cl_needbydate = "//label[text()='Need By Date*']/parent::div/div/label/div/div/input";
        string cl_promiseddate = "//label[text()='Promised Date*']/parent::div/div/label/div/div/input";
        string cl_description = "//label[text()='Description*']/parent::div/div/textarea";

        string purchase_option = "//label[text()='Purchase Option*']/parent::div/div/div/div/div/input";
        string match_option = "//label[text()='Match Option']/parent::div/div/div/div/div/input";
        string LineCreate_apply = "//span[text()='Apply']";


        string action = "//span[text()='Action']";
        string preview = "//button[text()='Preview']";
        string submit = "//button[text()='Submit']";

        string profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public PurchaseOrderCreation(IWebDriver driver)
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
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(username)));

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
            Thread.Sleep(2000);
        }

        public void Orders()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(orders)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(orders + "//parent::div[text()='Orders']")).Click();
            Thread.Sleep(1500);
        }

        public void Purchase_order()
        {
            driver.FindElement(By.XPath(po)).Click();
            Thread.Sleep(2500);
        }

        public void Create()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1800);
        }

        public void Header_Title(string headerTitle)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(header_title)));

            driver.FindElement(By.XPath(header_title)).SendKeys(headerTitle);
            Thread.Sleep(500);
        }

        public void Operating_Unit(string operatingUnit)
        {
            driver.FindElement(By.XPath(operating_unit)).SendKeys(operatingUnit);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Order_Type(string orderType)
        {
            driver.FindElement(By.XPath(order_type)).SendKeys(orderType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(order_type)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(order_type)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Supplier(string poSupplier)
        {
            driver.FindElement(By.XPath(supplier)).SendKeys(poSupplier);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Supplier_Site(string prSupplierSite)
        {
            driver.FindElement(By.XPath(supplier_site)).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath(supplier_site)).SendKeys(prSupplierSite);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Supplier_Contact(string prSupplierContact)
        {
            driver.FindElement(By.XPath(supplier_contact)).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath(supplier_contact)).SendKeys(prSupplierContact);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Currency_Code(string CurrencyCode)
        {
            driver.FindElement(By.XPath(currency_code)).Click();
            Thread.Sleep(2000);      
            
            driver.FindElement(By.XPath(currency_code)).SendKeys(CurrencyCode);
            Thread.Sleep(500);                                                                                   

            driver.FindElement(By.XPath(currency_code)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(currency_code)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Notes_To_Approver(string noteToApproval)
        {
            driver.FindElement(By.XPath(nts)).SendKeys(noteToApproval);
            Thread.Sleep(500);                                                                                   
        }

        public void Attachment(string fileUpload)
        {
            driver.FindElement(By.XPath(file_upload)).SendKeys(fileUpload);
        }

        public void Terms_Conditions()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(t_c)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Bill_to_Location(string billToLocation)
        {
            driver.FindElement(By.XPath(tc_billtolocation)).SendKeys(billToLocation);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_billtolocation)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_billtolocation)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

        }

        public void Ship_To_Location(string shipToLocation)
        {
            driver.FindElement(By.XPath(tc_shiptolocation)).SendKeys(shipToLocation);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_shiptolocation)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_shiptolocation)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Payment_Terms(string PaymentTerms)
        {

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(PaymentTerms);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Freight_Terms(string frightTerms)
        {
            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(frightTerms);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }
        

        public void Carrier(string tcCarrier)
        {
            driver.FindElement(By.XPath(tc_carrier)).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath(tc_carrier)).SendKeys(tcCarrier);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_carrier)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_carrier)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Lines()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(lines)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3000);
        }

        public void CL_Goods(string linecreate, string clLineType, string clItem, string clQuantity, string clUnitprice, string clStLocation, string clNeedBy, string clPromisedDate, string purchaseOption, string matchOption, string cl_fileupload)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(linecreate_select)));
            Thread.Sleep(3000);

            new SelectElement(driver.FindElement(By.XPath(linecreate_select))).SelectByText(linecreate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(linecreate_go)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_linetype)).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(clLineType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_item)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_item)).SendKeys(clItem);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_item)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_item)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_quantity)).SendKeys(clQuantity);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_unitprice)).SendKeys(clUnitprice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(clStLocation);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbydate)).SendKeys(clNeedBy);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbydate)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_promiseddate)).SendKeys(clPromisedDate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_promiseddate)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_fileupload)).SendKeys(cl_fileupload);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(purchaseOption);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(match_option)).Click();
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(match_option)).SendKeys(matchOption);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(match_option)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(match_option)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(LineCreate_apply)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr/td[2]")));
        }

        public void CL_Services(string linecreate, string clLineType, string clCategory, string clUOM, string clQuantity, string clUnitPrice, string clStlocation, string clBestPrice, string clAvgPrice, string clCurrentPrice, string clNeedBy, string clPromisedDate, string purchaseOption, string matchOption, string cl_fileupload)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(linecreate_select)));
            Thread.Sleep(3000);

            new SelectElement(driver.FindElement(By.XPath(linecreate_select))).SelectByText(linecreate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(linecreate_go)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_linetype)).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(clLineType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_Category)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(clCategory);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_UOM)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(clUOM);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_quantity)).SendKeys(clQuantity);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_unitprice)).SendKeys(clUnitPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(clStlocation);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_bestprice)).SendKeys(clBestPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_avgprice)).SendKeys(clAvgPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_currentprice)).SendKeys(clCurrentPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbydate)).SendKeys(clNeedBy);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbydate)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_promiseddate)).SendKeys(clPromisedDate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_promiseddate)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_description)).SendKeys(clLineType + " "+ clCategory+" "+ clUOM);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_fileupload)).SendKeys(cl_fileupload);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(purchaseOption);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(purchase_option)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(match_option)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(match_option)).SendKeys(matchOption);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(match_option)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);  

            driver.FindElement(By.XPath(match_option)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(LineCreate_apply)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr/td[2]")));

        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions move = new Actions(driver);
            move.MoveToElement(element).Perform();

            driver.FindElement(By.XPath(action)).Click();
            Thread.Sleep(500);
        }

        public void Preview()
        {
            driver.FindElement(By.XPath(preview)).Click();
            Thread.Sleep(1500);
        }

        public void Submit()
        {
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(1500);
        }

        public void LOGOUT()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

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
