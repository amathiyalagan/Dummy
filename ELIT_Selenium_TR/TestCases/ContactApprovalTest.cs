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
    public class ContactApprovalTest : ReportsGenerationClass
    {
        ContactApproval CA;

        [Test, Order(1)]
        [Category("Contact Approval Approval/Rejection")]
        public void Approving_ContactApproval()
        {
            CA = new ContactApproval(GetDriver());

            try
            {
                CA.GoToPage("http://localhost:3000/");
                CA.UserName("ASWATHANN@GMAIL.COM");
                CA.Password("Atsdxb@003");
                CA.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                CA.Supplier();
                CA.SupplierProfile();
                CA.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                CA.Contact_Information();
                CA.CI_Title("Mr.");
                CA.CI_First_Name("Arpitha");
                CA.CI_Middle_Name("Henry");
                CA.CI_last_Name("Paul");
                CA.CI_Email_Address("ribob@boximail.com");  
                CA.CI_Phone_Number("9611041457");
                CA.CI_Alternative_Number("7618942089");
                CA.CI_Fax_Number("509249");
                CA.CI_PositionM("Sales Manager");
                CA.CI_Authorized_Signatory();
                CA.CI_Add();
                _test.Log(Status.Pass, "New Contact Added");

                CA.LogOut();
                _test.Log(Status.Pass, "Supplier Logged Out");

                CA.UserName("RAMANA.KALLEPALLI");
                CA.Password("Atsdxb@003");
                CA.SignIn();
                CA.Approval();
                CA.Approval_Notification();
                _test.Log(Status.Pass, "Clicked on Supplier Contact");
                CA.Navigate_ContactApproval();
                CA.Contact_Search("Arpitha");
                CA.Select_Contact();
                _test.Log(Status.Pass, "Opened Supplier Contact");

                CA.Action();
                CA.Approve();
                CA.Comments("Profile Approved");
                CA.Approved();
                _test.Log(Status.Pass, "Supplier Contact Approved");

                CA.LogOut();
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
                        CA.ErrorValidation();
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
                CA.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Contact Approval Approval/Rejection")]
        public void Rejecting_ContactApproval()
        {
            CA = new ContactApproval(GetDriver());

            try
            {
                CA.GoToPage("http://localhost:3000/");
                CA.UserName("DUQESYCAB@GETAIRMAIL.COM");
                CA.Password("Atsdxb@2021");
                CA.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                CA.Supplier();
                CA.SupplierProfile();
                CA.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                CA.Contact_Information();
                CA.CI_Title("Mr.");
                CA.CI_First_Name("Nikitha");
                CA.CI_Middle_Name("Hary");
                CA.CI_last_Name("Pal");
                CA.CI_Email_Address("hojub@tafmail.com");
                CA.CI_Phone_Number("9611041457");
                CA.CI_Alternative_Number("7618942089");
                CA.CI_Fax_Number("509249");
                CA.CI_PositionM("Sales Manager");
                CA.CI_Authorized_Signatory();
                CA.CI_Add();
                _test.Log(Status.Pass, "New Contact Added");

                CA.LogOut();
                _test.Log(Status.Pass, "Supplier Logged Out");

                CA.UserName("RAMANA.KALLEPALLI");
                CA.Password("Atsdxb@003");
                CA.SignIn();
                CA.Approval();
                CA.Approval_Notification();
                _test.Log(Status.Pass, "Clicked on Supplier Contact");
                CA.Navigate_ContactApproval();
                CA.Contact_Search("Nikitha");
                CA.Select_Contact();
                _test.Log(Status.Pass, "Opened Supplier Contact");

                CA.Action();
                CA.Reject();
                CA.Comments("Contact Rejected Please Contact Our Support Team");
                CA.Rejected();
                _test.Log(Status.Pass, "Supplier Contact Rejected");

                CA.LogOut();
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
                        CA.ErrorValidation();
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
                CA.closeBrowser();
            }
        }
    }
}
