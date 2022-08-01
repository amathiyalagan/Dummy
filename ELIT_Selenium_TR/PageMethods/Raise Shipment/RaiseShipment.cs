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

namespace ELIT_Selenium_TR.PageMethods.Raise_Shipment
{
    public class RaiseShipment
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string login = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string Supplierprofile = "//div[text()='Supplier Profile']";
        string purchaseorder = "//label/span[text()='Purchase Order']";

        string po_search = "//input[@placeholder='Search']";

        string raiseshipment = "//button[text()='Raise Shipment']";
        string line_select = "(//span[@class='MuiIconButton-label'])[8]";
        string create_shipment = "//select";
        string shipment_number = "//label[text()='Shipment Number*']//parent::div/div/input";
        string shipment_number_label = "//label[text()='Shipment Number*']";
        string shipment_date = "//label[text()='Shipment Date*']//parent::div/div/div/div/input";
        string expected_receipt_date = "//label[text()='Expected Recipe Date*']//parent::div/div/div/div/input";
        string numberofcontainer = "//label[text()='Number of Container']//parent::div/div/input";
        string waybillnumber = "//label[text()='Waybill Number']//parent::div/div/input";
        string packingcode = "//label[text()='Packing Code']//parent::div/div/input";
        string handlingcode = "//label[text()='Handling Code']//parent::div/div/input";
        string netweight = "//label[text()='Net Weight']//parent::div/div/input";
        string uomnetweight = "//label[text()='UOM Net Weight']//parent::div/div/input";
        string comments = "//label[text()='Comments*']//parent::div/div/textarea";
        string fileupload = "//input[@type='file']";

        //string shipment_lines = "//div[text()='Shipment Lines']";
        //string Quantity_Shipped = "//table/tbody/tr/td[11]/div/div/input";

        //string shipment_comments = "//table/tbody/tr/td[17]/div/div/input";

        string action = "//span[text()='Action']";
        string submit = "//button[text()='Submit']";
        //string closetoast = "//body/div/div/div/div[2]/div[1]/div[1]//*[name()='svg']";


        public RaiseShipment(IWebDriver driver)
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
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
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

        public void PO_Search (string poSearch)
        {
            driver.FindElement(By.XPath(po_search)).SendKeys(poSearch);
            Thread.Sleep(2500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//td[text()='" + poSearch + "']")));

            driver.FindElement(By.XPath("//td[text()='" + poSearch + "']")).Click();
            Thread.Sleep(3500);
        }

        public void Raise_Shipment()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, -250)");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(raiseshipment)));
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

        public void Create_Shipment(string createShipment)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(create_shipment)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();

