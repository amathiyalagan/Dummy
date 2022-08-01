using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Support.Extensions;

namespace ELIT_Selenium_TR.PageMethods
{
    
   public static class PageObject
   {
        public static int i;
        public static int j;
        public static int k;
        public static By username = By.XPath("//input[@type='text']");
        public static By password = By.XPath( "//input[@type='password']");
        public static By loginnow = By.XPath("//button[text()='Login Now']");

        public static By sidebar = By.XPath("//ul[contains(@class,'al-sidebar-list')]/li/div/i");

        public static By supplier = By.XPath("//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-th-large')]//parent::div[text()='Supplier']");
        public static By sourcing = By.XPath("//span[text()='Sourcing']");
        public static By open = By.XPath("//div[text()='Open']");
        public static By search = By.XPath("//input[@placeholder='Search']");
        public static By rfq = By.XPath("//table/tbody/tr/td[1]/span");
        public static By buyer = By.XPath("//label[text()='Buyer']");
        public static By action = By.XPath("//span[text()='Action']");
        public static By acknowledge = By.XPath("//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Acknowledge Participation')]");
        public static By no = By.XPath("//span[text()='No']//parent::label");
        public static By yes = By.XPath("//span[text()='Yes']//parent::label");
        public static By notetobuyer = By.XPath("//label[text()='Note to Buyer']/parent::div/textarea");
        public static By submit = By.XPath("//span[text()='Submit']//parent::button");

        public static By createquote = By.XPath("//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Create Quote')]");
        public static By referneceno = By.XPath("//label[text()='Reference Number']//parent::div/div/input");
        public static By notes_to_buyer = By.XPath("//label[text()='Notes to Buyer (400 Character)']//parent::div/div/textarea");
        public static By attachments = By.XPath("//div[text()='Attachments']");
        public static By na_add_attachment = By.XPath("//span[text()='Add Attachment']");
        public static By na_atc_title = By.XPath("(//label[text()='Title*']/parent::div/div/input[@value=''])");
        public static By na_atc_type = By.XPath("(//label[text()='Type*']/parent::div/div/select)");
        public static By na_atc_upload_file =By.XPath("//label[text()='Upload File']/parent::div/div/div/input[@type='file']");
        public static By na_atc_category = By.XPath("//label[text()='Category*']/parent::div/div/select");
        public static By na_atc_description = By.XPath("//label[text()='Description*']/parent::div/div/textarea");
        public static By na_atc_add = By.XPath("//span[text()='Add']");

        public static By lines = By.XPath("//button[text()='Lines']");
        public static By lineswait = By.XPath("(//table)/tbody/tr/td[2]");
        public static By linetable = By.XPath("(//table)/tbody");
        public static By linesedit = By.XPath("(//*[name()='svg'][@class='MuiSvgIcon-root editIconTable'])[" + i + "]");
        public static By unit_price = By.XPath("//label[text()='Unit Price']/parent::div/div/input");

        public static By at = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[2]/tbody/tr[1]/td[2]");
        public static By AT_Table = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody");
        public static By atquotevalue = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/input");
        public static By attargetvalue = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[6]/span | (//table)[2]/tbody/tr[" + j + "]/td[6]/span");

        public static By cft = By.XPath("/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[3]/tbody/tr[1]/td[2]");
        public static By CF_Table = By.XPath("/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[3]/tbody");
        public static By cfquotevalue =By.XPath("/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + k + "]/td[4]/div/div/input | (//table)[3]/tbody/tr[" + k + "]/td[4]/div/div/input");
        public static By cftargetvalue =By.XPath("/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + k + "]/td[5]/div/div/input | (//table)[3]/tbody/tr[" + k + "]/td[5]/div/div/input");
        public static By quote_line_apply =By.XPath("(//span[text()='Apply'])[2] | (//button/span[contains(text(),'Apply')])[2]");

        public static By quote_action =By.XPath("//span[text()='Action']");
        public static By submit_quote = By.XPath("//div[contains(@class,MuiPaper-root)]/ul/li[contains(text(),'Submit')]");

        public static By profileicon = By.XPath("(//div[contains(@class,'MuiAvatar-circular')])//parent::span");
        public static By logout = By.XPath("//span[text()='Logout']");
    }

    public class DOMCLASS
    {
        private IWebDriver driver;

        public DOMCLASS(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Wait(int sec,object obj)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)obj));
        }

