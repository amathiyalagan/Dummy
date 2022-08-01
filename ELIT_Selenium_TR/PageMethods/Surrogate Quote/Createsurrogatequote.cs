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

namespace ELIT_Selenium_TR.PageMethods
{
    public static class CreateSurrogateQuote
    {
        public static By username = By.XPath("//input[@type='text']");
        public static By password = By.XPath("//input[@type='password']");
        public static By loginnow = By.XPath("//button[text()='Login Now']");
        public static By sidebar = By.XPath("//ul[contains(@class,'al-sidebar-list')]/li/div/i");
        public static By Sourcing = By.XPath("//div[text()='Sourcing']");
        public static By Quotation = By.XPath("//span[text()='Quotation']");
        public static By Active = By.XPath("//div[text()='Active']");
        public static By Search = By.XPath("//input[@placeholder='Search']");
        public static By Link = By.XPath("//span[text()='5591']");
        public static By TandC = By.XPath("//div[text()='Terms and Condition']");
        public static By Action = By.XPath("//span[text()='Action']");
        public static By Createsurroquote = By.XPath("//button[text()='Create Surrogate Quote']");
        public static By Supplier = By.XPath("//label[text()='Select Supplier']//parent::div/div/div/div/div/input");
        public static By Surrogatequote = By.XPath("//span[text()='Create Quote']");
        public static By Acknowleadge = By.XPath("//li[text()='Acknowledge Participation']");
        public static By NoteToBuyer = By.XPath("//label[text()='Note to Buyer']//parent::div/textarea");
        public static By Submit = By.XPath("//span[text()='Submit']");
        public static By Createquote = By.XPath("//li[text()='Create Quote']");
        public static By Header = By.XPath("//button[text()='Header']");
        public static By Attachment = By.XPath("//div[text()='Attachments']");
        public static By AddAttachment = By.XPath("//span[text()='Add Attachment']");
        public static By Title = By.XPath("//label[text()='Title*']/parent::div/div/input[@value='']");
        public static By Type = By.XPath("//label[text()='Type*']/parent::div/div/select");
        public static By UploadFile = By.XPath("//label[text()='Upload File']/parent::div/div/div/input[@type='file']");
        public static By Category= By.XPath("//label[text()='Category*']/parent::div/div/select");
        public static By Description = By.XPath("//label[text()='Description*']/parent::div/div/textarea");
        public static By Add = By.XPath("//span[text()='Add']");
        public static By Lines = By.XPath("//button[text()='Lines']");
        public static By unit_price = By.XPath("//button[text()='Lines']");
        public static By quote_action = By.XPath("//span[text()='Action']");
        public static By submit_quote = By.XPath ("//div[contains(@class,MuiPaper-root)]/ul/li[contains(text(),'Submit')]");
        public static By Profile = By.XPath("(//div[contains(@class, 'MuiAvatar-root')])[1]");
        public static By Logout = By.XPath("//span[text()='Logout']");


    }
    public class Surrogatequote
    {
        private IWebDriver driver;

