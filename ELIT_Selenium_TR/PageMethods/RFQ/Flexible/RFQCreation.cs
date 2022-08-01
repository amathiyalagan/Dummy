using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Keys = OpenQA.Selenium.Keys;

namespace ELIT_Selenium_TR.PageMethods.RFQ.Simple
{
    public class RFQCreation
    {
        private IWebDriver driver;

        string username = "//input[@type='text']";
        string password = "//input[@type='password']";
        string submit = "//button[text()='Login Now']";

        string sourcing = "//ul[contains(@class,'al-sidebar-list')]/li/div/i[contains(@class,'fa fa-lg fa-cubes')]";
        string quotation = "//span[text()='Quotation']";

        string create = "//span[text()='Create']";
        string header_title = "//label[text()='Title*']/parent::div/div/input";
        string documenttype = "//label[text()='Document Style*']/parent::div/div/select";
        string security = "//label[text()='Security*']/parent::div/div/select";
        string ou = "//label[text()='OU*']/parent::div/div/div/div/div/input";
        string po_type = "//label[text()='PO Type*']/parent::div/div/div/div/div/input";
        string enable_emd = "//span[text()='Enable EMD']";
        string description = "//label[text()='Description*(4000 Character)']/parent::div/div/textarea";

        string t_c = "//div[text()='Terms and Condition']";
        string tc_billtoaddress = "//label[text()='Bill To Address*']/parent::div/div/div/div/div/input";
        string tc_shiptoaddress = "//label[text()='Ship to Address*']/parent::div/div/div/div/div/input";
        string tc_paymentterms = "//label[text()='Payment Terms*']/parent::div/div/div/div/div/input";
        string tc_frightterms = "//label[text()='Freight Terms*']/parent::div/div/div/div/div/input";
        string emd_information = "//div[text()='EMD Information']";
        string emd_amount = "//label[text()='EMD Percent*']/parent::div/div/input";
        string emd_duedate = "//label[text()='EMD Due Date*']/parent::div/div/label/div/div/input";
        string emd_type = "//label[text()='EMD Type*']/parent::div/div/select";
        string emd_description = "//label[text()='EMD Description*(4000 Character)']/parent::div/div/textarea";

        string collaboration_team = "//div[text()='Collaboration Team']";
        string target_date = "(//table)[1]/tbody/tr[1]/td[5]/div/div/label/div/div/input";

        string controls = "//div[text()='Controls']";
        string control_reposition = "//span[contains(text(),'Required Approval for Manual Extend')]";
        string close_date = "//label[text()='Close Date*']/parent::div/div/div/div/input";
        string preview_specifytime = "//label[text()='Preview Date']/parent::div/div/div/label/span[text()='Specify Time']";
        string preview_date = "//label[text()='Preview Date']/parent::div/div/div/div/div/div/div/input";
        string open_specifytime = "//label[text()='Open Date']/parent::div/div/label/span[text()='Specify Time']";
        string open_date = "//label[text()='Open Date']/parent::div/div/div/div/div/div/input";
        string rules_select_lines = "//span[contains(text(),'Allow Supplier to select lines')]";
        string rules_reqfullq = "//span[contains(text(),'Required Full Quantity')]";
        string rules_mars = "//span[contains(text(),'Allow Multiple Active Responses')]";
        string rules_quotewithdrawal = "//span[contains(text(),'Allow Quote Withdrawal')]";
        string rules_manualclose = "//span[contains(text(),'Allow Manual Close')]";
        string rules_manualextend = "//span[contains(text(),'Allow Manual Extend')]";
        string rules_staggered_award = "//span[contains(text(),'Allow Staggered Award')]";
        string rules_publishapproval = "//span[contains(text(),'Required Approval for Publishing')]";
        string rules_manualcloseapproval = "//span[contains(text(),'Required Approval for Manual Close')]";
        string rules_manualextendapproval = "//span[contains(text(),'Required Approval for Manual Extend')]";
        string rules_approvalawarding = "//span[contains(text(),'Required Approval for Awarding')]";