            new SelectElement(driver.FindElement(By.XPath(create_shipment))).SelectByText(createShipment);
            Thread.Sleep(2500);
        }

        public void Shipment_Number(string shipmentNumber)
        {
            driver.FindElement(By.XPath(shipment_number)).SendKeys(shipmentNumber);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(shipment_number_label)).Click();
            Thread.Sleep(3500);

        }

        public void Shipment_Date(string shipmentDate)
        {
            driver.FindElement(By.XPath(shipment_date)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(shipment_date)).SendKeys(shipmentDate);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(shipment_date)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Expected_Receipt_Date(String expectedReceiptDate)
        {
            driver.FindElement(By.XPath(expected_receipt_date)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(expected_receipt_date)).SendKeys(expectedReceiptDate);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(expected_receipt_date)).SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Number_Of_Container(string numberOfContainer)
        {
            driver.FindElement(By.XPath(numberofcontainer)).SendKeys(numberOfContainer);
            Thread.Sleep(800);
        }

        public void WayBillNumber(string wayBillNumber)
        {
            driver.FindElement(By.XPath(waybillnumber)).SendKeys(wayBillNumber);
            Thread.Sleep(1000);
        }

        public void PackingCode(string packingCode)
        {
            driver.FindElement(By.XPath(packingcode)).SendKeys(packingCode);
            Thread.Sleep(1000);
        }

        public void HandlingCode(string handlingCode)
        {
            driver.FindElement(By.XPath(handlingcode)).SendKeys(handlingCode);
            Thread.Sleep(1000);
        }

        public void NetWeight(string netWeight)
        {
            driver.FindElement(By.XPath(netweight)).SendKeys(netWeight);
            Thread.Sleep(1000);
        }

        public void UOMNetWeight(string uomNetWeight)
        {
            driver.FindElement(By.XPath(uomnetweight)).SendKeys(uomNetWeight);
            Thread.Sleep(1000);
        }

        public void Comments(string rsComments)
        {
            driver.FindElement(By.XPath(comments)).SendKeys(rsComments);
            Thread.Sleep(1000);
        }

        public void FileUpload(string rsFileupload)
        {
            driver.FindElement(By.XPath(fileupload)).SendKeys(rsFileupload);
        }

        public void Shipment_Lines()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 800)");
            Thread.Sleep(2000);
        }
        

        public void Shipment_Lines_Pager()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//table/tfoot/tr/td/div/div//*[name()='svg']")).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath("//div[@id='menu-']/div/ul/li[@data-value='20']")).Click();
            Thread.Sleep(800);
        }


        public void Shipment_Lines_Details(string packagingSlip, string containerNumber, string countryOfOrigin, string truckNumber, string barCodeLabel, string rscomments)
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


            for(int i=1; i<=RowCount; i++)
            {

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
                var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//table/tbody/tr[" + i+ "]/td[9]")));
                Actions action = new Actions(driver);
                action.MoveToElement(element).Perform();

                IWebElement QO = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[9]"));
                int Quantity_Ordered = Convert.ToInt32(QO.GetAttribute("innerHTML"));

                int Quantity_Received;
                string Quantity_Shipped;
                try
                {
                    IWebElement QR = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[10]"));
                    string qrs = QR.GetAttribute("innerHTML");
                    if(qrs=="")
                    {
                        Quantity_Received = 0;
                    }
                    else
                    {
                        Quantity_Received = Int16.Parse(QR.GetAttribute("innerHTML"));
                    }

                    if (Quantity_Received == 0)
                    {
                        Quantity_Shipped = Convert.ToString(Quantity_Ordered);

                        IWebElement div_to_scroll = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input"));
                        driver.ExecuteJavaScript("arguments[0].scrollBy(0,900)", div_to_scroll);
                        Thread.Sleep(800);

                        IWebElement Shipped_Quantity = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input"));
                        action.MoveToElement(Shipped_Quantity).Perform();

                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).Click();
                        Thread.Sleep(800);
                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).Clear();
                        Thread.Sleep(800);
                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).SendKeys(Quantity_Shipped);
                        Thread.Sleep(800);
                    }
                    else if (Quantity_Received >= 1)
                    {
                        Quantity_Shipped = Convert.ToString(Quantity_Ordered - Quantity_Received);

                        IWebElement div_to_scroll = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input"));
                        driver.ExecuteJavaScript("arguments[0].scrollBy(0,900)", div_to_scroll);
                        Thread.Sleep(800);

                        IWebElement Shipped_Quantity = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input"));
                        action.MoveToElement(Shipped_Quantity).Perform();

                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).Click();
                        Thread.Sleep(800);
                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).Clear();
                        Thread.Sleep(800);
                        driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[11]/div/div/input")).SendKeys(Quantity_Shipped);
                        Thread.Sleep(800);

                    }
                }
                catch(Exception ex)
                {
                    Quantity_Received = 0;
                    Console.WriteLine(ex);
                }
                finally
                {
                    ErrorValidation();
                }

                IWebElement packagingslip = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[12]/div/div/input"));
                action.MoveToElement(packagingslip).Perform();
                packagingslip.Click();
                Thread.Sleep(500);
                packagingslip.SendKeys(packagingSlip);
                Thread.Sleep(800);

                IWebElement containernumber = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[13]/div/div/input"));
                action.MoveToElement(containernumber).Perform();
                containernumber.Click();
                Thread.Sleep(800);
                containernumber.SendKeys(containerNumber);
                Thread.Sleep(800);

                IWebElement countryoforigin = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[14]/div/div/div/div/div/input"));
                action.MoveToElement(countryoforigin).Perform();
                countryoforigin.Click();
                Thread.Sleep(800);
                countryoforigin.SendKeys(countryOfOrigin);
                Thread.Sleep(800);
                countryoforigin.SendKeys(Keys.ArrowDown);
                Thread.Sleep(800);
                countryoforigin.SendKeys(Keys.Enter);
                Thread.Sleep(800);

                IWebElement trucknumber = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[15]/div/div/input"));
                action.MoveToElement(trucknumber).Perform();
                trucknumber.Click();
                Thread.Sleep(800);
                trucknumber.SendKeys(truckNumber);
                Thread.Sleep(800);

                IWebElement barcodelabel = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[16]/div/div/input"));
                action.MoveToElement(barcodelabel).Perform();
                barcodelabel.Click();
                Thread.Sleep(800);
                barcodelabel.SendKeys(barCodeLabel);
                Thread.Sleep(800);

                IWebElement comments = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[17]/div/div/input"));
                action.MoveToElement(comments).Perform();
                comments.Click();
                Thread.Sleep(800);
                comments.SendKeys(rscomments);
                Thread.Sleep(800);

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
