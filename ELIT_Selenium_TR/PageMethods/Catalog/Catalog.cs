using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ELIT_Selenium_TR.PageMethods.Catalog
{
     public class CreateCatalog 
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string catalog = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-cubes')]";
        string select_catalog = "//span[text()='Catalog']";

        //string catalogs = "//label[contains(text(),'Catalogs')]//parent::div/div/div/div/div/input";
        string create = "//button[contains(span,'Create')]";
        string catalog_name = "//label[contains(text(),'Catalog Name*')]//parent::div/div/input";
        string suppliername = "//label[contains(text(),'Supplier Name*')]//parent::div/div/div/div/div/input";
        string operating_unit = "//label[contains(text(),'Operating Unit')]//parent::div/div/div/div/div/input";
        string start_date = "//label[contains(text(),'End Date')]//parent::div/div/label/div/div/input";
        string end_date = "//label[contains(text(),'End Date')]//parent::div/div/label/div/div/input";
        string enable_flag = "//div[@class='switch btn off btn-danger']/.//span[text()='No']";
        string description = "//label[contains(text(),'Description*')]//parent::div/div/textarea";
        string file_upload = "//input[@type='file']";

        string items = "//div[contains(text(),'Items')]";

        string create_item = "//span[text()='Action']/ancestor::div/div/select";
        string action_go = "//button/span[contains(text(),'Go')]";
        string supplier_item_number = "//label[contains(text(),'Supplier Item Number*')]//parent::div/div/input";
        string item_number = "//label[text()='Item Number*']//parent::div/div/input";
        string category = "//label[text()='Category*']//parent::div/div/div/div/div/input";
        string sub_category = "//label[text()='Sub Category']//parent::div/div/div/div/div/input";
        string uom = "//label[text()='UOM*']//parent::div/div/div/div/div/input";
        string unit_price = "//label[text()='Unit Price*']//parent::div/div/input";
        string manufacturepartno = "//label[text()='Manufacturer Part No*']//parent::div/div/input";
        string manufacturername = "//label[text()='Manufacturer Name']//parent::div/div/input";
        string currency = "//label[text()='Currency*']//parent::div/div/div/div/div/input";
        string brand = "//label[text()='Brand']//parent::div/div/input";
        string manufacturer_url = "//label[text()='Manufacturer URL']//parent::div/div/input";
        string available_quantity = "//label[text()='Available Quantity']//parent::div/div/input";
        //string creation_date = "//label[text()='Creation Date*']//parent::div/div/label/div/div/input";
        string language = "//label[text()='Language']//parent::div/div/div";
        string create_item_decription = "(//label[contains(text(),'Description*')])[2]//parent::div/div/textarea";
        string createitem_fileupload = "(//input[@type='file'])[2]";
        string apply = "//span[contains(text(),'Apply')]";
        string preview = "//button[text()='Preview']";

        string action = "//button[contains(span,'Action')]";
        string submit = "//button[contains(text(),'Submit')]";



        public CreateCatalog(IWebDriver driver)
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
            driver.FindElement(By.XPath(login)).Click();
            Thread.Sleep(1500);
        }

        public void Catalog()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(catalog)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(catalog + "//parent::div[text()='Catalog']")).Click();
            Thread.Sleep(1500);

        }

        public void Select_Catalog()
        {
            driver.FindElement(By.XPath(select_catalog)).Click();
            Thread.Sleep(2500);


        }

        public void Create_Catalog()
        {
            driver.FindElement(By.XPath(create)).Click();
            Thread.Sleep(800);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(catalog_name)));
            Thread.Sleep(1000);
        }

        public void Catalogname(string catalogName)
        {
            driver.FindElement(By.XPath(catalog_name)).SendKeys(catalogName);
            Thread.Sleep(800);
        }

        public void Operating_Unit(string operatingUnit)
        {
            driver.FindElement(By.XPath(operating_unit)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(operatingUnit);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }
        
        public void Supplier_Name(string supplierName)
        {
            driver.FindElement(By.XPath(suppliername)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(suppliername)).SendKeys(supplierName);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(suppliername)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(suppliername)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Start_Date(string startDate)
        {
            driver.FindElement(By.XPath(start_date)).SendKeys(Keys.Control+"a");
            Thread.Sleep(500);
            driver.FindElement(By.XPath(start_date)).SendKeys(Keys.Clear);
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath(start_date)).SendKeys(startDate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(start_date)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void End_Date(string expiryDate)
        {
            driver.FindElement(By.XPath(end_date)).SendKeys(Keys.Control+"a");
            Thread.Sleep(500);
            driver.FindElement(By.XPath(end_date)).SendKeys(Keys.Clear);
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath(end_date)).SendKeys(expiryDate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(end_date)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Enable_Flag()
        {
            driver.FindElement(By.XPath(enable_flag)).Click();
            Thread.Sleep(1000);
        }

        public void Description(string descriptionText)
        {
            driver.FindElement(By.XPath(description)).SendKeys(descriptionText);
            Thread.Sleep(1000);
        }

        public void FileUpload(string fileUpload)
        {
            driver.FindElement(By.XPath(file_upload)).SendKeys(fileUpload);
        }

        public void Items()
        {
            driver.FindElement(By.XPath(items)).Click();
            Thread.Sleep(3500);
        }

        public void Create_Items(string caAction, string SupplierItemNumber, string ItemNumber, string Category, string SubCategory, string UOM, string unitPrice, string manufacturePartNo, string manufacturerName, string Currency, string Brand, string manufacturerUrl, string availableQuantity, string Language, string createItemDecription, string createitemFileUpload)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_item)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            new SelectElement(driver.FindElement(By.XPath(create_item))).SelectByText(caAction);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(action_go)).Click();
            Thread.Sleep(2500);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier_item_number)));

            driver.FindElement(By.XPath(supplier_item_number)).SendKeys(SupplierItemNumber);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(item_number)).SendKeys(ItemNumber);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(category)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(category)).SendKeys(Category);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
            
            driver.FindElement(By.XPath(sub_category)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(sub_category)).SendKeys(SubCategory);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(sub_category)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(sub_category)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
            
            driver.FindElement(By.XPath(uom)).Click();
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(uom)).SendKeys(UOM);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(uom)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(uom)).SendKeys(Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(unit_price)).SendKeys(unitPrice);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(manufacturepartno)).SendKeys(manufacturePartNo);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(manufacturername)).SendKeys(manufacturerName);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(currency)).SendKeys(Currency);
            Thread.Sleep(1200);
            driver.FindElement(By.XPath(currency)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);
            driver.FindElement(By.XPath(currency)).SendKeys(Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(brand)).SendKeys(Brand);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(manufacturer_url)).SendKeys(manufacturerUrl);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(available_quantity)).SendKeys(availableQuantity);
            Thread.Sleep(800);

            if(Language.ToUpper()=="arb")
            {
                driver.FindElement(By.XPath(language)).Click();
                Thread.Sleep(800);
            }
            
            driver.FindElement(By.XPath(create_item_decription)).SendKeys(createItemDecription);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(createitem_fileupload)).SendKeys(createitemFileUpload);
            Thread.Sleep(800);


           var Apply = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(apply)));
           action.MoveToElement(Apply).Click().Perform();
            Thread.Sleep(3500);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions actions = new Actions(driver);
            actions.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Preview()
        {
            driver.FindElement(By.XPath(preview)).Click();
            Thread.Sleep(3500);
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