        string notes_attachments = "//div[text()='Notes and Attachments']";
        string na_note_to_supplier = "//label[text()='Notes to Supplier (4000 Character)']/parent::div/div/textarea";
        string na_add_attachment = "//span[text()='Add Attachment']";
        string na_atc_title = "(//label[text()='Title*']/parent::div/div/input[@value=''])";
        string na_atc_type = "(//label[text()='Type*']/parent::div/div/select)";
        string na_atc_upload_file = "//label[text()='Upload File']/parent::div/div/div/input[@type='file']";
        string na_atc_category = "//label[text()='Category*']/parent::div/div/select";
        string na_atc_description = "//label[text()='Description*']/parent::div/div/textarea";
        string na_atc_add = "//span[text()='Add']";

        string lines = "//button[text()='Lines']";
        string lines_displayrank = "//label[text()='Display Rank As*']/parent::div/div/select";
        string lines_ranking = "//label[text()='Ranking*']/parent::div/div/select";
        string lines_costfactors = "//label[text()='Cost Factors*']/parent::div/div/select";
        string linecreate_select = "//span[text()='Action']/ancestor::div/div/select";
        string linecreate_go = "//span[text()='Go']";

        string cl_linetype = "//label[text()='Line Type*']/parent::div/div/div/div/div/input";
        string cl_item = "//label[text()='Item']/parent::div/div/div/div/div/input";
        string cl_quantity = "//label[text()='Quantity*']/parent::div/div/input";
        string cl_stlocation = "//label[text()='Ship to Location*']/parent::div/div/div/div/div/input";
        string cl_needbyfrom = "//label[text()='Need By *']/parent::div/div/label/div/div/input";
        string cl_needbyto = "//label[text()='Need By To*']/parent::div/div/label/div/div/input";

        string cl_Category = "//label[text()='Category*']/parent::div/div/div/div/div/input";
        string cl_UOM = "//label[text()='UOM*']/parent::div/div/div/div/div/input";
        string cl_bestprice = "//label[text()='Best Price']/parent::div/div/input";
        string cl_avgprice = "//label[text()='Average Price']/parent::div/div/input";
        string cl_currentprice = "//label[text()='Current Price']/parent::div/div/input";
        string cl_description = "//label[text()='Description (240 Character)*']/parent::div/div/textarea";

        string LineCreate_apply = "//span[text()='Apply']";

        string supplier = "//button[text()='Supplier']";
        string search_supplier = "//label[text()='Search Supplier']/parent::div/div/div/div/div/input";

        string action = "//span[text()='Action']";
        string preview = "//button[text()='Preview']";
        string publish = "//button[text()='Publish']";
        string publish_description = "//label[text()='Comments*']/parent::div/div/textarea";
        string act_req_for_publish = "//button[text()='Request for Publish']";
        string req_for_publish = "(//span[text()='Request for Publish'])[2]";
        string profile = "(//div[contains(@class, 'MuiAvatar-root')])[1]";
        string logout = "//span[text()='Logout']";


        public RFQCreation(IWebDriver driver)
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
            Thread.Sleep(1500);
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

        public void Create()
        {
            driver.FindElement(By.XPath(create)).Click();
            Thread.Sleep(1500);
        }

        public void Header_Title(string headerTitle)
        {
            driver.FindElement(By.XPath(header_title)).SendKeys(headerTitle);
            Thread.Sleep(500);
        }

        public void Document_Type(string documentType)
        {
            new SelectElement(driver.FindElement(By.XPath(documenttype))).SelectByText(documentType);
            Thread.Sleep(500);
        }

        public void Quote_Style(string quoteStyle)
        {
            new SelectElement(driver.FindElement(By.XPath(documenttype))).SelectByText(quoteStyle);
            Thread.Sleep(500);
        }

        public void Security(string SECURITY)
        {
            new SelectElement(driver.FindElement(By.XPath(security))).SelectByText(SECURITY);
            Thread.Sleep(500);
        }

