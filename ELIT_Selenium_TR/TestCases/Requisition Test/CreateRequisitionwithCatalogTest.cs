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

    public class CreateRequisitionwithCatalogTest : ReportsGenerationClass
    {
        CreateRequisitionwithCatalog CR;

        [Test, Order(1)]
        [Category("Requisition with Import line using Catalog")]

        public void RequisitionwithCatalog()
        {
            CR = new CreateRequisitionwithCatalog(GetDriver());

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
                CR.Title("Catalog_CVA0702_02");
                CR.Catalog_Type("Catalog");
                CR.Requested_by("Azhar, Mr. Mohammed Abdul Fatha");
                CR.Ship_To_Location("BLR");
                CR.Operating_Unit("Appstec ERP Solutions");
                CR.Emergency();
                CR.Note_To_Approver("Approve the PR");
                CR.Description("Catalog_CVA0018");
                CR.Fileupload("C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt");
                _test.Log(Status.Pass, "Requisition Header Filled");

                CR.Lines();
                CR.ImportLineFromCatalog("Import Line From Catalog", "CVA_Catalog0008");
                _test.Log(Status.Pass, "imported Line using Catalog");
                CR.Action();
                CR.Submit();
                _test.Log(Status.Pass, "Requisition Submitted Successfully");
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