        public void GoToPage(string URL)
        {      
            driver.Navigate().GoToUrl(URL);
            Wait(20, PageObject.username);
            Thread.Sleep(800);
        }

        public void Username(string Username)
        {
            driver.FindElement(PageObject.username).SendKeys(Username);
        }

        public void Password(string Password)
        {
            driver.FindElement(PageObject.password).SendKeys(Password);
        }

        public void LoginNow()
        {
            driver.FindElement(PageObject.loginnow).Click();
            Wait(20, PageObject.sidebar);

        }

        public void Sidebar()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.sidebar));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void Sourcing()
        {
            driver.FindElement(PageObject.supplier).Click();

            driver.FindElement(PageObject.sourcing).Click();
            Wait(20, PageObject.open);
        }

        public void Open()
        {
            driver.FindElement(PageObject.open).Click();
            Wait(20, PageObject.search);
        }

        public void Search(string rfq)
        {
            driver.FindElement(PageObject.search).SendKeys(rfq);
            Wait(20, PageObject.rfq);
        }

        public void RFQ()
        {
            driver.FindElement(PageObject.rfq).Click();
            Wait(20, PageObject.buyer);
        }

        public void Action()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.action));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Perform();
            element.Click();
            Thread.Sleep(800);

            Wait(20, PageObject.acknowledge);
        }

        public void Acknowledge()
        {
            driver.FindElement(PageObject.acknowledge).Click();

            Wait(20, PageObject.notetobuyer);
        }

        public void Accept_Acknowledge(string notetobuyer)
        {
            driver.FindElement(PageObject.yes).Click();

            driver.FindElement(PageObject.notetobuyer).SendKeys(notetobuyer);

            driver.FindElement(PageObject.submit).Click();

            Wait(20, PageObject.buyer);
        }

        public void Reject_Acknowledge(string notetobuyer)
        {
            driver.FindElement(PageObject.no).Click();

            driver.FindElement(PageObject.notetobuyer).SendKeys(notetobuyer);

            driver.FindElement(PageObject.submit).Click();

            Wait(20, PageObject.buyer);
        }

        public void Create_Quote()
        {
            driver.FindElement(PageObject.createquote).Click();

            Wait(20, PageObject.referneceno);

        }

        public void Reference(string referenceno)
        {
            driver.FindElement(PageObject.referneceno).SendKeys(referenceno);
        }

        public void NoteToBuyer(string notetobuyer)
        {
            driver.FindElement(PageObject.notes_to_buyer).SendKeys(notetobuyer);
        }
        public void Attachments()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.attachments));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void NA_AddAttachment(string title, string type, string file, string category, string description)
        {
            WebDriverWait WAIT = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = WAIT.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.na_add_attachment));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Wait(20,PageObject.na_atc_title);

            driver.FindElement(PageObject.na_atc_title).SendKeys(title);

            new SelectElement(driver.FindElement(PageObject.na_atc_type)).SelectByText(type);

            driver.FindElement(PageObject.na_atc_upload_file).SendKeys(file);

            new SelectElement(driver.FindElement(PageObject.na_atc_category)).SelectByText(category);

            driver.FindElement(PageObject.na_atc_description).SendKeys(description);

            driver.FindElement(PageObject.na_atc_add).Click();
            Wait(20, PageObject.na_add_attachment);
        }

        public void Lines()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.lines));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
            Wait(20, PageObject.lineswait);
        }

        public void Lines_Details()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.lineswait));

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

            for (PageObject.i = 1;PageObject.i <= RowCount; PageObject.i++)
            {


                IWebElement EditLine = driver.FindElement(PageObject.linesedit);
                driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", EditLine);
                EditLine.Click();
                Thread.Sleep(10000);

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.unit_price));

                Random up = new Random();
                int u_p = up.Next(1500, 3000);
                string Unit_Price = Convert.ToString(u_p);

                driver.FindElement(PageObject.unit_price).SendKeys(Unit_Price);
                Thread.Sleep(1000);

                try
                {
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.at));
                    bool AT = driver.FindElement(PageObject.at).Displayed;

                    if (AT == true)
                    {
                        try
                        {
                            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.AT_Table));
                            IWebElement attributetable = driver.FindElement(PageObject.AT_Table);
                            IList<IWebElement> attributetableRows = attributetable.FindElements(By.TagName("tr"));
                            int AttributeRowCount = attributetableRows.Count();
                            Thread.Sleep(3000);

                            for ( PageObject.j = 1; PageObject.j <= AttributeRowCount; PageObject.j++)
                            {
                                driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", attributetable);
                                Thread.Sleep(6000);

                                bool value;
                                try
                                {
                                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.atquotevalue));
                                    value = driver.FindElement(PageObject.atquotevalue).Displayed;
                                }
                                catch (Exception date)
                                {
                                    Console.WriteLine(date.Message);
                                    value = false;
                                }
                                Thread.Sleep(3000);

                                if (value == true)
                                {
                                    Thread.Sleep(3000);

                                    IWebElement atl = driver.FindElement(PageObject.atquotevalue);
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", atl);
                                    Thread.Sleep(3000);
                                    atl.Clear();
                                    Thread.Sleep(1500);

                                    string text1 = driver.FindElement(PageObject.attargetvalue).GetAttribute("innerHTML");
                                    Thread.Sleep(1500);

                                    driver.FindElement(PageObject.atquotevalue).Click();
                                    Thread.Sleep(500);

                                    driver.FindElement(PageObject.atquotevalue).SendKeys(text1);
                                    Thread.Sleep(500);
                                }
                                else
                                {
                                    attributetable = driver.FindElement(PageObject.AT_Table);
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", attributetable);
                                    Thread.Sleep(6000);

                                   PageObject.atquotevalue = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + PageObject.j + "]/td[5]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + PageObject.j + "]/td[5]/div/div/label/div/div/input");

                                    IWebElement atl = driver.FindElement(PageObject.atquotevalue);
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", atl);
                                    Thread.Sleep(3000);

                                    PageObject.attargetvalue = By.XPath("/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + PageObject.j + "]/td[6]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + PageObject.j + "]/td[6]/div/div/label/div/div/input");
                                    string text1 = driver.FindElement(PageObject.attargetvalue).GetAttribute("value");
                                    Thread.Sleep(1000);

                                    driver.FindElement(PageObject.atquotevalue).Click();
                                    Thread.Sleep(500);

                                    driver.FindElement(PageObject.atquotevalue).SendKeys(Keys.Control + "a");
                                    driver.FindElement(PageObject.atquotevalue).SendKeys(Keys.Backspace);
                                    Thread.Sleep(1500);

                                    driver.FindElement(PageObject.atquotevalue).SendKeys(text1);
                                    Thread.Sleep(1500);

                                    driver.FindElement(PageObject.atquotevalue).SendKeys(Keys.Enter);
                                    Thread.Sleep(500);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.cft));

                    bool CFT = driver.FindElement(PageObject.cft).Displayed;

                    if (CFT == true)
                    {

                        try
                        {
                            IWebElement cftable = driver.FindElement(PageObject.CF_Table);
                            driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", cftable);
                            Thread.Sleep(3000);
                            IList<IWebElement> cftableRows = cftable.FindElements(By.TagName("tr"));
                            int CFRowCount = cftableRows.Count();

                            for (PageObject.k = 1; PageObject.k <= CFRowCount; PageObject.k++)
                            {
                                IWebElement cfl = driver.FindElement((PageObject.cfquotevalue));
                                driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", cfl);
                                Thread.Sleep(6000);
                                cfl.Clear();

                                string text2 = driver.FindElement(PageObject.cftargetvalue).GetAttribute("value");
                                Thread.Sleep(1000);

                                driver.FindElement((PageObject.cfquotevalue)).Click();
                                Thread.Sleep(500);
                                driver.FindElement((PageObject.cfquotevalue)).SendKeys(text2);
                                Thread.Sleep(1500);
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    try
                    {
                        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                        js.ExecuteScript("window.scrollTo(0, 0)");
                        Thread.Sleep(4000);
                        element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.quote_line_apply));
                        element.Click();
                        Thread.Sleep(6000);

                        driver.Navigate().GoToUrl(driver.Url);
                        Thread.Sleep(8000);
                    }
                    catch (Exception exce)
                    {
                        Console.WriteLine(exce.Message);
                    }

                }
            }
        }

        public void Quote_Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.quote_action));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);
        }

        public void Submit_Quote()
        {
            driver.FindElement(PageObject.submit_quote).Click();
            Thread.Sleep(1500);

            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();

            Thread.Sleep(3500);
        }


        public void LogOut()
        {
            driver.FindElement(PageObject.profileicon).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(PageObject.logout));
            element.Click();
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
    }
}
