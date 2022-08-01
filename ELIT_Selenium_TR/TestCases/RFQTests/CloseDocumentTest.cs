using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Simple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Flexible
{
    [TestFixture]
    public class CloseDocumentTest:ReportsGenerationClass
    {
        CloseDocument FCDUT;
        DateTime time = DateTime.Now;

        [Test, Order(1)]
        [Category("RFQ Document Close Approval")]
        public void RFQ_Close_document_Approval()
        {
            FCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                FCDUT.GoToPage("http://localhost:3000/");
                FCDUT.UserName("ATHANIGA");
                FCDUT.Password("Atsdxb@003");
                FCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                FCDUT.Sourcing();
                FCDUT.Quotation();
                FCDUT.Active_Document();
                FCDUT.Active_Doc_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");  //Go to LINE 50
                FCDUT.Document();
                FCDUT.Doc_Action();
                FCDUT.Doc_Flexible_Close_Req();
                _test.Log(Status.Pass, "Requested for Document Closure");
                FCDUT.Buyer_Profile();
                FCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged OUt");

                FCDUT.UserName("RAMANA.KALLEPALLI");
                FCDUT.Password("Atsdxb@003");
                FCDUT.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                FCDUT.Approval();
                FCDUT.Approval_Notification();
                FCDUT.Document_Closure();
                FCDUT.Doc_Close_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");  //Go to line 68
                FCDUT.Doc_Close();
                FCDUT.Approval_Action();
                FCDUT.Approval_Action_Select();
                FCDUT.Approval_Comments("Approved for Closure on "+ time.ToString("dd_MM_yyyy_hh_mm_ss"));
                FCDUT.Approver_Action_Approve();
                _test.Log(Status.Pass, "Document Closure is Approved");
                FCDUT.Approver_Profile();
                FCDUT.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        FCDUT.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                FCDUT.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("RFQ Document Close Approval")]
        public void RFQ_Close_document()
        {
            FCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                FCDUT.GoToPage("https://dev.elit.ai/");
                FCDUT.UserName("ATHANIGA");
                FCDUT.Password("Atsdxb@003");
                FCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                FCDUT.Sourcing();
                FCDUT.Quotation();
                FCDUT.Active_Document();
                FCDUT.Active_Doc_Search("STANDARD RFQ CREATION 39 of 40 on APR2022");
                FCDUT.Document();
                FCDUT.Doc_Action();
                FCDUT.Document_Flexible_Close();
                FCDUT.Document_Close_Comments("Document is Closed on "+ time.ToString("dd_MM_yyyy_hh_mm_ss"));
                FCDUT.Document_Close_Select();
                _test.Log(Status.Pass, "Document is Closed");
                
                FCDUT.Buyer_Profile();
                FCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        FCDUT.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                FCDUT.closeBrowser();
            }
        }

        [Test, Order(3)]
        [Category("RFQ Document Close Approval")]
        public void RFQ_Close_Doc_rejection()
        {
            FCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                FCDUT.GoToPage("http://localhost:3000/");
                FCDUT.UserName("ATHANIGA");
                FCDUT.Password("Atsdxb@003");
                FCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                FCDUT.Sourcing();
                FCDUT.Quotation();
                FCDUT.Active_Document();
                FCDUT.Active_Doc_Search("FLEXIBLE RFQ CREATION 10 of 40 on JAN2022");  //Go to LINE 50
                FCDUT.Document();
                FCDUT.Doc_Action();
                FCDUT.Doc_Flexible_Close_Req();
                _test.Log(Status.Pass, "Requested for Document Closure");
                FCDUT.Buyer_Profile();
                FCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged OUt");

                FCDUT.UserName("RAMANA.KALLEPALLI");
                FCDUT.Password("Atsdxb@003");
                FCDUT.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                FCDUT.Approval();
                FCDUT.Approval_Notification();
                FCDUT.Document_Closure();
                FCDUT.Doc_Close_Search("FLEXIBLE RFQ CREATION 10 of 40 on JAN2022");  //Go to line 68
                FCDUT.Doc_Close();
                FCDUT.Approval_Action();
                FCDUT.Reject_Action_Select();
                FCDUT.Reject_Comments("Please contact our Support Team for Further Information");
                FCDUT.Approver_Action_Reject();
                _test.Log(Status.Pass, "Document Closure is Rejected");
                FCDUT.Approver_Profile();
                FCDUT.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");
            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        FCDUT.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                FCDUT.closeBrowser();
            }
        }
    }
}
