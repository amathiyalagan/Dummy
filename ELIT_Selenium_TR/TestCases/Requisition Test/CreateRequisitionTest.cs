using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Requisition;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Requisition_Test
{
    [TestFixture]
    public class CreateRequisitionTest : ReportsGenerationClass
    {
        CreateRequisition CR;

        [Test,Order(1)]
        [Category("Requisition with Create Line")]

        public void Requisition()
        {
            CR = new CreateRequisition(GetDriver());

            try
            {
                CR.GoToPage("http://localhost:3000/");
                CR.UserName("ATHANIGA");
                CR.Password("Atsdxb@003");
                CR.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                CR.Requisition();
                CR.Select_Requisition();
                _test.Log(Status.Pass, "Opened Requisition");

                CR.Create();
                CR.Title("Catalog_CVA0017");
                CR.Catalog_Type("Non Catalog");
                CR.Requested_by("Azhar, Mr. Mohammed Abdul Fatha");
                CR.Operating_Unit("Appstec ERP Solutions");
                CR.Ship_To_Location("BLR");
                CR.Emergency();
                CR.Note_To_Approver("Approve the PR");
                CR.Description("Catalog_CVA0017");
                CR.Fileupload("C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt");
                _test.Log(Status.Pass, "Requisition Header Filled");

                CR.Lines();
                CR.Create_Line_Services("Create Line", "Fixed Price Services", "SUPPLIES.FACILITIES", "APU Hour", "10", "10", "Mr.Aswath Thaniga", "4-Feb-2022", "YES", "Please Provide ASAP", "C:/Users/srchi/OneDrive/Pictures/ATSAWARD.png", "Information Technology", "BENAKE BOXIMAIL PVT LTD", "BENAKE", "Sinchana gowda", "Please Provide Details ASAP");
                _test.Log(Status.Pass, "Line of Fixed Price Service Type is Created");

                CR.Create_Line_Goods("Create Line", "Goods", "MBA0001", "MISC.MISC", "10Pack", "10", "10", "Mr.Aswath Thaniga", "4-Feb-2022", "YES", "C:/Users/srchi/OneDrive/Pictures/ats_banner.png", "Information Technology", "BENAKE BOXIMAIL PVT LTD", "BENAKE", "Sinchana gowda", "Please Provide Details ASAP");
                _test.Log(Status.Pass, "Line of Goods Type is Created");


                CR.Action();
                CR.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");

                CR.Action();
                CR.Submit();
                _test.Log(Status.Pass, "Requisition Submitted Succesfully");

                CR.LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

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
                        CR.ErrorValidation();
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
                CR.CloseBrowser();
            }
        }
    }
}
