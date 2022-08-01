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
    public class Standard_CloseDocumentTest:ReportsGenerationClass
    {
        CloseDocument SCDUT;

        [Test, Order(1)]
        [Category("Standard Document Close Approval")]
        public void Standard_Close_document_Approval()
        {
            SCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                SCDUT.GoToPage("http://localhost:3000/");
                SCDUT.UserName("SMKHUVA");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                SCDUT.Sourcing();
                SCDUT.Quotation();
                SCDUT.Active_Document();
                SCDUT.Active_Doc_Search("STANDARD RFQ CREATION 9 of 20");  //Go to LINE 50
                SCDUT.Document();
                SCDUT.Doc_Action();
                SCDUT.Doc_Standard_Close_Req();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Requested for Document Closure");
                SCDUT.Buyer_Profile();
                SCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged OUt");

                SCDUT.UserName("SHAKTHIVEL");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                SCDUT.Approval();
                SCDUT.Approval_Notification();
                SCDUT.Document_Closure();
                SCDUT.Doc_Close_Search("STANDARD RFQ CREATION 9 of 20");  //Go to line 68
                SCDUT.Doc_Close();
                SCDUT.Approval_Action();
                SCDUT.Approval_Action_Select();
                SCDUT.Approval_Comments("Approved for Closure on "+ time.ToString("dd_MM_yyyy_hh_mm_ss"));
                SCDUT.Approver_Action_Approve();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Document Closure is Approved");
                SCDUT.Approver_Profile();
                SCDUT.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");

                SCDUT.UserName("SMKHUVA");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                SCDUT.Sourcing();
                SCDUT.Quotation();
                SCDUT.Active_Document();
                SCDUT.Active_Doc_Search("STANDARD RFQ CREATION 9 of 20");
                SCDUT.Document();
                SCDUT.Doc_Action();
                SCDUT.Document_Standard_Close();
                SCDUT.Document_Close_Comments("Document is Closed on "+ time.ToString("dd_MM_yyyy_hh_mm_ss"));
                SCDUT.Document_Close_Select();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Document is Closed");
                
                SCDUT.Buyer_Profile();
                SCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

            }
            catch (Exception ex)
            {
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                SCDUT.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Standard Document Close Approval")]
        public void Standard_Close_document()
        {
            SCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                SCDUT.GoToPage("http://localhost:3000/");
                SCDUT.UserName("SMKHUVA");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                SCDUT.Sourcing();
                SCDUT.Quotation();
                SCDUT.Active_Document();
                SCDUT.Active_Doc_Search("STANDARD RFQ CREATION 5 of 20");
                SCDUT.Document();
                SCDUT.Doc_Action();
                SCDUT.Document_Standard_Close();
                SCDUT.Document_Close_Comments("Document is Closed on "+ time.ToString("dd_MM_yyyy_hh_mm_ss"));
                SCDUT.Document_Close_Select();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Document is Closed");
                
                SCDUT.Buyer_Profile();
                SCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

            }
            catch (Exception ex)
            {
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                SCDUT.closeBrowser();
            }
        }

        [Test, Order(3)]
        [Category("Standard Document Close Approval")]
        public void Standard_Reject_the_DocCloseReq()
        {
            SCDUT = new CloseDocument(GetDriver());
            DateTime time = DateTime.Now;

            try
            {
                SCDUT.GoToPage("http://localhost:3000/");
                SCDUT.UserName("SMKHUVA");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                SCDUT.Sourcing();
                SCDUT.Quotation();
                SCDUT.Active_Document();
                SCDUT.Active_Doc_Search("STANDARD RFQ CREATION 8 of 20");  //Go to LINE 50
                SCDUT.Document();
                SCDUT.Doc_Action();
                SCDUT.Doc_Standard_Close_Req();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Requested for Document Closure");
                SCDUT.Buyer_Profile();
                SCDUT.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged OUt");

                SCDUT.UserName("SHAKTHIVEL");
                SCDUT.Password("Atsdxb@2021");
                SCDUT.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                SCDUT.Approval();
                SCDUT.Approval_Notification();
                SCDUT.Document_Closure();
                SCDUT.Doc_Close_Search("STANDARD RFQ CREATION 8 of 20");  //Go to line 68
                SCDUT.Doc_Close();
                SCDUT.Approval_Action();
                SCDUT.Reject_Action_Select();
                SCDUT.Reject_Comments("Please contact our Support Team for Further Information");
                SCDUT.Approver_Action_Reject();
                SCDUT.ErrorValidation();
                _test.Log(Status.Pass, "Document Closure is Rejected");
                SCDUT.Approver_Profile();
                SCDUT.Approver_LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");
            }
            catch (Exception ex)
            {
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                SCDUT.closeBrowser();
            }
        }
    }
}
