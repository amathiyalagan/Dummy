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
    public class AddressBookApprovalTest : ReportsGenerationClass
    {
        AddressBookApproval AB;

        [Test, Order(1)]
        [Category("Address Book Approval/Rejection")]
        public void Approving_AddressBookApproval()
        {
            AB = new AddressBookApproval(GetDriver());

            try
            {
                AB.GoToPage("http://localhost:3000/");
                AB.UserName("BENAKE@BOXIMAIL.COM");
                AB.Password("Atsdxb@2021");
                AB.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");
                AB.Supplier();
                AB.SupplierProfile();
                AB.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                AB.AddressBook();
                AB.AddressBook_Name("SriLatha");
                AB.AddressBook_AlternateName("SriLatha Gowda");
                //AB.AddressBook_CountryM("United Arab Emirates");
                AB.AddressBook_AddressLine1("A-124/1, Shaheed Jeet Singh Marg");
                AB.AddressBook_AddressLine2("Naraina, Block A, Katwaria Sarai");
                AB.AddressBook_City("Dubai");
                AB.AddressBook_StateM("Dubai");
                AB.AddressBook_POBox("56469");
                AB.AddressBook_Email("mysazaki@vomoto.com");
                AB.AddressBook_Phone("7699081001");
                AB.AddressBook_AlternativePhonenumber("8798815489");
                AB.AddressBook_Ordering();
                AB.AddressBook_Add();
                AB.AddressBook();
                _test.Log(Status.Pass, "New Address Book Added and Waiting for Approval");
                AB.LogOut();
                _test.Log(Status.Pass, "Supplier Logged Out");

                AB.UserName("RAMANA.KALLEPALLI");
                AB.Password("Atsdxb@003");
                AB.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                AB.Approval();
                AB.Approval_Notification();
                AB.Navigate_Address_Book();
                AB.Address_Book_Search("SriLatha");
                AB.Select_Address_Book();
                _test.Log(Status.Pass, "Opened Profile Address Book");

                AB.Action();
                AB.Approve();
                AB.Comments("Profile Approved");
                AB.Approved();
                _test.Log(Status.Pass, "Profile Address Book Approved");

                AB.LogOut();
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
                        AB.ErrorValidation();
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
                AB.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Address Book Approval/Rejection")]
        public void Rejecting_AddressBookApproval()
        {
            AB = new AddressBookApproval(GetDriver());

            try
            {
                AB.GoToPage("http://localhost:3000/");
                AB.UserName("DUQESYCAB@GETAIRMAIL.COM");
                AB.Password("Atsdxb@2021");
                AB.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");
                AB.Supplier();
                AB.SupplierProfile();
                AB.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                AB.AddressBook();
                AB.AddressBook_Name("Jyotheesh");
                AB.AddressBook_AlternateName("Jyotheesh Kummara");
                //AB.AddressBook_CountryM("Unite");
                AB.AddressBook_AddressLine1("A-124/1, Shaheed Jeet Singh Marg");
                AB.AddressBook_AddressLine2("Naraina, Block A, Katwaria Sarai");
                AB.AddressBook_City("Dubai");
                AB.AddressBook_StateM("Ras");
                AB.AddressBook_POBox("56468");
                AB.AddressBook_Email("CEFAWYRY@AFMAIL.COM");
                AB.AddressBook_Phone("7699081001");
                AB.AddressBook_AlternativePhonenumber("8798815489");
                AB.AddressBook_Ordering();
                AB.AddressBook_Add();
                AB.AddressBook();
                _test.Log(Status.Pass, "New Address Book Added and Waiting for Approval");
                AB.LogOut();
                _test.Log(Status.Pass, "Supplier Logged Out");

                AB.UserName("RAMANA.KALLEPALLI");
                AB.Password("Atsdxb@003");
                AB.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                AB.Approval();
                AB.Approval_Notification();
                AB.Navigate_Address_Book();
                AB.Address_Book_Search("Jyotheesh");
                AB.Select_Address_Book();
                _test.Log(Status.Pass, "Opened Profile Address Book");

                AB.Action();
                AB.Reject();
                AB.Comments("Address Book Rejected!!!! Please Contact Our Support Team");
                AB.Rejected();
                _test.Log(Status.Pass, "Profile Address Book Rejected");

                AB.LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");

            }
            catch (Exception ex)
            {
                DateTime time = DateTime.Now;
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                AB.closeBrowser();
            }
        }
    }
}
