using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests
{
    [TestFixture]
    public class Extend_DocumentTest : ReportsGenerationClass
    {
        Extend_Document ED;

        [Test, Order(1)]
        [Category("RFQ Extend Approval")]
        public void RFQ_Extend_Document_Approve()
        {
            ED = new Extend_Document(GetDriver());

            try
            {
                ED.GoToPage("http://localhost:3000/");
                ED.UserName("ATHANIGA");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                ED.Sourcing();
                ED.Quotation();
                ED.Active_Document();
                ED.Active_Doc_Search("Simple RFQ creation 15 of 20 on JAN2022");
                ED.Document();
                ED.Doc_Action();
                ED.Doc_Extend_Req();
                _test.Log(Status.Pass, "Requested for Document Extend");
                ED.Buyer_Profile();
                ED.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                ED.UserName("RAMANA.KALLEPALLI");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");

                ED.Approval();
                ED.Approval_Notification();
                ED.Document_Extension();
                ED.Doc_Extension_Search("Simple RFQ creation 15 of 20 on JAN2022");
                ED.Document_Extend();
                ED.Approval_Action();
                ED.Approval_Action_Select();
                ED.Approval_Comments("Approved");
                ED.Approver_Action();
                _test.Log(Status.Pass, "Document Extension Approved");

                ED.Approver_Profile();
                ED.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");

                ED.UserName("ATHANIGA");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                ED.Sourcing();
                ED.Quotation();
                ED.Active_Document();
                ED.Active_Doc_Search("Simple RFQ creation 15 of 20 on JAN2022");
                ED.Document();
                ED.Doc_Action();
                ED.Doc_Extend();
                ED.Doc_Extend_CloseDate("20-02-2022 10:00 AM");
                ED.Extend_Documents();
                _test.Log(Status.Pass, " Document id Extended");

                ED.Buyer_Profile();
                ED.Buyer_LogOut();
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
                        ED.ErrorValidation();
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
                ED.closeBrowser();
            }
        }

        [Test, Order(2)]
        [Category("RFQ Extend Approval")]
        public void RFQ_Extend_Document_Reject()
        {
            ED = new Extend_Document(GetDriver());

            try
            {
                ED.GoToPage("http://localhost:3000/");
                ED.UserName("ATHANIGA");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                ED.Sourcing();
                ED.Quotation();
                ED.Active_Document();
                ED.Active_Doc_Search("Simple RFQ creation 18 of 20 on JAN2022");
                ED.Document();
                ED.Doc_Action();
                ED.Doc_Extend_Req();
                _test.Log(Status.Pass, "Requested for Document Extend");
                ED.Buyer_Profile();
                ED.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                ED.UserName("RAMANA.KALLEPALLI");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");

                ED.Approval();
                ED.Approval_Notification();
                ED.Document_Extension();
                ED.Doc_Extension_Search("Simple RFQ creation 18 of 20 on JAN2022");
                ED.Document_Extend();
                ED.Approval_Action();
                ED.Reject_Action_Select();
                ED.Approval_Comments("Rejected");
                ED.Approver_Action_Reject();
                _test.Log(Status.Pass, "Document Extension Rejected");

                ED.Approver_Profile();
                ED.Approver_LogOut();
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
                        ED.ErrorValidation();
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
                ED.closeBrowser();
            }
        }


        [Test, Order(3)]
        [Category("RFQ Extend Approval")]
        public void RFQ_Extend_Document()
        {
            ED = new Extend_Document(GetDriver());

            try
            {
                ED.GoToPage("http://localhost:3000/");
                ED.UserName("ATHANIGA");
                ED.Password("Atsdxb@003");
                ED.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                ED.Sourcing();
                ED.Quotation();
                ED.Active_Document();
                ED.Active_Doc_Search("Simple RFQ creation 19 of 20 on JAN2022");
                ED.Document();
                ED.Doc_Action();
                ED.Doc_Extend();
                ED.Doc_Extend_CloseDate("22-02-2022 10:00 AM");
                ED.Extend_Documents();
                _test.Log(Status.Pass, "RFQ Document is Extended");

                ED.Buyer_Profile();
                ED.Buyer_LogOut();
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
                        ED.ErrorValidation();
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
                ED.closeBrowser();
            }
        }
    }
}
