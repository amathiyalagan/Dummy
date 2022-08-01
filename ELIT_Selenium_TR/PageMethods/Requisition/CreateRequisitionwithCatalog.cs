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
    class CreateRequisitionwithCatalog
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
        string emergency = "//div[@class='switch btn off btn-success']";
        string note_to_approval = "//label[contains(text(),'Note To Approver*')]//parent::div/div/textarea";
        string description = "//label[contains(text(),'Description*')]//parent::div/div/textarea";
        string fileupload = "//input[@type='file']";

        string lines = "//div[text()='Lines']";
        string create_item = "//span[text()='Action']/ancestor::div/div/select";
        string action_go = "//button/span[contains(text(),'Go')]";

        string catalogs = "//label[contains(text(),'Catalogs*')]//parent::div/div/div/div/div/input";
        string proceed = "//button[text()='Proceed']";

        string action = "//button[span='Action']";
        string submit = "//button[text()='Submit']";



        public CreateRequisitionwithCatalog(IWebDriver driver)
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
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(requisition + "//parent::div[text()='Requisition']")));
            Actions action = new Actions(driver);
            action.MoveToElement(ele).Perform();
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Select_Requisition()
        {
            driver.FindElement(By.XPath(select_requisition)).Click();
            Thread.Sleep(1500);
        }

        public void Create()
        {
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
            Thread.Sleep(800);
        }


        public void Lines()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(lines)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
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

        public void ImportLineFromCatalog(string caAction, string CatalogName)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_item)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            new SelectElement(driver.FindElement(By.XPath(create_item))).SelectByText(caAction);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(action_go)).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(catalogs)));

           IWebElement Catalog= driver.FindElement(By.XPath(catalogs));
            Catalog.SendKeys(CatalogName);
            Thread.Sleep(800);
            Catalog.SendKeys(Keys.ArrowDown);
            Catalog.SendKeys(Keys.Enter);

            Thread.Sleep(3000);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//table/tbody/tr[2]/td)[2]")));

            driver.FindElement(By.XPath("(//table/thead/tr/th[1])[2]")).Click();

            IWebElement cart = driver.FindElement(By.XPath("//i[contains(@class,'fa fa-shopping-cart')]"));
            cart.Click();

            IList<IWebElement> textbox = driver.FindElements(By.TagName("//i[@class='fa fa-plus']//ancestor::div[@class='input-group counter-input']/input"));
            int InputFields = textbox.Count();

            if(InputFields>0)
            {
                try
                {
                    for(int i=0;i<InputFields;i++)
                    {
                       IWebElement inputtext =  driver.FindElement(By.XPath("//i[@class='fa fa-plus']//ancestor::div[@class='input-group counter-input']/input["+i+"]"));
                        action.MoveToElement(inputtext).Perform();
                        inputtext.SendKeys(Keys.Control + "a");
                        Thread.Sleep(800);
                        inputtext.Clear();
                        Thread.Sleep(800);

                        Random rd = new Random();
                        string quantity = Convert.ToString(rd.Next(1, 10));
                        inputtext.SendKeys(quantity);
                        Thread.Sleep(800);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    ErrorValidation();
                }
            }

            element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(proceed)));
            action.MoveToElement(element).Perform();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(proceed)).Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr/td[2]")));

        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions move = new Actions(driver);
            move.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Submit()
        {
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(800);
        }

        public void CloseBrowser()
        {
            driver.Quit();
        }

    }
}