        public Surrogatequote(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Wait(int sec, object obj)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(sec));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible((By)obj));
        }

        public void GoToPage(string URL)
        {
            driver.Navigate().GoToUrl(URL);
            Wait(20, CreateSurrogateQuote.username);
            Thread.Sleep(800);
        }

        public void Username(string Username)
        {
            driver.FindElement(CreateSurrogateQuote.username).SendKeys(Username);
        }

        public void Password(string Password)
        {
            driver.FindElement(CreateSurrogateQuote.password).SendKeys(Password);
        }

        public void LoginNow()
        {
            driver.FindElement(CreateSurrogateQuote.loginnow).Click();
            Wait(20, CreateSurrogateQuote.sidebar);

        }
        public void Sidebar()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.sidebar));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }

        public void Sourcing()
        {
            driver.FindElement(CreateSurrogateQuote.Sourcing).Click();
            Thread.Sleep(500);
            driver.FindElement(CreateSurrogateQuote.Quotation).Click();
            Wait(20, CreateSurrogateQuote.Active);
        }

        public void Active(String search)
        {
            driver.FindElement(CreateSurrogateQuote.Active).Click();
            Thread.Sleep(500);
            driver.FindElement(CreateSurrogateQuote.Search).Click();
            driver.FindElement(CreateSurrogateQuote.Search).SendKeys(search);
            Thread.Sleep(500);
            driver.FindElement(CreateSurrogateQuote.Link).Click();
            Wait(20, CreateSurrogateQuote.TandC);
        }
        public void Action()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Action));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Perform();
            element.Click();
            Thread.Sleep(800);
            Wait(20, CreateSurrogateQuote.Createsurroquote);
            driver.FindElement(CreateSurrogateQuote.Createsurroquote).Click();
        }
        public void SelectSupplier(string name)
        {
            driver.FindElement(CreateSurrogateQuote.Supplier).Click();
            Thread.Sleep(800);
            driver.FindElement(CreateSurrogateQuote.Supplier).SendKeys(Keys.Backspace);
            driver.FindElement(CreateSurrogateQuote.Supplier).SendKeys(name);
            driver.FindElement(CreateSurrogateQuote.Supplier).SendKeys(Keys.ArrowDown);
            driver.FindElement(CreateSurrogateQuote.Supplier).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }
        public void Acknowleadge(string name)
        {
            driver.FindElement(CreateSurrogateQuote.Surrogatequote).Click();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Action));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Perform();
            element.Click();
            Thread.Sleep(800);
            Wait(20, CreateSurrogateQuote.Acknowleadge);
            driver.FindElement(CreateSurrogateQuote.Acknowleadge).Click();
            Thread.Sleep(500);
            driver.FindElement(CreateSurrogateQuote.NoteToBuyer).Click();
            driver.FindElement(CreateSurrogateQuote.NoteToBuyer).SendKeys(name);
            driver.FindElement(CreateSurrogateQuote.Submit).Click();
            Thread.Sleep(500);
        }

        public void Createquote()
        {
            driver.FindElement(CreateSurrogateQuote.Action).Click();
            Thread.Sleep(500);
            driver.FindElement(CreateSurrogateQuote.Createquote).Click();
            Thread.Sleep(500);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Header));

        }

        public void Attachments(string Title,string type,string url,string cate,string des)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,-0)");
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Attachment));
            Actions Action = new Actions(driver);
            Action.MoveToElement(element).Perform();
            element.Click();
            Thread.Sleep(800);
            Wait(20, CreateSurrogateQuote.AddAttachment);
            driver.FindElement(CreateSurrogateQuote.AddAttachment).Click();
            Thread.Sleep(500);

            var title = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Title));
            driver.FindElement(CreateSurrogateQuote.Title).SendKeys(Title);
            Thread.Sleep(500);

            new SelectElement(driver.FindElement(CreateSurrogateQuote.Type)).SelectByText(type);
            Thread.Sleep(500);

            driver.FindElement(CreateSurrogateQuote.UploadFile).SendKeys(url);
            Thread.Sleep(1500);

            new SelectElement(driver.FindElement(CreateSurrogateQuote.Category)).SelectByText(cate);
            Thread.Sleep(500);

            driver.FindElement(CreateSurrogateQuote.Description).SendKeys(des);
            Thread.Sleep(500);

            driver.FindElement(CreateSurrogateQuote.Add).Click();
            Thread.Sleep(3500);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.AddAttachment));

        }

        public void Lines()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Lines));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
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
                IWebElement unit_price = driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[5]/div/div/input"));
                move.MoveToElement(unit_price).Perform();

                Random up = new Random();
                int u_p = up.Next(1500, 3000);
                string Unit_Price = Convert.ToString(u_p);

                unit_price.SendKeys(Unit_Price);
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


                    IWebElement EditLine = driver.FindElement(By.XPath("(//*[name()='svg'][@class='MuiSvgIcon-root editIconTable'])[" + i + "]"));
                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", EditLine);
                    EditLine.Click();
                    Thread.Sleep(5000);

                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.unit_price));

                    Random up = new Random();
                    int u_p = up.Next(1500, 3000);
                    string Unit_Price = Convert.ToString(u_p);

                    driver.FindElement(CreateSurrogateQuote.unit_price).SendKeys(Unit_Price);
                    Thread.Sleep(1000);

                    try
                    {
                        string at = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[2]/tbody/tr[1]/td[2]";
                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(at)));
                        bool AT = driver.FindElement(By.XPath(at)).Displayed;

                        if (AT == true)
                        {
                            try
                            {
                                string AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(AT_Table)));
                                AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                                IWebElement attributetable = driver.FindElement(By.XPath(AT_Table));
                                IList<IWebElement> attributetableRows = attributetable.FindElements(By.TagName("tr"));
                                int AttributeRowCount = attributetableRows.Count();
                                Thread.Sleep(1000);

                                for (int j = 1; j <= AttributeRowCount; j++)
                                {
                                    AT_Table = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody | (//table)[2]/tbody";
                                    attributetable = driver.FindElement(By.XPath(AT_Table));
                                    driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", attributetable);
                                    Thread.Sleep(2000);

                                    string atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/input";
                                    bool value;
                                    try
                                    {
                                        atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/input";
                                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(atquotevalue)));
                                        value = driver.FindElement(By.XPath(atquotevalue)).Displayed;
                                    }
                                    catch (Exception date)
                                    {
                                        Console.WriteLine(date.Message);
                                        value = false;
                                    }
                                    Thread.Sleep(2000);

                                    if (value == true)
                                    {
                                        Thread.Sleep(1000);

                                        IWebElement atl = driver.FindElement(By.XPath(atquotevalue));
                                        driver.ExecuteJavaScript("arguments[0].scrollBy(0,575)", atl);
                                        Thread.Sleep(2000);
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
                                        Thread.Sleep(2000);
                                        atquotevalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[5]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[5]/div/div/label/div/div/input";

                                        IWebElement atl = driver.FindElement(By.XPath(atquotevalue));
                                        driver.ExecuteJavaScript("arguments[0].scrollBy(0,600)", atl);
                                        Thread.Sleep(2000);

                                        string attargetvalue = "/html/body/div[1]/div[3]/div[2]/div[3]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[" + j + "]/td[6]/div/div/label/div/div/input | (//table)[2]/tbody/tr[" + j + "]/td[6]/div/div/label/div/div/input";
                                        string text1 = driver.FindElement(By.XPath(attargetvalue)).GetAttribute("value");
                                        Thread.Sleep(1000);

                                        driver.FindElement(By.XPath(atquotevalue)).Click();
                                        Thread.Sleep(500);

                                        driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Control + "a");
                                        driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Backspace);
                                        Thread.Sleep(1500);

                                        driver.FindElement(By.XPath(atquotevalue)).SendKeys(text1);
                                        Thread.Sleep(1500);

                                        driver.FindElement(By.XPath(atquotevalue)).SendKeys(Keys.Enter);
                                        Thread.Sleep(500);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }

                        string cft = "/html/body/div[1]/div[3]/div[2]/div[4]/div/div[2]/div/div/div[2]/div[2]/div/div/div/table/tbody/tr[1]/td[2] | (//table)[3]/tbody/tr[1]/td[2]";

                        wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(cft)));

                        bool CFT = driver.FindElement(By.XPath(cft)).Displayed;

                        if (CFT == true)
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
                                    Thread.Sleep(3000);
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
                    catch (Exception ex)
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
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.quote_action));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);
        }

        public void Submit_Quote()
        {
            driver.FindElement(CreateSurrogateQuote.submit_quote).Click();
            Thread.Sleep(1500);

            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();

            Thread.Sleep(3500);
        }

        public void Profile_logout()
        {
            Thread.Sleep(2000);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Profile));
            element.Click();
            Thread.Sleep(800);
        }

        public void Logout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(CreateSurrogateQuote.Logout));
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