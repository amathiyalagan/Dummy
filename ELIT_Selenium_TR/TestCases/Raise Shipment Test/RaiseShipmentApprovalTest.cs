using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Raise_Shipment;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Raise_Shipment_Test
{
    [TestFixture]
     public class RaiseShipmentApprovalTest :ReportsGenerationClass
    {
        RaiseShipmentApproval RSA;

        [Test, Order(1)]
        [Category("Raise Shipment Approval")]

        public void Approve_Shipment()
        {
            RSA = new RaiseShipmentApproval(GetDriver());

            try
            {
                RSA.GoToPage("http://localhost:3000/");
                RSA.UserName("sreekanth");
                RSA.Password("Atsdxb@2021");
                RSA.SignIn();
                _test.Log(Status.Pass, "Approver logged in");

                RSA.Approval();
                RSA.Approval_notification();
                RSA.Shipment_Approval();
                _test.Log(Status.Pass, "Opened Shipment Approval");
                RSA.Search("");
                RSA.Select();
                _test.Log(Status.Pass, "Opened Shipment Request");
                RSA.Action();
                RSA.Action_Approve();
                RSA.Comments("");
                RSA.Approve();
                _test.Log(Status.Pass, "Shipment Request Approved");
                RSA.LogOut();
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
                        RSA.ErrorValidation();
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
                RSA.closeBrowser();
            }
        }

        [Test, Order(2)]
        [Category("Raise Shipment Approval")]

        public void Reject_Shipment()
        {
            RSA = new RaiseShipmentApproval(GetDriver());

            try
            {
                RSA.GoToPage("http://localhost:3000/");
                RSA.UserName("");
                RSA.Password("");
                RSA.SignIn();
                _test.Log(Status.Pass, "Approver logged in");

                RSA.Approval();
                RSA.Approval_notification();
                _test.Log(Status.Pass, "Opened Shipment Approval");
                RSA.Search("");
                RSA.Select();
                _test.Log(Status.Pass, "Opened Shipment Request");
                RSA.Action();
                RSA.Action_Reject();
                RSA.Comments(""); ;
                RSA.Reject();
                _test.Log(Status.Pass, "Shipment Request Rejected");
                RSA.LogOut();
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
                RSA.closeBrowser();
            }
        }
    }
}
