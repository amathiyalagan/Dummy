using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Raise_Invoice;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Raise_Invoice_Test
{

    [TestFixture]
    public class RaiseInvoiceApprovalTest : ReportsGenerationClass
    {
        RaiseInvoiceApproval RIA;

        [Test, Order(1)]
        [Category("Raise Invoice Approval")]

        public void Approve_Invoice()
        {
            RIA = new RaiseInvoiceApproval(GetDriver());

            try
            {
                RIA.GoToPage("http://localhost:3000/");
                RIA.UserName("sreekanth");
                RIA.Password("Atsdxb@2021");
                RIA.SignIn();
                _test.Log(Status.Pass, "Approver logged in");

                RIA.Approval();
                RIA.Approval_notification();
                RIA.Invoice_Approval();
                _test.Log(Status.Pass, "Opened Shipment Approval");
                RIA.Search("");
                RIA.Select();
                _test.Log(Status.Pass, "Opened Shipment Request");
                RIA.Action();
                RIA.Action_Approve();
                RIA.Comments("");
                RIA.Approve();
                _test.Log(Status.Pass, "Shipment Request Approved");
                RIA.LogOut();
                _test.Log(Status.Pass, "approver Logged Out");
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
                        RIA.ErrorValidation();
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
                RIA.closeBrowser();
            }
        }

        [Test, Order(1)]
        [Category("Raise Invoice Approval")]

        public void Reject_Invoice()
        {
            RIA = new RaiseInvoiceApproval(GetDriver());

            try
            {
                RIA.GoToPage("http://localhost:3000/");
                RIA.UserName("");
                RIA.Password("");
                RIA.SignIn();
                _test.Log(Status.Pass, "Approver logged in");

                RIA.Approval();
                RIA.Approval_notification();
                _test.Log(Status.Pass, "Opened Shipment Approval");
                RIA.Search("");
                RIA.Select();
                _test.Log(Status.Pass, "Opened Shipment Request");
                RIA.Action();
                RIA.Action_Reject();
                RIA.Comments(""); ;
                RIA.Reject();
                _test.Log(Status.Pass, "Shipment Request Rejected");
                RIA.LogOut();
                _test.Log(Status.Pass, "approver Logged Out");
            }
            catch (Exception ex)
            {
                DateTime time = DateTime.Now;
                string fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                string screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                RIA.closeBrowser();
            }
        }
    }
}
