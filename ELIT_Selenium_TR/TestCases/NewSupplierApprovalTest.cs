using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases
{
   [TestFixture]
   public class NewSupplierApprovalTest:ReportsGenerationClass
   {
        NewSupplierApproval NSA;    

        [Test,Order(1)]
        [Category("New Supplier Approvals")]
        public void Approve_New_Supplier()
        {
            NSA = new NewSupplierApproval(GetDriver());

            try
            {
                NSA.GoToPage("http://localhost:3000/");
                NSA.UserName("RAMANA.KALLEPALLI");
                NSA.Password("Atsdxb@003");
                NSA.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");

                NSA.Approval();
                NSA.Approval_Notification();
                NSA.Approval_Type();
                NSA.Approval_Search("DOTEDI GIVMAIL PVT LTD");   //Enter Supplier/Company Name
                NSA.Select_Suppiier();
                _test.Log(Status.Pass, "Opened Supplier Registration request");

                NSA.Action();
                NSA.ApprovalAction();
                NSA.Comments("Approved");
                NSA.Approve_Supplier();
                _test.Log(Status.Pass, "Request Approved");

                NSA.LogOut();
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
                        NSA.ErrorValidation();
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
                NSA.closeBrowser();
            }
        }

        [Test,Order(2)]
        [Category("New Supplier Approvals")]
        public void Reject_New_Supplier()
        {
            NSA = new NewSupplierApproval(GetDriver());

            try
            {
                NSA.GoToPage("http://localhost:3000/");
                NSA.UserName("RAMANA.KALLEPALLI");
                NSA.Password("Atsdxb@003");
                NSA.SignIn();
                _test.Log(Status.Info, "Approver Logged in");

                NSA.Approval();
                NSA.Approval_Notification();
                NSA.Approval_Search("FEQOCA ZETMAIL PVT LTD");   //Enter Supplier/Company Name
                NSA.Select_Suppiier();
                _test.Log(Status.Pass, "Opened Supplier Registration request");

                NSA.Action();
                NSA.RejectAction();
                NSA.Comments("Rejected");
                NSA.Reject_Supplier();
                _test.Log(Status.Pass, "Request Rejected");

                NSA.LogOut();
                _test.Log(Status.Pass, "Approver Logged out");

            }
            catch (Exception ex)
            {
               if((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
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
                        NSA.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                    finally
                    {
                        _test.Log(Status.Fail, ex.ToString());
                    }
                }
            }
            finally
            {
                NSA.closeBrowser();
            }
        }
   }
}
