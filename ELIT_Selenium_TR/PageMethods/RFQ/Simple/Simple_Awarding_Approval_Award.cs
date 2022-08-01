using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.PageMethods.RFQ.Simple
{
    public class Simple_Awarding_Approval_Award
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string sourcing = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-cubes')]";
        string quotation = "//span[text()='Quotation']";

        string closed_doc = "//div[text()='Closed']";
        string closed_doc_search = "//input[@placeholder='Search']";
        string doc_req_aw = "//table/tbody/tr/td[1]/span";
        string unlock_document = "//button[text()='Unlock Document']";
        string doc_action = "//span[text()='Action']"; 
        string award_quote = "//button[text()='Award Quote']";
        string supplier1_L1 = "(//input[@type='radio'])[1]";
        string supplier1_L2 = "(//input[@type='radio'])[3]";
        string supplier1_L3 = "(//input[@type='radio'])[5]";
        string supplier1_L4 = "(//input[@type='radio'])[7]";


        string award_apply = "//button[contains(.,'Apply')]";
        string req_award_approval = "//button[text()='Request for Award Approval']";

        string doc_Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string doc_logout = "//span[text()='Logout']";

        string approval = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-thumbs-o-up')]";
        string approvalnotification = "//span[text()='Approval Notificat']";

        //string scroll_da = "/html/body/div[1]/div[3]/div[1]/div/div/header/div/div[4]";
        string document_award = "//button[contains(.,'Document Award')]";
        string document_search = "//input[@placeholder='Search']";
        string document_aw = "//table/tbody/tr[1]/td[1]";
        string document_action = "//span[text()='Action']";
        string document_Approve = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Approve')] | //button[text()='Approve']";
        string document_reject = "//div[contains(@class, 'MuiPaper-root')]/ul/li[contains(text(),'Reject')] | //button[text()='Reject']";
        string comments = "//textarea[contains(@class,'react-form')]";
        string document_action_Approve = "//span[text()='Approve']";
        string document_action_Reject = "//span[text()='Reject']";


        string complete_award = "//button[text()='Complete Award']";

        public Simple_Awarding_Approval_Award(IWebDriver driver)
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
            driver.FindElement(By.XPath(submit)).Click();
            Thread.Sleep(1000);
        }
        public void Sourcing()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(sourcing)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);


            driver.FindElement(By.XPath(sourcing + "//parent::div[text()='Sourcing']")).Click();
            Thread.Sleep(1500);
        }

        public void Quotation()
        {
            driver.FindElement(By.XPath(quotation)).Click();
            Thread.Sleep(1500);
        }

        public void Closed_Document()
        {
            driver.FindElement(By.XPath(closed_doc)).Click();
            Thread.Sleep(3500);
        }

        public void Closed_Document_Search(string closedRfqSearch)
        {
            driver.FindElement(By.XPath(closed_doc_search)).SendKeys(closedRfqSearch);
            Thread.Sleep(1000);
        }

        public void Document()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_req_aw)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3500);
        }

        public void Doc_Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_action)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);
        }

        public void Unlock_Document()
        {
            driver.FindElement(By.XPath(unlock_document)).Click();
            Thread.Sleep(4000);
        }

        public void Award_Quote()
        {

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(award_quote)));

            driver.FindElement(By.XPath(award_quote)).Click();
            Thread.Sleep(2500);

             element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//input[@type='radio']//ancestor::tr)[1]/td/div/input")));
            Thread.Sleep(5000);
        }

        public void Award_Lines()
        {
            string lines = "//input[@type='radio']//ancestor::tr";
            IList<IWebElement> Rowcount = driver.FindElements(By.XPath(lines));
            int linescount = Rowcount.Count();

            for (int i = 1; i <= linescount; i++)
            {
                string input = "(//input[@type='radio']//ancestor::tr)[" + i + "]/td/div/input";
                IList<IWebElement> Inputcount = driver.FindElements(By.XPath(input));
                int inputscount = Inputcount.Count();

                if (inputscount == 1)
                {
                    driver.FindElement(By.XPath("(//input[@type='radio']//ancestor::tr)[" + inputscount + "]/td/div/input")).Click();
                }

                if (inputscount > 1)
                {
                    Random op = new Random();
                    int o_p = op.Next(1, inputscount);
                    string input_click = Convert.ToString(o_p);


                    string input_xpath = "((//input[@type='radio']//ancestor::tr)[" + i + "]/td/div/input)[" + input_click + "]";

                    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(input_xpath)));
                    Actions action = new Actions(driver);
                    action.MoveToElement(element).Perform();
                    Thread.Sleep(800);

                    driver.FindElement(By.XPath(input_xpath)).Click();
                    Thread.Sleep(1000);
                }

            }

        }

        public void Simple_Award_Supplier1()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier1_L1)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(supplier1_L1)).Click();
            Thread.Sleep(1000);

            action.MoveToElement(driver.FindElement(By.XPath(supplier1_L2)));
            Thread.Sleep(800);
            driver.FindElement(By.XPath(supplier1_L2)).Click();
            Thread.Sleep(1000);

            action.MoveToElement(driver.FindElement(By.XPath(supplier1_L3)));
            Thread.Sleep(800);
            driver.FindElement(By.XPath(supplier1_L3)).Click();
            Thread.Sleep(1000);

            action.MoveToElement(driver.FindElement(By.XPath(supplier1_L4)));
            Thread.Sleep(800);
            driver.FindElement(By.XPath(supplier1_L4)).Click();
            Thread.Sleep(1000);
        }

        public void Simple_Award_Supplier2()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier1_L2)));

            driver.FindElement(By.XPath(supplier1_L2)).Click();
            Thread.Sleep(1200);
        }

        public void Award_Apply()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(award_apply)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(7000);
        }

        public void Req_Award_Approval()
        {
            driver.FindElement(By.XPath(req_award_approval)).Click();
            Thread.Sleep(2800);
        }

        public void Buyer_LogOut()
        {
            driver.FindElement(By.XPath(doc_Profile)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(doc_logout)).Click();
            Thread.Sleep(1500);
        }

        public void Buyer_Logout()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));

            driver.FindElement(By.XPath(doc_Profile)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(doc_logout)).Click();
            Thread.Sleep(500);
        }

        public void Approval()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(approval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(approval + "//parent::div[text()='Approval']")).Click();
            Thread.Sleep(1000);
        }

        public void Approval_Notification()
        {
            driver.FindElement(By.XPath(approvalnotification)).Click();
            Thread.Sleep(1500);
        }

        public void Document_Award()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(document_award)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(3500);

        }

        public void Document_Search(string documentSearch)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(document_aw)));

            driver.FindElement(By.XPath(document_search)).SendKeys(documentSearch);
            Thread.Sleep(800);
        }

        public void Document_AW()
        {
            driver.FindElement(By.XPath(document_aw)).Click();
            Thread.Sleep(3000);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(document_action)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(800);
        }

        public void Approve(string approveComemnts)
        {
            driver.FindElement(By.XPath(document_Approve)).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(comments)).SendKeys(approveComemnts);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(document_action_Approve)).Click();
            Thread.Sleep(3500);
        }

        public void Reject(string rejectComemnts)
        {
            driver.FindElement(By.XPath(document_reject)).Click();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(comments)).SendKeys(rejectComemnts);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(document_action_Reject)).Click();
            Thread.Sleep(3500);
        }

        public void Approver_LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(doc_logout)).Click();
            Thread.Sleep(500);
        }

        public void Complete_Award()
        {
            driver.FindElement(By.XPath(complete_award)).Click();
            Thread.Sleep(10000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));
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
