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
    public class BankAccountApprovalTest : ReportsGenerationClass
    {
        BankAccountApproval BAP;

        [Test, Order(1)]
        [Category("Bank Account Approval/Rejection")]
        public void Approving_BankAccount()
        {
            BAP = new BankAccountApproval(GetDriver());

            try
            {
                BAP.GoToPage("http://localhost:3000/");
                BAP.UserName("BENAKE@BOXIMAIL.COM");
                BAP.Password("Atsdxb@2021");
                BAP.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");

                BAP.Supplier();
                BAP.SupplierProfile();
                BAP.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                BAP.Bank_Details();
                BAP.BD_Country("india");
                BAP.BD_BankName("State Bank of India");
                BAP.BD_BranchName("Hyderabad");
                BAP.BD_TypeValues("Increase");
                BAP.BD_RFCIdentifier("A9v62d9x4ga");
                BAP.BD_AccountAlternateName("CEFAWRY PVT LTD");
                BAP.BD_ShortName("SBI");
                BAP.BD_ACCNO("963258741045985");
                BAP.BD_Currency("indian");
                BAP.BD_CheckDigit("16");
                BAP.BD_AccountSuffix("00");
                BAP.BD_AccountType("cacc");
                BAP.BD_Description("Account of XATUJO LLC LTD");
                BAP.BD_Startdate("10-feb-2020");   //DD-MMM-YYYY
                BAP.BD_EndDate("17-feb-2026");
                BAP.BD_Contactname("ZAXOK");
                BAP.BD_Phonenumber("8679365101");
                BAP.BD_FaxNumber("96979");
                BAP.BD_Emailaddress("hojub@tafmail.com");
                BAP.BD_Add();
                _test.Log(Status.Pass, "New Bank Details Added");
                BAP.LogOut();

                BAP.UserName("RAMANA.KALLEPALLI");
                BAP.Password("Atsdxb@003");
                BAP.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                BAP.Approval();
                BAP.Approval_Notification();
                BAP.Navigate_Bank_Account();
                BAP.Bank_Account_Search("963258741045985");
                BAP.Select_Bank_Account();
                _test.Log(Status.Pass, "Opened Profile Bank Details");

                BAP.Action();
                BAP.Approve();
                BAP.Comments("Bank Details Approved");
                BAP.Approved();
                _test.Log(Status.Pass, "Bank Details Approved");

                BAP.LogOut();
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
                        BAP.ErrorValidation();
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
                BAP.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Bank Account Approval/Rejection")]
        public void Rejecting_BankAccount()
        {
            BAP = new BankAccountApproval(GetDriver());

            try
            {
                BAP.GoToPage("http://localhost:3000/");
                BAP.UserName("DUQESYCAB@GETAIRMAIL.COM");
                BAP.Password("Atsdxb@2021");
                BAP.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");

                BAP.Supplier();
                BAP.SupplierProfile();
                BAP.Profile();
                _test.Log(Status.Pass, "Supplier Profile Opened");
                BAP.Bank_Details();
                BAP.BD_Country("india");
                BAP.BD_BankName("State");
                BAP.BD_BranchName("Hyderabad");
                BAP.BD_TypeValues("Increase");
                BAP.BD_RFCIdentifier("A9v62d9x4ga");
                BAP.BD_AccountAlternateName("CEFAWRY PVT LTD");
                BAP.BD_ShortName("SBI");
                BAP.BD_ACCNO("8489549512658952");
                BAP.BD_Currency("indian");
                BAP.BD_CheckDigit("16");
                BAP.BD_AccountSuffix("00");
                BAP.BD_AccountType("cacc");
                BAP.BD_Description("Account of XATUJO LLC LTD");
                BAP.BD_Startdate("10-feb-2020");   //DD-MMM-YYYY
                BAP.BD_EndDate("17-feb-2026");
                BAP.BD_Contactname("ZAXOK");
                BAP.BD_Phonenumber("8679365101");
                BAP.BD_FaxNumber("96979");
                BAP.BD_Emailaddress("CEFAWYRY@TAFMAIL.COM");
                BAP.BD_Add();
                _test.Log(Status.Pass, "New Bank Details Added");
                BAP.LogOut();
                _test.Log(Status.Pass, "Supplier Logged Out");

                BAP.UserName("RAMANA.KALLEPALLI");
                BAP.Password("Atsdxb@003");
                BAP.SignIn();
                _test.Log(Status.Pass, "Approver Logged in");
                BAP.Approval();
                BAP.Approval_Notification();
                BAP.Navigate_Bank_Account();
                BAP.Bank_Account_Search("8489549512658952");
                BAP.Select_Bank_Account();
                _test.Log(Status.Pass, "Opened Profile Bank Details");

                BAP.Action();
                BAP.Reject();
                BAP.Comments("Profile Address Book Rejected Please Contact Our Support Team");
                BAP.Rejected();
                _test.Log(Status.Pass, "Profile Address Book Rejected");

                BAP.LogOut();
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
                BAP.closeBrowser();
            }
        }
    }
}
