using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.PageMethods.Requisition
{
   public class CreateRequisition
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string requisition = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg')]";
        string select_requisition = "//span[text()='Requisition']";

        string create = "//button[contains(span,'Create')]";

        string title = "//label[contains(text(),'Title*')]//parent::div/div/input";
        string catalog_type = "//label[contains(text(),'Catalog Type*')]//parent::div/div/div/div/div/input";
        string requested_by = "//label[contains(text(),'Requested By*')]//parent::div/div/div/div/div/input";
        string operating_unit = "//label[contains(text(),'Operating Unit*')]//parent::div/div/div/div/div/input";
        string ship_to_location = "//label[contains(text(),'Ship To Location*')]//parent::div/div/div/div/div/input";
        string emergency = "//div[@class='switch btn off btn-success']/.//span[text()='No']";
        string note_to_approval = "//label[contains(text(),'Note To Approver*')]//parent::div/div/textarea";
        string description = "//label[contains(text(),'Description*')]//parent::div/div/textarea";
        string fileupload = "//input[@type='file']";

        string lines = "//div[text()='Lines']";
        string create_item = "//span[text()='Action']/ancestor::div/div/select";
        string action_go = "//button/span[contains(text(),'Go')]";

        string line_type = "//label[contains(text(),'Line Type*')]//parent::div/div/div/div/div/input";
        //string catalog_item = "//label[contains(text(),'Catalog Item*')]//parent::div/div/input";
        string item = "//label[contains(text(),'Item')]//parent::div/div/div/div/div/input";
        string category = "//label[contains(text(),'Category*')]//parent::div/div/div/div/div/input";
        string uom = "//label[contains(text(),'UOM*')]//parent::div/div/div/div/div/input";
        //string cl_operating_unit = "(//label[contains(text(),'Operating Unit*')]//parent::div/div/div/div/div/input)[2]";
        //string cl_ship_to_location = "(//label[contains(text(),'Ship To Location*')]//parent::div/div/div/div/div/input)[2]";
        string quantity = "//label[contains(text(),'Quantity*')]//parent::div/div/input";
        string unit_price = "//label[contains(text(),'Unit Price*')]//parent::div/div/input";
        string buyer = "//label[contains(text(),'Buyer')]//parent::div/div/div/div/div/input";
        string need_by_date = "//label[contains(text(),'Need By Date*')]//parent::div/div/label/div/div/input";
        string rfq_required = "//label[contains(text(),'RFQ Required*')]//parent::div/div/div";
        string cl_description = "(//label[contains(text(),'Description*')]//parent::div/div/textarea)[2]";
        string cl_fileupload = "(//input[@type='file'])[2]";

        string department = "//label[contains(text(),'Department*')]//parent::div/div/div/div/div/input";
        
        string supplier = "//label[text()='Supplier']//parent::div/div/div/div/div/input";
        string supplier_site = "//label[text()='Supplier Site']//parent::div/div/div/div/div/input";
        string supplier_contact = "//label[text()='Supplier Contact']//parent::div/div/div/div/div/input";
        //string new_supplier = "//label[text()='New Supplier']//parent::div/div/div";
        string note_to_supplier = "//label[text()='Note To Supplier']//parent::div/div/textarea";
        string apply = "//button[span='Apply']";

        string action = "//button[span='Action']";
        string preview = "//button[text()='Preview']";
        string submit = "//button[text()='Submit']";

        string profile_icon = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";

        public CreateRequisition(IWebDriver driver)
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
            Thread.Sleep(1000);
        }

        public void Requisition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var ele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(requisition)));
            Actions action = new Actions(driver);
            action.MoveToElement(ele).Perform();

            ele = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(requisition + "//parent::div[text()='Requisition']")));
            action.MoveToElement(ele).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Select_Requisition()
        {
            driver.FindElement(By.XPath(select_requisition)).Click();
            Thread.Sleep(3000);
        }

        public void Create()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(1500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Title(string prTitle)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(title)));
            driver.FindElement(By.XPath(title)).SendKeys(prTitle);
            Thread.Sleep(800);
        }

        public void Catalog_Type(string catalogType)
        {
            driver.FindElement(By.XPath(catalog_type)).SendKeys(catalogType);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(catalog_type)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(catalog_type)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Requested_by(string requestedBy)
        {
            driver.FindElement(By.XPath(requested_by)).SendKeys(requestedBy);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(requested_by)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(requested_by)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }
        
        public void Operating_Unit(string operatingUnit)
        {
            driver.FindElement(By.XPath(operating_unit)).SendKeys(operatingUnit);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(operating_unit)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Ship_To_Location(string shipToLocation)
        {
            driver.FindElement(By.XPath(ship_to_location)).SendKeys(shipToLocation);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(ship_to_location)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(ship_to_location)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Emergency()
        {
            driver.FindElement(By.XPath(emergency)).Click();
            Thread.Sleep(500);
        }

        public void Note_To_Approver(string noteToApproval)
        {
            driver.FindElement(By.XPath(note_to_approval)).SendKeys(noteToApproval);
            Thread.Sleep(800);
        }

        public void Description(string descriptionText)
        {
            driver.FindElement(By.XPath(description)).SendKeys(descriptionText);
            Thread.Sleep(800);
        }

        public void Fileupload(string fileUpload)
        {
            driver.FindElement(By.XPath(fileupload)).SendKeys(fileUpload);
            Thread.Sleep(2000);
        }

        public void Lines()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(lines)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }

        public void Create_Line_Goods(string caAction, string lineType, string clItem, string lCategory, string lUOM,string lQuantity, string unitPrice, string LBuyer, string needByDate, string rfqRequired, string clFileuploads, string csDepartment, string clSupplier, string clSupplierSite, string clSupplierContact, string NoteToSupplier)
        {
            Thread.Sleep(1000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_item)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            new SelectElement(driver.FindElement(By.XPath(create_item))).SelectByText(caAction);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(action_go)).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(line_type)));
            Thread.Sleep(4500);

            driver.FindElement(By.XPath(line_type)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(lineType);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(item)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(item)).SendKeys(clItem);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(item)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(item)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath(category)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(lCategory);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(uom)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(lUOM);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath(quantity)).SendKeys(lQuantity);
            Thread.Sleep(500);
              
            driver.FindElement(By.XPath(unit_price)).SendKeys(unitPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(buyer)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(LBuyer);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(need_by_date)).SendKeys(needByDate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(need_by_date)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            if (rfqRequired.ToLower() == "yes")
            {
                var rfq = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(rfq_required)));
                action.MoveToElement(rfq).Click().Perform();
            }

            var dep = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(department)));
            action.MoveToElement(dep).Perform();
            driver.FindElement(By.XPath(cl_fileupload)).SendKeys(clFileuploads);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(department)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(department)).SendKeys(csDepartment);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(department)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(department)).SendKeys(Keys.Enter);
            Thread.Sleep(2500);


            var sup = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            action.MoveToElement(sup).Perform();
            driver.FindElement(By.XPath(supplier)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier)).SendKeys(clSupplier);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(supplier_site)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(clSupplierSite);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(supplier_contact)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(clSupplierContact);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);

            var nts = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(note_to_supplier)));
            action.MoveToElement(nts).Perform();
            nts.SendKeys(NoteToSupplier);

            action.MoveToElement(sup).Perform();
            Thread.Sleep(1000);
            action.MoveToElement(dep).Perform();
            Thread.Sleep(1000);

            var Apply = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(apply)));
            action.MoveToElement(Apply).Perform();
            Thread.Sleep(4500);
            Apply.Click();
            Thread.Sleep(3000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr/td")));
        }

        public void Create_Line_Services(string caAction, string lineType, string lCategory, string lUOM, string lQuantity, string unitPrice, string LBuyer, string needByDate, string rfqRequired, string clDescription, string clFileuploads, string csDepartment, string clSupplier, string clSupplierSite, string clSupplierContact, string NoteToSupplier)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_item)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            new SelectElement(driver.FindElement(By.XPath(create_item))).SelectByText(caAction);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(action_go)).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(line_type)));

            driver.FindElement(By.XPath(line_type)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(lineType);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(line_type)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
            
            driver.FindElement(By.XPath(category)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(lCategory);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(category)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(uom)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(lUOM);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(uom)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(quantity)).SendKeys(lQuantity);
            Thread.Sleep(500);
              
            driver.FindElement(By.XPath(unit_price)).SendKeys(unitPrice);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(buyer)).Click();
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(LBuyer);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(buyer)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(need_by_date)).SendKeys(needByDate);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(need_by_date)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            if (rfqRequired.ToLower() == "yes")
            {
                var rfq = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(rfq_required)));
                action.MoveToElement(rfq).Click().Perform();
            }

            driver.FindElement(By.XPath(cl_description)).SendKeys(clDescription);
            Thread.Sleep(800);

            var dep = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(department)));
            action.MoveToElement(dep).Perform();
            driver.FindElement(By.XPath(cl_fileupload)).SendKeys(clFileuploads);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(department)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(department)).SendKeys(csDepartment);
            Thread.Sleep(1500); 
            driver.FindElement(By.XPath(department)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(department)).SendKeys(Keys.Enter);
            Thread.Sleep(2500);


            var sup = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            action.MoveToElement(sup).Perform();
            driver.FindElement(By.XPath(supplier)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier)).SendKeys(clSupplier);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(supplier_site)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(clSupplierSite);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier_site)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(supplier_contact)).Click();
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(clSupplierContact);
            Thread.Sleep(1500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            driver.FindElement(By.XPath(supplier_contact)).SendKeys(Keys.Enter);
            Thread.Sleep(1500);

            var nts = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(note_to_supplier)));
            action.MoveToElement(nts).Perform();
            nts.SendKeys(NoteToSupplier);

            var Apply = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(apply)));
            action.MoveToElement(Apply).Click().Perform();
            Thread.Sleep(3000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr/td")));
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

        public void Action()
        {
            Thread.Sleep(1500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions move = new Actions(driver);
            move.MoveToElement(element).Click().Perform();
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
            Thread.Sleep(2000);
        }

        public void LogOut()
        {
            Thread.Sleep(1500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(profile_icon)));
            driver.FindElement(By.XPath(profile_icon)).Click();
            Thread.Sleep(800);
            driver.FindElement(By.XPath(logout)).Click();
            Thread.Sleep(500);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
