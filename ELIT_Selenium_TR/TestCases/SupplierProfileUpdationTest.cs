using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ELIT_Selenium_TR.TestCases
{

    [TestFixture]
    public class SupplierProfileUpdationTest : ReportsGenerationClass
    {
        SupplierProfileUpdation spc;

        [Test, Order(1)]
        [Category("Supplier Profile Updation")]
        public void Supplier_Profile_Updation()
        {
            spc = new SupplierProfileUpdation(GetDriver());

            try
            {
                spc.GoToPage("http://localhost:3000/");
                spc.UserName("DUQESYCAB@GETAIRMAIL.COM");
                spc.Password("Atsdxb@2021");
                spc.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");

                spc.Supplier();
                spc.SupplierProfile();
                spc.Profile();
                spc.Financial_Details();
                spc.FD_CEO_Name("ZAXOK");
                spc.FD_Control_YearM("2021");
                spc.FD_Ceo_Title("mr.");
                spc.FD_Total_Employee("400");
                spc.FD_Line_of_Business("construction");
                spc.FD_Financial_Analysis_YearM("2021");
                spc.FD_Fiscal_Year_EndM("april");
                spc.FD_Current_Year_Revenue("2950000");
                spc.FD_Potential_Revenue("3000000");
                spc.FD_Mission_Statement("increasing the current revenue to it's potentiality within short span by using ELIT");
                spc.Financial_Details_Save();
                _test.Log(Status.Pass, "New Financial Details Added");

                spc.Contact_Information();
                spc.CI_Title("Mr.");
                spc.CI_First_Name("ZAXOK");
                spc.CI_Middle_Name("Henry");
                spc.CI_last_Name("Paul");
                spc.CI_Email_Address("gusydukyg@boximail.com");  //diff mail id
                spc.CI_Phone_Number("9611041457");
                spc.CI_Alternative_Number("7618942089");
                spc.CI_Fax_Number("509249");
                spc.CI_PositionM("Sales Manager");
                spc.CI_Authorized_Signatory();
                spc.CI_Add();
                Thread.Sleep(3500);
                _test.Log(Status.Pass, "New Contact Information Added");

                spc.AddressBook();
                spc.AddressBook_Name("ZAXOK");
                spc.AddressBook_AlternateName("ZAXOK Gracer Paul");
                spc.AddressBook_CountryM("Unite");
                spc.AddressBook_AddressLine1("A-124/1, Shaheed Jeet Singh Marg");
                spc.AddressBook_AddressLine2("Naraina, Block A, Katwaria Sarai");
                spc.AddressBook_City("Dubai");
                spc.AddressBook_StateM("Ras");
                spc.AddressBook_POBox("56468");
                spc.AddressBook_Email("gusydukyg@boximail.coms");
                spc.AddressBook_Phone("7699081001");
                spc.AddressBook_AlternativePhonenumber("8798815489");
                spc.AddressBook_Ordering();
                spc.AddressBook_Add();
                spc.AddressBook();
                _test.Log(Status.Pass, "New Address Book Added");

                spc.Products_Services();
                spc.PS_Reposition();
                spc.PS_CategorynameM("Computer Accessories and Supplies");
                spc.PS_SubcategorynameM("Braces: Monitor, PC's, CRT's, Desk Top Printers, etc.");
                spc.PS_SubcategorynameM("CRT Holders, Cases, Glare Screens, Locks, etc.");
                spc.PS_Add();
                spc.Products_Services();
                _test.Log(Status.Pass, "Products and Services Updated");

                spc.Certificate();
                spc.Add_Certificates("Other", "90548932", "Vijayalakshmiagency","2021", "11-Dec-2021", "11-Dec-2023");
                spc.Certificate();
                _test.Log(Status.Pass, "New Certificates of Supplier Added");

                spc.Bank_Details();
                spc.BD_Country("india");
                spc.BD_BankName("State");
                spc.BD_BranchName("Hyderabad");
                spc.BD_TypeValues("Increase");
                spc.BD_RFCIdentifier("A9v62d9x4ga");
                spc.BD_AccountAlternateName("CEFAWRY LLC LTD");
                spc.BD_ShortName("SBI");
                spc.BD_ACCNO("9096141074195652");
                spc.BD_Currency("indian");
                spc.BD_CheckDigit("16");
                spc.BD_AccountSuffix("00");
                spc.BD_AccountType("cacc");
                spc.BD_Description("Account of CEFAWRY PVT LTD");
                spc.BD_Startdate("10-feb-2020");   //DD-MMM-YYYY
                spc.BD_EndDate("17-feb-2026");
                spc.BD_Contactname("ZAXOK");
                spc.BD_Phonenumber("8679365101");
                spc.BD_FaxNumber("96979");
                spc.BD_Emailaddress("gusydukyg@boximail.com");
                spc.BD_Add();
                spc.BD_Reposition();
                _test.Log(Status.Pass, "New Bank Details Added");

                spc.Questionnnaires();

                spc.References();
                spc.Reference_Companyname("ZAMILO Constructions pvt ltd");
                spc.Reference_Country("India");
                spc.Reference_Contactname("Zaxok VOCUR");
                spc.Reference_Emailaddress("viwituxam@abyssmail.com");
                spc.Reference_Phonenumber("8649031790");
                spc.Reference_Alternativenumber("7850731000");
                spc.Reference_Position("Sales Manager");
                spc.Reference_Add();
                _test.Log(Status.Pass, "New References Added");

                spc.Attachments();
                spc.Attachemnt_AddAttachment();
                spc.Attachment_AtcTitle("Bank Document");
                spc.Attachment_DocType("File");
                spc.Attachment_FileBrowseBD("C:\\Users\\srchi\\OneDrive\\Desktop\\ELIT-TDL.docx");  
                spc.Attachment_DocCategoryBD("Bank Document");
                spc.Attachment_Description("Bank Document of CEFAWRY PVT LTD");
                spc.Attachment_DocSubmit();
                _test.Log(Status.Pass, "New Bank Documents Uploaded");

                spc.LogOut();
                Thread.Sleep(2000);
                _test.Log(Status.Pass, "Supplier Logged Out");

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
                        spc.ErrorValidation();
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
                spc.closeBrowser();
            }
        }

    }
}
