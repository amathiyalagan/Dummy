using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases
{
    [TestFixture]
     public class SupplierProfileApprovalTest:ReportsGenerationClass
     {
        SupplierProfileApproval SPA;

        [Test,Order(1)]
        [Category("Supplier Profile Approval/Rejection")]
        public void Approving_Supplier_Profile()
        {
            SPA = new SupplierProfileApproval(GetDriver());

            try
            {
                SPA.GoToPage("http://localhost:3000/");
                SPA.UserName("RAMANA.KALLEPALLI");
                SPA.Password("Atsdxb@003");
                SPA.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");

                SPA.Approval();
                SPA.Approval_Notification();
                _test.Log(Status.Pass, "Clicked on Supplier Profile");
                SPA.Supplier_Profile();
                SPA.Approval_Search("DOTEDI GIVMAIL PVT LTD");  //enter Supplier/Company Name
                SPA.Select_Profile();

                SPA.Approval_Search("DOTEDI GIVMAIL PVT LTD");  //enter Supplier/Company Name
                SPA.Select_Profile();
                _test.Log(Status.Pass, "Opened Supplier Profile");
                SPA.Action();
                SPA.Approve();
                SPA.Comments("Profile Approved");
                SPA.Approved();
                _test.Log(Status.Pass, "Supplier Profile Approved");

                SPA.LogOut();
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
                        SPA.ErrorValidation();
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
                SPA.closeBrowser();
            }
        }


        [Test,Order(2)]
        [Category("Supplier Profile Approval/Rejection")]
        public void Rejecting_Supplier_Profile()
        {
            SPA = new SupplierProfileApproval(GetDriver());

            try
            {
                SPA.GoToPage("http://localhost:3000/");
                SPA.UserName("RAMANA.KALLEPALLI");
                SPA.Password("Atsdxb@003");
                SPA.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");

                SPA.Approval();
                SPA.Approval_Notification();
                _test.Log(Status.Pass, "Clicked on Supplier Profile");
                SPA.Supplier_Profile();
                SPA.Approval_Search("NYSEC BOXIMAIL PVT LTD");  //enter Supplier/Company Name
                SPA.Select_Profile();

                SPA.Approval_Search("NYSEC BOXIMAIL PVT LTD");  //enter Supplier/Company Name
                SPA.Select_Profile();
                _test.Log(Status.Pass, "Opened Supplier Profile");
                SPA.Action();
                SPA.Reject();
                SPA.Comments("Profile Rejected Please Contact Our Support Team");
                SPA.Rejected();
                _test.Log(Status.Pass, "Supplier Profile Rejected");

                SPA.LogOut();
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
                        SPA.ErrorValidation();
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
                SPA.closeBrowser();
            }
        }
     }
}
