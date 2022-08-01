using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ELIT_Selenium_TR.PageMethods.RFQ.Simple
{
    public class SupplierAknowledgement_Quote
    {

        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string supplier = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]";
        string sourcing = "//span[text()='Sourcing']";

        string open_rfq = "//div[text()='Open']";
        string open_rfq_search = "//input[@placeholder='Search']";
        string first_rfq = "//table/tbody/tr/td[1]/span";

        string action = "//span[text()='Action']";
        string acknowledge = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Acknowledge Participation')]";
        string reject = "//span[text()='No']";
        string Description = "//label[text()='Note to Buyer']/parent::div/textarea";
        string acknowldege_submit = "//span[text()='Submit']";

        string create_quote = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Create Quote')]";
        string referneceno = "//label[text()='Reference Number']//parent::div/div/input";
        string notes_to_buyer = "//label[text()='Notes to Buyer (400 Character)']//parent::div/div/textarea";

        string attachments = "//div[text()='Attachments']";
        string na_add_attachment = "//span[text()='Add Attachment']";
        string na_atc_title = "(//label[text()='Title*']/parent::div/div/input[@value=''])";
        string na_atc_type = "(//label[text()='Type*']/parent::div/div/select)";
        string na_atc_upload_file = "//label[text()='Upload File']/parent::div/div/div/input[@type='file']";
        string na_atc_category = "//label[text()='Category*']/parent::div/div/select";
        string na_atc_description = "//label[text()='Description*']/parent::div/div/textarea";
        string na_atc_add = "//span[text()='Add']";

        string lines = "//button[text()='Lines']";
        string unit_price = "//label[text()='Unit Price']/parent::div/div/input";
        
        //string quote_line_apply = "(//button/span[contains(text(),'Apply')])[2]";
        string submit_quote = "//div[contains(@class,MuiPaper-root)]/ul/li[contains(text(),'Submit')]";

        string Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";   


        public SupplierAknowledgement_Quote(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToPage(string url)
        {
            driver.Navigate().GoToUrl(url);
            Thread.Sleep(500);
        }

        public void UserName(String usernName)
        {
            driver.FindElement(By.XPath(username)).SendKeys(usernName);
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
            Thread.Sleep(1500);
        }

        public void Supplier()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(supplier + "//parent::div[text()='Supplier']")).Click();
            Thread.Sleep(1000);
        }

        public void Sourcing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(sourcing)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(sourcing)).Click();
            Thread.Sleep(1000);
        }

        public void Open()
        {
            driver.FindElement(By.XPath(open_rfq)).Click();
            Thread.Sleep(1500);
        }

        public void Open_Search(string openRfqSearch)
        {
            driver.FindElement(By.XPath(open_rfq_search)).SendKeys(openRfqSearch);
            Thread.Sleep(800);
        }

        public void Rfq()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(first_rfq)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }
    
        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);

        }

        public void Acknowledge()
        {
            driver.FindElement(By.XPath(acknowledge)).Click();
            Thread.Sleep(1500);
        }

        public void Reject()
        {
            driver.FindElement(By.XPath(reject)).Click();
            Thread.Sleep(800);
        }

        public void AK_Description(string akDescription)
        {
            driver.FindElement(By.XPath(Description)).SendKeys(akDescription);
            Thread.Sleep(500);
        }

        public void Aknowledgement_Submit()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(acknowldege_submit)));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3000);

        }

        public void Create_Quote()
        {
            driver.FindElement(By.XPath(create_quote)).Click();
            Thread.Sleep(3500);
        }

        public void Reference(string refereneceNo)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(referneceno)));
            Thread.Sleep(800);

            driver.FindElement(By.XPath(referneceno)).SendKeys(refereneceNo);
            Thread.Sleep(500);
        }

        public void Note_To_Buyer(string notesToBuyer)
        {
            driver.FindElement(By.XPath(notes_to_buyer)).SendKeys(notesToBuyer);
            Thread.Sleep(500);
        }

        public void Attachments()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(attachments)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void NA_AddAttachment(string naAtcTitle, string naAtcType, string naAtcUploadFile, string naAtcCategory, string naAtcDescription)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(na_add_attachment)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3000);

            var title = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(na_atc_title)));
            driver.FindElement(By.XPath(na_atc_title)).SendKeys(naAtcTitle);
            Thread.Sleep(500);

            new SelectElement(driver.FindElement(By.XPath(na_atc_type))).SelectByText(naAtcType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(na_atc_upload_file)).SendKeys(naAtcUploadFile);
            Thread.Sleep(2500);

            new SelectElement(driver.FindElement(By.XPath(na_atc_category))).SelectByText(naAtcCategory);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(na_atc_description)).SendKeys(naAtcDescription);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(na_atc_add)).Click();
            Thread.Sleep(3500);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(na_add_attachment)));
        }

        public void Lines()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(lines)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }

        public void Lines_D()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//table)/tbody/tr/td")));

            IWebElement table = driver.FindElement(By.XPath("(//table)/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Lines Table is : " + RowCount);
            Console.WriteLine("(//table)[2]/tbody/tr[" + RowCount + "]/td[5]/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            Actions move = new Actions(driver);

            for (int i = 1; i <= RowCount; i++)
            {
                IWebElement unit_price = driver.FindElement(By.XPath("//table/tbody/tr["+i+"]/td[4]/div/div/input"));
                move.MoveToElement(unit_price).Perform();

                Random up = new Random();
                int u_p = up.Next(1500, 3000);
                string Unit_Price = Convert.ToString(u_p);

                unit_price.SendKeys(Unit_Price);
                Thread.Sleep(1000);
            }
        }

        public void Lines_Details()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//table)/tbody/tr/td")));

            IWebElement table = driver.FindElement(By.XPath("(//table)/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Lines Table is : " + RowCount);
            Console.WriteLine("(//table)[2]/tbody/tr[" + RowCount + "]/td[5]/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            Actions move = new Actions(driver);

            for (int i = 1; i <= RowCount; i++)
            {


                IWebElement EditLine = driver.FindElement(By.XPath("(//*[name()='svg'][@class='MuiSvgIcon-root editIconTable'])["+i+"]"));
                driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", EditLine);
                EditLine.Click();
                Thread.Sleep(10000);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(unit_price)));

                Random up = new Random();
                int u_p = up.Next(1500, 3000);
                string Unit_Price = Convert.ToString(u_p);

                driver.FindElement(By.XPath(unit_price)).SendKeys(Unit_Price);
                Thread.Sleep(1000);

                try
                {
                    string at = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[2]/tbody/tr[1]/td[2]";
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(at)));
                    bool AT = driver.FindElement(By.XPath(at)).Displayed;

                    if (AT==true)
                    {
                        try
                        {
                            string AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(AT_Table)));
                             AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                            IWebElement attributetable = driver.FindElement(By.XPath(AT_Table));
                            IList<IWebElement> attributetableRows = attributetable.FindElements(By.TagName("tr"));
                            int AttributeRowCount = attributetableRows.Count();
                            Thread.Sleep(3000);

                            for (int j = 1; j <= AttributeRowCount; j++)
                            {
                                 AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                                attributetable = driver.FindElement(By.XPath(AT_Table));
                                driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", attributetable);
                                Thread.Sleep(6000);

                                string atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/input";
                                bool value;
                                try
                                {
                                    atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/input";
                                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(atquotevalue)));
                                    value = driver.FindElement(By.XPath(atquotevalue)).Displayed;
                                }
                                catch(Exception date)
                                {
                                    Console.WriteLine(date.Message);
                                    value = false;
                                }
                                Thread.Sleep(3000);

                                if (value == true)
                                {
                                    Thread.Sleep(3000);

                                    IWebElement atl = driver.FindElement(By.XPath(atquotevalue));
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", atl);
                                    Thread.Sleep(3000);
                                    atl.Clear();
                                    Thread.Sleep(1500);

                                    string attargetvalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[6]/span | (//table)[2]/tbody/tr[" + j + "]/td[6]/span";
                                    string text1 = driver.FindElement(By.XPath(attargetvalue)).GetAttribute("innerHTML");
                                    Thread.Sleep(1500);

                                    driver.FindElement(By.XPath(atquotevalue)).Click();
                                    Thread.Sleep(500);

                                    driver.FindElement(By.XPath(atquotevalue)).SendKeys(text1);
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                                    attributetable = driver.FindElement(By.XPath(AT_Table));
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", attributetable);
                                    Thread.Sleep(6000);
                                    atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/label/div/div/input";

                                    IWebElement atl = driver.FindElement(By.XPath(atquotevalue));
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", atl);
                                    Thread.Sleep(3000);

                                    string attargetvalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[6]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[6]/div/div/label/div/div/input";
                                    string text1 = driver.FindElement(By.XPath(attargetvalue)).GetAttribute("value");
                                    Thread.Sleep(1000);

                                    driver.FindElement(By.XPath(atquotevalue)).Click();
                                    Thread.Sleep(500);

                                    driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Control+"a");
                                    driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Backspace);
                                    Thread.Sleep(1500);

                                    driver.FindElement(By.XPath(atquotevalue)).SendKeys(text1);
                                    Thread.Sleep(1500);

                                    driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Enter);
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    string cft = "/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[3]/tbody/tr[1]/td[2]";

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(cft)));

                    bool CFT = driver.FindElement(By.XPath(cft)).Displayed;

                    if (CFT==true)
                    {

                        try
                        {
                            string CF_Table = "/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[3]/tbody";
                            IWebElement cftable = driver.FindElement(By.XPath(CF_Table));
                            driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", cftable);
                            Thread.Sleep(3000);
                            IList<IWebElement> cftableRows = cftable.FindElements(By.TagName("tr"));
                            int CFRowCount = cftableRows.Count();

                            for (int k = 1; k <= CFRowCount; k++)
                            {
                                string cfquotevalue = "/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + k + "]/td[4]/div/div/input | (//table)[3]/tbody/tr[" + k + "]/td[4]/div/div/input";
                                IWebElement cfl = driver.FindElement(By.XPath(cfquotevalue));
                                driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", cfl);
                                Thread.Sleep(6000);
                                cfl.Clear();

                                string cftargetvalue = "/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + k + "]/td[5]/div/div/input | (//table)[3]/tbody/tr[" + k + "]/td[5]/div/div/input";
                                string text2 = driver.FindElement(By.XPath(cftargetvalue)).GetAttribute("value");
                                Thread.Sleep(1000);

                                driver.FindElement(By.XPath(cfquotevalue)).Click();
                                Thread.Sleep(500);
                                driver.FindElement(By.XPath(cfquotevalue)).SendKeys(text2);
                                Thread.Sleep(1500);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                   try
                    {
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

                        string quote_line_apply = "(//span[text()='Apply'])[2] | (//button/span[contains(text(),'Apply')])[2]";
                        js.ExecuteScript("window.scrollTo(0, 0)");
                        Thread.Sleep(4000);
                        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(quote_line_apply)));
                        element.Click();
                        Thread.Sleep(6000);

                        driver.Navigate().GoToUrl(driver.Url);
                        Thread.Sleep(8000);
                    }
                    catch(Exception exce)
                    {
                        Console.WriteLine(exce.Message);
                    }

                }
            }
        }

        public void Submit_Quote()
        {
            driver.FindElement(By.XPath(submit_quote)).Click();
            Thread.Sleep(1500);

            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();

            Thread.Sleep(3500);
        }

        public void Profile_logout()
        {
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(Profile)));
            element.Click();
            Thread.Sleep(800);
        }

        public void Logout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(logout)));
            element.Click();
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
