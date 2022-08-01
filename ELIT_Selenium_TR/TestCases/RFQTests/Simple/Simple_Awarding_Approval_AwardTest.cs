using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Simple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Simple
{
    [TestFixture]
   public class Simple_Awarding_Approval_AwardTest : ReportsGenerationClass
   {
        Simple_Awarding_Approval_Award SAPA;

        [Test, Order(1)]
        [Category("Simple Document Award Approval")]
        public void Simple_Award_accept_Approval()
        {
            SAPA = new Simple_Awarding_Approval_Award(GetDriver());

            try
            {
                SAPA.GoToPage("http://localhost:3000/");
                SAPA.UserName("ATHANIGA");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                SAPA.Sourcing();
                SAPA.Quotation();
                SAPA.Closed_Document();
                SAPA.Closed_Document_Search("Simple RFQ creation 30 of 40 on JAN2022");  //Go To line 51
                SAPA.Document();
                SAPA.Doc_Action();
                SAPA.Unlock_Document();
                SAPA.Doc_Action();
                SAPA.Award_Quote();
                SAPA.Award_Lines();
                SAPA.Award_Apply();
                SAPA.Doc_Action();
                SAPA.Req_Award_Approval();
                _test.Log(Status.Pass, "Requested for Award Approval");
                SAPA.Buyer_LogOut();

                SAPA.UserName("RAMANA.KALLEPALLI");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");
                SAPA.Approval();
                SAPA.Approval_Notification();
                SAPA.Document_Award();
                SAPA.Document_Search("Simple RFQ creation 30 of 40 on JAN2022");  //Go To Line 64
                SAPA.Document_AW();
                SAPA.Action();
                SAPA.Approve("Award Request Approved");
                SAPA.Approver_LogOut();

                SAPA.UserName("ATHANIGA");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                SAPA.Sourcing();
                SAPA.Quotation();
                SAPA.Closed_Document();
                SAPA.Closed_Document_Search("Simple RFQ creation 30 of 40 on JAN2022");
                SAPA.Document();
                SAPA.Doc_Action();
                SAPA.Complete_Award();
                _test.Log(Status.Pass, "RFQ Awarding Completed");
                SAPA.Buyer_Logout();
                _test.Log(Status.Pass, "Buyer Logged Out");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    DateTime time = DateTime.Now;
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        SAPA.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                SAPA.closeBrowser();
            }
        }



        [Test, Order(3)]
        [Category("Simple Document Award Approval")]
        public void Simple_Award_Accept()
        {
            SAPA = new Simple_Awarding_Approval_Award(GetDriver());

            try
            {
                SAPA.GoToPage("http://localhost:3000/");
                SAPA.UserName("ATHANIGA");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                SAPA.Sourcing();
                SAPA.Quotation();
                SAPA.Closed_Document();
                SAPA.Closed_Document_Search("RFQ Creation on 25032022 12.39");  
                SAPA.Document();
                SAPA.Doc_Action();
                //SAPA.Unlock_Dcoument();
                //SAPA.Doc_Action();
                SAPA.Award_Quote();
                SAPA.Award_Lines();
                SAPA.Award_Apply();
                SAPA.Doc_Action();
                SAPA.Complete_Award();
                _test.Log(Status.Pass, "RFQ Awarding Completed");
                SAPA.Buyer_Logout();
                _test.Log(Status.Pass, "Buyer Logged Out");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    DateTime time = DateTime.Now;
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        SAPA.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                SAPA.closeBrowser();
            }
        }



        [Test, Order(2)]
        [Category("Simple Document Award Approval")]
        public void Simple_Award_Reject_Approval()
        {
            SAPA = new Simple_Awarding_Approval_Award(GetDriver());

            try
            {
                SAPA.GoToPage("http://localhost:3000/");
                SAPA.UserName("ATHANIGA");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                SAPA.Sourcing();
                SAPA.Quotation();
                SAPA.Closed_Document();
                SAPA.Closed_Document_Search("Simple RFQ creation 29 of 40 on JAN2022");  //Go To line 51
                SAPA.Document();
                SAPA.Doc_Action();
                SAPA.Unlock_Document();
                SAPA.Doc_Action();
                SAPA.Award_Quote();
                SAPA.Simple_Award_Supplier1();
                SAPA.Award_Apply();
                SAPA.Doc_Action();
                SAPA.Req_Award_Approval();
                _test.Log(Status.Pass, "Requested for Award Approval");
                SAPA.Buyer_LogOut();

                SAPA.UserName("RAMANA.KALLEPALLI");
                SAPA.Password("Atsdxb@003");
                SAPA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");
                SAPA.Approval();
                SAPA.Approval_Notification();
                SAPA.Document_Award();
                SAPA.Document_Search("Simple RFQ creation 29 of 40 on JAN2022");  //Go To Line 64
                SAPA.Document_AW();
                SAPA.Action();
                SAPA.Reject("Award Request Rejected");
                _test.Log(Status.Pass, "Awarding Request Rejected");

                SAPA.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    DateTime time = DateTime.Now;
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        SAPA.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                SAPA.closeBrowser();
            }
        }
   }
}