        public void OU(string ouText)
        {
            driver.FindElement(By.XPath(ou)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(ou)).SendKeys(ouText);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ou)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(ou)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void PO_Type(string poType)
        {
            driver.FindElement(By.XPath(po_type)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(po_type)).SendKeys(poType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(po_type)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(po_type)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Enable_EMD()
        {
            driver.FindElement(By.XPath(enable_emd)).Click();
            Thread.Sleep(500);
        }

        public void Description(string descriptionText)
        {
            driver.FindElement(By.XPath(description)).SendKeys(descriptionText);
            Thread.Sleep(500);
        }


        public void Terms_Conditions()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(t_c)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Bill_to_Address(string billToAddress)
        {
            driver.FindElement(By.XPath(tc_billtoaddress)).Click();
            Thread.Sleep(1500); 

            driver.FindElement(By.XPath(tc_billtoaddress)).SendKeys(billToAddress);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_billtoaddress)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_billtoaddress)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

        }

        public void Ship_To_Address(string shipToAddress)
        {
            driver.FindElement(By.XPath(tc_shiptoaddress)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_shiptoaddress)).SendKeys(shipToAddress);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_shiptoaddress)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_shiptoaddress)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Payment_Terms(string PaymentTerms)
        {
            driver.FindElement(By.XPath(tc_paymentterms)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(PaymentTerms);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_paymentterms)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Freight_Terms(string frightTerms)
        {
            driver.FindElement(By.XPath(tc_frightterms)).Click();
            Thread.Sleep(1500);
            
            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(frightTerms);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(tc_frightterms)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void EMD(string emdAmount, string emdDuedate, string emdType, string emdDescription)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(emd_information)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);

            driver.FindElement(By.XPath(emd_amount)).SendKeys(emdAmount);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(emd_duedate)).SendKeys(emdDuedate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(emd_duedate)).SendKeys(Keys.Enter);
            Thread.Sleep(500);

            new SelectElement(driver.FindElement(By.XPath(emd_type))).SelectByText(emdType);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(emd_description)).SendKeys(emdDescription);
            Thread.Sleep(500);
        }

        public void Collaboration_Team()
        {
            driver.FindElement(By.XPath(collaboration_team)).Click();
            Thread.Sleep(3500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(target_date)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
            Thread.Sleep(1500);
        }

        public void Collaboration_Team_Reposition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(target_date)));


        }

        public void Target_Date(string targetDate)
        {
            driver.FindElement(By.XPath(target_date)).SendKeys(targetDate);
            Thread.Sleep(500);
        }

        public void Add_CollaborationTeam(string ctMember, string ctAccess, string ctTask,string ctTargetDate)
        {
            IWebElement table = driver.FindElement(By.XPath("(//table)[1]/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Collaboration Team is : " + RowCount);
            Console.WriteLine("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/label/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            IWebElement CT_Add = driver.FindElement(By.XPath("(//span[text()='Add New'])"));
            CT_Add.Click();
            Thread.Sleep(1500);

            IWebElement CT_Member = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input"));
            CT_Member.Click();
            Thread.Sleep(1800);
            CT_Member.SendKeys(ctMember);
            Thread.Sleep(1500);
            CT_Member.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            CT_Member.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement CT_Access = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[3]/div/div/select"));
            new SelectElement(CT_Access).SelectByText(ctAccess);
            Thread.Sleep(500);

            IWebElement CT_Task = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[4]/div/div/select"));
           new SelectElement(CT_Task).SelectByText(ctTask);
            Thread.Sleep(800);

            IWebElement CT_TargetDate = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/label/div/div/input"));
            CT_TargetDate.SendKeys(ctTargetDate);
            Thread.Sleep(800);
            CT_TargetDate.SendKeys(Keys.Enter);
            Thread.Sleep(800);
        }

        public void Controls()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(controls)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(500);
        }

        public void Controls_Reposition()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(control_reposition)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Perform();
        }
        public void Controls_PreviewDate(string text)
        {
            driver.FindElement(By.XPath(preview_specifytime)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(preview_date)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(preview_date)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Controls_OpenDate(string text)
        {
            driver.FindElement(By.XPath(open_specifytime)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(open_date)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(open_date)).SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Controls_CloseDate(string text)
        {
            driver.FindElement(By.XPath(close_date)).SendKeys(text);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(close_date)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }

        public void Rules_SelectLines()
        {
            driver.FindElement(By.XPath(rules_select_lines)).Click();
            Thread.Sleep(500);
        }

        public void Rules_ReqFull_quantity()
        {
            driver.FindElement(By.XPath(rules_reqfullq)).Click();
            Thread.Sleep(500);
        }

        public void Rules_MARS()
        {
            driver.FindElement(By.XPath(rules_mars)).Click();
            Thread.Sleep(500);
        }

        public void Rules_QWithdrawal()
        {
            driver.FindElement(By.XPath(rules_quotewithdrawal)).Click();
            Thread.Sleep(500);
        }

        public void Rules_ManualClose()
        {
            driver.FindElement(By.XPath(rules_manualclose)).Click();
            Thread.Sleep(500);
        }

        public void Rules_ManualExtend()
        {
            driver.FindElement(By.XPath(rules_manualextend)).Click();
            Thread.Sleep(500);
        }

        public void Rules_StaggeredAward()
        {
            driver.FindElement(By.XPath(rules_staggered_award)).Click();
            Thread.Sleep(500);
        }

        public void Rules_PublishingApproval()
        {
            driver.FindElement(By.XPath(rules_publishapproval)).Click();
            Thread.Sleep(500);
        }

        public void Rules_ManualCloseApproval()
        {
            driver.FindElement(By.XPath(rules_manualcloseapproval)).Click();
            Thread.Sleep(500);
        }

        public void Rules_ManualExtendApproval()
        {
            driver.FindElement(By.XPath(rules_manualextendapproval)).Click();
            Thread.Sleep(500);
        }

        public void Rules_AwardingApproval()
        {
            driver.FindElement(By.XPath(rules_approvalawarding)).Click();
            Thread.Sleep(500);
        }

        public void Notes_Attachments()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(notes_attachments)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1500);
        }

        public void NA_NotesToBuyer(string naNoteToSupplier)
        {
            driver.FindElement(By.XPath(na_note_to_supplier)).SendKeys(naNoteToSupplier);
            Thread.Sleep(500);
        }

        public void NA_AddAttachment(string naAtcTitle, string naAtcType, string naAtcUploadFile, string naAtcCategory, string naAtcDescription)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
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
            Thread.Sleep(1500);

            new SelectElement(driver.FindElement(By.XPath(na_atc_category))).SelectByText(naAtcCategory);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(na_atc_description)).SendKeys(naAtcDescription);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(na_atc_add)).Click();
            Thread.Sleep(5000);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(na_add_attachment)));
        }

        public void Lines()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(lines)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);
        }

        public void Lines_DisplayRank(string linesDisplayRank)
        {
            new SelectElement(driver.FindElement(By.XPath(lines_displayrank))).SelectByText(linesDisplayRank);
            Thread.Sleep(1500);

        }

        public void Lines_Ranking(string linesRanking)
        {
           new SelectElement(driver.FindElement(By.XPath(lines_ranking))).SelectByText(linesRanking);
           Thread.Sleep(1500);
        }

        public void Lines_CostFactors(string linesCostFactors)
        {
            new SelectElement(driver.FindElement(By.XPath(lines_costfactors))).SelectByText(linesCostFactors);
            Thread.Sleep(1500);
        }

        public void CL_Goods(string linecreate, string clLineType, string clItem, string clQuantity, string clStLocation, string clNeedByFrom, string clNeedByTo)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(linecreate_select)));
            Thread.Sleep(3000);

            new SelectElement(driver.FindElement(By.XPath(linecreate_select))).SelectByText(linecreate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(linecreate_go)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(clLineType);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_item)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_item)).SendKeys(clItem);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_item)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_item)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_quantity)).SendKeys(clQuantity);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(clStLocation);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyfrom)).SendKeys(clNeedByFrom);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyfrom)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyto)).SendKeys(clNeedByTo);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyto)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);
        }
        public void CL_Services(string linecreate, string clLineType, string clCategory, string clUOM, string clQuantity, string clStlocation, string clBestPrice, string clAvgPrice, string clCurrentPrice, string clNeedByFrom, string clNeedByTo)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(linecreate_select)));
            Thread.Sleep(3000);

            new SelectElement(driver.FindElement(By.XPath(linecreate_select))).SelectByText(linecreate);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(linecreate_go)).Click();
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(clLineType);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_linetype)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_Category)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(clCategory);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_Category)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_UOM)).Click();
            Thread.Sleep(800);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(clUOM);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(cl_UOM)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_quantity)).SendKeys(clQuantity);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_stlocation)).SendKeys(clStlocation);
            Thread.Sleep(1000);

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

            driver.FindElement(By.XPath(cl_needbyfrom)).SendKeys(clNeedByFrom);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyfrom)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyto)).SendKeys(clNeedByTo);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_needbyto)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(500);

            driver.FindElement(By.XPath(cl_description)).SendKeys(clLineType + "-" + clCategory + "-" + clUOM);
            Thread.Sleep(500);
        }

        public void Add_Attribute(string aAttribute, string aGroup, string aType, string aValueType, string aTargetValue)
        {
            IWebElement table = driver.FindElement(By.XPath("(//table)[2]/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Thread.Sleep(1000);

            if (RowCount == 1)
            {
                IWebElement tablediv = driver.FindElement(By.XPath("(//table)[2]/tbody/tr"));
                IList<IWebElement> col = table.FindElements(By.TagName("td"));
                int ColCount = col.Count();
                if (ColCount <= 1)
                {
                    RowCount = 0;
                }
            }

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Attribute Table is : " + RowCount);
            Console.WriteLine("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");

            IWebElement C_Add = driver.FindElement(By.XPath("(//span[text()='Add Attribute List'])"));
            C_Add.Click();
            Thread.Sleep(1500);

            IWebElement Attribute = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/input"));
            Attribute.SendKeys(aAttribute);
            Thread.Sleep(1500);

            IWebElement Group = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[2]/div/div/select"));
            new SelectElement(Group).SelectByText(aGroup);
            Thread.Sleep(500);

            IWebElement Type = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[3]/div/div/select"));
            new SelectElement(Type).SelectByText(aType);
            Thread.Sleep(500);

            IWebElement ValueType = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[4]/div/div/select"));
            new SelectElement(ValueType).SelectByText(aValueType);
            Thread.Sleep(500);

            if (aValueType == "Date")
            {
                IWebElement TargetValue = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/label/div/div/input"));
                TargetValue.Click();
                Thread.Sleep(500);
                TargetValue.SendKeys(aTargetValue);
                Thread.Sleep(800);
                TargetValue.SendKeys(Keys.Enter);
                Thread.Sleep(800);
            }
            else
            {
                IWebElement TargetValue = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/input"));
                TargetValue.Click();
                Thread.Sleep(500);
                TargetValue.SendKeys(aTargetValue);
                Thread.Sleep(800);
                TargetValue.SendKeys(Keys.Enter);
                Thread.Sleep(800);
            }


            IWebElement A_CheckBox = driver.FindElement(By.XPath("(//table)[2]/tbody/tr[" + (RowCount + 1) + "]/td[6]/div/div/label/span"));
            A_CheckBox.Click();
            Thread.Sleep(500);

        }

        public void Add_CostFactor(string cfCostfactor, string cfTargetValue)
        {
            IWebElement table = driver.FindElement(By.XPath("(//table)[3]/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of CostFactor Table is : " + RowCount);
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            if (RowCount == 1)
            {
                IWebElement tablediv = driver.FindElement(By.XPath("(//table)[3]/tbody/tr"));
                IList<IWebElement> col = table.FindElements(By.TagName("td"));
                int ColCount = col.Count();
                if (ColCount <= 1)
                {
                    RowCount = 0;
                }
            }
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("(//table)[3]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");


            IWebElement C_Add = driver.FindElement(By.XPath("(//span[text()='Add Cost Factor List'])"));
            C_Add.Click();
            Thread.Sleep(1500);

            IWebElement CostFactor = driver.FindElement(By.XPath("(//table)[3]/tbody/tr[" + (RowCount + 1) + "]/td[1]/div/div/div/div/div/input"));
            CostFactor.SendKeys(cfCostfactor);
            Thread.Sleep(1500);
            CostFactor.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            CostFactor.SendKeys(Keys.Enter);
            Thread.Sleep(800);

            IWebElement TargetValue = driver.FindElement(By.XPath("(//table)[3]/tbody/tr[" + (RowCount + 1) + "]/td[4]/div/div/input"));
            TargetValue.SendKeys(cfTargetValue);
            Thread.Sleep(800);
            TargetValue.SendKeys(Keys.Enter);
            Thread.Sleep(800);

            IWebElement A_CheckBox = driver.FindElement(By.XPath("(//table)[3]/tbody/tr[" + (RowCount + 1) + "]/td[5]/div/div/label/span"));
            A_CheckBox.Click();
            Thread.Sleep(500);

        }


        public void LinesCreate_Apply()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(LineCreate_apply)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
        }


        public void Supplier()
        {
            Thread.Sleep(2500);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(supplier)));
            Actions action = new Actions(driver);
            action.MoveToElement(element).Click().Perform();
            Thread.Sleep(1000);

        }

        public void Supplier(string searchSupplier, string supplierSite, string supplierContact)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("(//table)[1]/tbody")));
            Actions action = new Actions(driver);

            IWebElement table = driver.FindElement(By.XPath("(//table)[1]/tbody"));
            IList<IWebElement> Rows = table.FindElements(By.TagName("tr"));
            int RowCount = Rows.Count();


            if (RowCount == 1)
            {
                IWebElement tablediv = driver.FindElement(By.XPath("(//table)[1]/tbody/tr"));
                IList<IWebElement> col = table.FindElements(By.TagName("td"));
                int ColCount = col.Count();
                if (ColCount <= 1)
                {
                    RowCount = 0;

                }
            }

            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Rows of Supplier Table is : " + RowCount);
            Console.WriteLine("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[2]/div/div/div/div/div/input");
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************************************************");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(search_supplier)).Click();
            Thread.Sleep(2500);

            driver.FindElement(By.XPath(search_supplier)).SendKeys(searchSupplier);
            Thread.Sleep(1500);

            driver.FindElement(By.XPath(search_supplier)).SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            Thread.Sleep(1000);

            driver.FindElement(By.XPath(search_supplier)).SendKeys(OpenQA.Selenium.Keys.Enter);
            Thread.Sleep(1000);

            IWebElement Site = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[2]/div/div/div/div/div/input"));
            action.MoveToElement(Site).Perform();
            Site.Click();
            Thread.Sleep(2000);
            Site.SendKeys(supplierSite);
            Thread.Sleep(1500);
            Site.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            Site.SendKeys(Keys.Enter);
            Thread.Sleep(500);

            IWebElement Contact = driver.FindElement(By.XPath("(//table)[1]/tbody/tr[" + (RowCount + 1) + "]/td[3]/div/div/div/div/div/input"));
            action.MoveToElement(Contact).Perform();
            Contact.Click();
            Thread.Sleep(2000);
            Contact.SendKeys(supplierContact);
            Thread.Sleep(1500);
            Contact.SendKeys(Keys.ArrowDown);
            Thread.Sleep(500);
            Contact.SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }

        public void Action()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(action)));

            driver.FindElement(By.XPath(action)).Click();
            Thread.Sleep(500);
        }

        public void Preview()
        {
            driver.FindElement(By.XPath(preview)).Click();
            Thread.Sleep(2500);
        }

        public void Publish()
        {
            driver.FindElement(By.XPath(publish)).Click();
            Thread.Sleep(2500);
        }

        public void PublishDescription(string publishDescription)
        {
            driver.FindElement(By.XPath(publish_description)).SendKeys(publishDescription);
            Thread.Sleep(500);
        }

        public void ActionReqPublish()
        {
            driver.FindElement(By.XPath(act_req_for_publish)).Click();
            Thread.Sleep(1500);
        }

        public void ReqPublish()
        {
            driver.FindElement(By.XPath(req_for_publish)).Click();
            Thread.Sleep(2500);
        }

        public void LOGOUT()
        {
            driver.FindElement(By.XPath(profile)).Click();
            Thread.Sleep(500);

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
