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
    public class Commercial_Evaluation
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string sourcing = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-cubes')]";
        string quotation = "//span[text()='Quotation']";

        string closed_doc = "//div[text()='Closed']";
        string closed_doc_search = "//input[@placeholder='Search']";
        string doc_eval = "//table/tbody/tr[1]/td[1]/span";
        string doc_action = "//span[text()='Action']";
        string unlock_comm = "//button[text()='Unlock Commercial']";

        string doc_Profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string doc_logout = "//span[text()='Logout']";

        string evaluate_supplier = "//button[text()='Evaluate Supplier']";

        //string flexible_line1_s1_rating = "(//select)[1]";
        //string flexible_line1_s2_rating = "(//select)[2]";
        //string flexible_line2_s1_rating = "(//select)[3]";
        //string flexible_line2_s2_rating = "(//select)[4]";
        //string flexible_line3_s1_rating = "(//select)[5]";
        //string flexible_line3_s2_rating = "(//select)[6]";
        //string flexible_line4_s1_rating = "(//select)[7]";
        //string flexible_line4_s2_rating = "(//select)[8]";

        //string stndrd_Line1_s1_rating = "(//select)[1]";
        //string stndrd_Line1_s2_rating = "(//select)[2]";
        //string stndrd_Line2_s1_rating = "(//select)[3]";
        //string stndrd_Line2_s2_rating = "(//select)[4]";
        //string stndrd_Line3_s1_rating = "(//select)[5]";
        //string stndrd_Line3_s2_rating = "(//select)[6]";
        //string stndrd_Line4_s1_rating = "(//select)[7]";
        //string stndrd_Line4_s2_rating = "(//select)[8]";

        string Comm_comments = "(//input[@type='text'])[2]";

        //string supplier1_rating_select = "/html/body/div[1]/div[3]/div[1]/div/div[3]/div/div/div/div[2]/table/tbody/tr[8]/td[4]/div/select/option[5]";
        //string supplier2_rating_select = "/html/body/div[1]/div[3]/div[1]/div/div[3]/div/div/div/div[2]/table/tbody/tr[8]/td[5]/div/select/option[6]";
        string rating_apply = "//button[contains(span,'Apply')]";
        string com_logout = "//span[text()='Logout']";

        public Commercial_Evaluation(IWebDriver driver)
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
            Thread.Sleep(2500);
        }

        public void Closed_Document_Search(string activeRfqSearch)
        {
            driver.FindElement(By.XPath(closed_doc_search)).SendKeys(activeRfqSearch);
            Thread.Sleep(1000);
        }

        public void Document()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_eval)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2500);
        }

        public void Doc_Action()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_action)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);
        }

        public void UnLock_Commercial()
        {
            driver.FindElement(By.XPath(unlock_comm)).Click();
            Thread.Sleep(4000);


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//label[text()='Buyer']")));
        }

        public void Buyer_LogOut()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(doc_Profile)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(doc_logout)).Click();
            Thread.Sleep(1500);
        }

        public void Evaluate_Supplier()
        {
            driver.FindElement(By.XPath(evaluate_supplier)).Click();
            Thread.Sleep(2000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//select)")));
            Thread.Sleep(1500);
        }

        public void Commercial_Ratings()
        {
            IList<IWebElement> DD = driver.FindElements(By.XPath("(//select)"));
            int DDCount = DD.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Lines Table is : " + DDCount);
            Console.WriteLine("(//select)[" + DDCount + "]");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            for (int i = 1; i <= DDCount; i++)
            {
                Random rnd = new Random();
                int rating = rnd.Next(2, 5);
                Thread.Sleep(800);
                string line_rating = Convert.ToString(rating);
                Thread.Sleep(800);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//select)[" + i + "]")));

                IWebElement LineRating = driver.FindElement(By.XPath("(//select)[" + i + "]"));
                Actions action = new Actions(driver);
                action.MoveToElement(LineRating).Perform();
                Thread.Sleep(1000);
                new SelectElement(LineRating).SelectByText(line_rating);
            }
        }

        public void Comm_Commemts()
        {
            string text = driver.FindElement(By.XPath("//tr[1]/td[@class='textAlignCenter'][1]")).GetAttribute("innerHTML");
            Thread.Sleep(1200);

            driver.FindElement(By.XPath(Comm_comments)).SendKeys(text);
            Thread.Sleep(1000);
        }

        public void Commercial_Rating_Apply()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 0)");
            Thread.Sleep(2000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(rating_apply)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(2000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//select)")));
        }

        public void Comm_Eval_Logout()
        {
            IWebElement LineRating = driver.FindElement(By.XPath(doc_Profile));
            Actions action = new Actions(driver);
            action.MoveToElement(LineRating).Click().Perform();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(com_logout)).Click();
            Thread.Sleep(1500);
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
