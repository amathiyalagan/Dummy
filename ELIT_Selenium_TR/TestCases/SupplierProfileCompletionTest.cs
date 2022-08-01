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
    public class SupplierProfileCompletionTest:ReportsGenerationClass
    {
        SupplierProfileCompletion spc;

        [Test,Order(1)]
        [Category("Supplier Profile Completion")]
        public void Supplier_Profile_Completion()
        {
            spc = new SupplierProfileCompletion(GetDriver());

            try
            {
                spc.GoToPage("http://localhost:3000/");
                spc.UserName("DOTEDI@GIVMAIL.COM");
                spc.Password("Atsdxb@2021");
                spc.SignIn();
                _test.Log(Status.Pass, "Supplier Logged in");
                spc.Alternative_Name("NYSEC LLC LTD");
                spc.Parent_Company("NYSEC CONSTRUCTIONS PVT LTD");
                spc.Supplier_URL("https://getnada.com/");
                spc.Standard_Industry_Class("CONSTRUCTION");
                spc.TaxPayer_Id("DOTEDI");
                spc.Registration_Type("Limited Liability Company");
                spc.Tax_Registration_Country("United");
                spc.Tax_Registration_Number("DOTEDI");
                spc.Note_To_Buyer("NYSEC Constructions is Parent Company of DOTEDI CONSTRUCTIONS PVT LTD");
                _test.Log(Status.Pass, "Company Information Filled");

                spc.Financial_Details();
                Thread.Sleep(1500);
                spc.FD_CEO_Name("DOTEDI");
                spc.FD_Control_YearM("2021");
                spc.FD_Ceo_Title("mr.");
                spc.FD_Total_Employee("400");
                spc.FD_Line_of_Business("construction");
                spc.FD_Financial_Analysis_YearM("2021");
                spc.FD_Fiscal_Year_EndM("april");
                spc.FD_Current_Year_Revenue("2950000");
                spc.FD_Potential_Revenue("3000000");
                spc.FD_Mission_Statement("increasing the current revenue to it's potentiality within short span");
                spc.Financial_Details_Save();
                Thread.Sleep(3500);
                spc.Financial_Details();
                _test.Log(Status.Pass, "Financial Details Updated");

                spc.Contact_Information();  //Supplier Contact
                spc.CI_Title("Mr.");
                spc.CI_First_Name("Vinay");
                spc.CI_Middle_Name("");
                spc.CI_last_Name("Jadepalli");
                spc.CI_Email_Address("dapac@getnada.com");  //diff mail id
                spc.CI_Phone_Number("9611041457");
                spc.CI_Alternative_Number("7618942089");
                spc.CI_Fax_Number("509249");
                spc.CI_PositionM("Sales Manager");
                spc.CI_Primary_Contact();
                spc.CI_Authorized_Signatory();
                spc.CI_Add();
                Thread.Sleep(3500);
                spc.Contact_Information();
                _test.Log(Status.Pass, "Contact Information Updated");

                spc.AddressBook();
                spc.AddressBook_Name("CTR");  //Supplier Site
                spc.AddressBook_AlternateName("CTR RN");
                spc.AddressBook_CountryM("Unite");
                spc.AddressBook_AddressLine1("A-124/1, Shaheed Jeet Singh Marg");
                spc.AddressBook_AddressLine2("Naraina, Block A, Katwaria Sarai");
                spc.AddressBook_City("Dubai");
                spc.AddressBook_StateM("Ras");
                spc.AddressBook_POBox("56468");
                spc.AddressBook_Email("dapac@getnada.com"); //diff
                spc.AddressBook_Phone("7699081001");
                spc.AddressBook_AlternativePhonenumber("8798815489");
                spc.AddressBook_Ordering();
                spc.AddressBook_Add();
                spc.AddressBook();
                _test.Log(Status.Pass, "Address Book Updated");

                spc.Products_Services();
                spc.PS_Reposition();
                spc.PS_CategorynameM("Computer Hardware and Peripherals for Microcomputers");
                spc.PS_SubcategorynameM("Cables: Printer, Disk, Network, etc.");
                spc.PS_SubcategorynameM("Microcomputers, Desktop or Towerbased");
                spc.PS_Add();
                spc.Products_Services();
                _test.Log(Status.Pass, "Products and Services Updated");

                spc.Certificate();
                spc.Add_Certificates("Other", "90548902", "Vijayalakshmiagency", "2021", "11-Dec-2021", "11-Dec-2023");
                spc.Certificate();
                _test.Log(Status.Pass, "Certificates of Supplier Updated");

                spc.Bank_Details();
                spc.BD_Country("india");
                spc.BD_BankName("State");
                spc.BD_BranchName("Hyderabad");
                spc.BD_TypeValues("Increase");
                spc.BD_RFCIdentifier("A9va2d9x4ga");
                spc.BD_AccountAlternateName("DATODI LLC LTD");
                spc.BD_ShortName("SBI");
                spc.BD_ACCNO("9096141074195652");
                spc.BD_Currency("indian");
                spc.BD_CheckDigit("16");
                spc.BD_AccountSuffix("00");
                spc.BD_AccountType("cacc");
                spc.BD_Description("Account of qefukiwy LLC LTD");
                spc.BD_Startdate("10-feb-2020");   //DD-MMM-YYYY
                spc.BD_EndDate("17-feb-2026");
                spc.BD_Contactname("ZAXOK");
                spc.BD_Phonenumber("8679365101");
                spc.BD_FaxNumber("96979");
                spc.BD_Emailaddress("dapac@getnada.com");
                spc.BD_Add();
                _test.Log(Status.Pass, "Bank Details Updated");

                spc.Questionnaires();
                spc.Questionnaires_reposition();
                spc.Questionnaires_Question1("Yes");
                spc.Questionnaires_Question2("Yes");
                _test.Log(Status.Pass, "Questionnaires Answered");

                spc.References();
                spc.Reference_Companyname("qefukiwy Constructions pvt ltd");
                spc.Reference_Country("India");
                spc.Reference_Contactname("qefukiwy VOCUR");
                spc.Reference_Emailaddress("dapac@getnada.com");
                spc.Reference_Phonenumber("8649031790");
                spc.Reference_Alternativenumber("7850731000");
                spc.Reference_Position("Sales Manager");
                spc.Reference_Add();
                _test.Log(Status.Pass, "References Added");

                spc.Attachments();
                spc.Attachemnt_AddAttachment();
                spc.Attachment_AtcTitle("Bank Document");
                spc.Attachment_DocType("File");
                spc.Attachment_FileBrowseBD("C:\\Users\\srchi\\OneDrive\\Desktop\\ELIT 4001 Testing.pdf");  //File Path should be given in the Method
                spc.Attachment_DocCategoryBD("Bank Document");
                spc.Attachment_Description("Bank Document of NYSEC LLC LTD");
                spc.Attachment_DocSubmit();
                _test.Log(Status.Pass, "Bank Documents Uploaded");

                spc.Attachemnt_AddAttachment();
                spc.Attachment_AtcTitle("Tax Registration");
                spc.Attachment_DocType("File");
                spc.Attachment_FileBrowseTR("C:\\Users\\srchi\\OneDrive\\Desktop\\SupplierDetailsELIT.txt");
                spc.Attachment_DocCategoryTR("Tax Registration");
                spc.Attachment_Description("Tax Registration of NYSEC LLC LTD");
                spc.Attachment_DocSubmit();
                _test.Log(Status.Pass, "Tax Registration Uploaded");

                spc.Profile_Action();
                spc.Profile_Preview();
                Thread.Sleep(6000);
                _test.Log(Status.Pass, "Entered into Profile Preview Mode");

                spc.Profile_Action();
                spc.Profile_Submit();
                Thread.Sleep(6000);
                _test.Log(Status.Pass, "Profile Submitted Successfully");
                spc.Log_Out();
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
