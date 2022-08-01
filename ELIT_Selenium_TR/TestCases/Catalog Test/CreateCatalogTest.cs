using System;
using System.Collections.Generic;
using System.Linq;
using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Catalog;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.CatalogTest
{
    [TestFixture]
    public class CatalogTest : ReportsGenerationClass
    {
        CreateCatalog CC;

        [Test, Order(1)]
        [Category("Catalog with Create Line")]
        public void Catalog()
        {
            CC = new CreateCatalog(GetDriver());

            try
            {
                CC.GoToPage("http://localhost:3000/");
                CC.UserName("ATHANIGA");
                CC.Password("Atsdxb@003");
                CC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                CC.Catalog();
                CC.Select_Catalog();
                _test.Log(Status.Pass, "Catalog Opened");
                CC.Create_Catalog();
                CC.Catalogname("CVA_Catalog0008");
                CC.Supplier_Name("ATS ELIT CORPORATION");
                CC.Operating_Unit("Appstec Technology Services");
                CC.Start_Date("5-Feb-2022");
                CC.End_Date("20-Feb-2022");
                CC.Description("CVA_Catalog0008");
                CC.FileUpload("C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt");
                _test.Log(Status.Pass, "Header Filled");
                CC.Items();
                CC.Create_Items("Create Item", "CVA_Catalog0008_1", "CVA_Catalog0008_1", "Computer Hardware and Peripherals for Microcomputers", "Cables: Printer, Disk, Network, etc.", "10Pack", "10", "CVA_Catalog0008_1", "CVA", "UAE Dirham", "CVA", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c", "20", "Eng", "Approve ASAP", "C:/Users/srchi/OneDrive/Pictures/ATSAWARD.png");
                CC.Create_Items("Create Item", "CVA_Catalog0008_2", "CVA_Catalog0008_2", "Computer Accessories and Supplies", "Braces: Monitor, PC's, CRT's, Desk Top Printers, etc.", "10Pack", "10", "CVA_Catalog0008_2", "CVA", "UAE Dirham", "CVA", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c", "20", "Eng", "Approve ASAP", "C:/Users/srchi/OneDrive/Pictures/ats_banner.png");
                CC.Create_Items("Create Item", "CVA_Catalog0008_3", "CVA_Catalog0008_3", "Computer Accessories and Supplies", "CRT Holders, Cases, Glare Screens, Locks, etc.", "10Pack", "10", "CVA_Catalog0008_3", "CVA", "UAE Dirham", "CVA", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c", "20", "Eng", "Approve ASAP", "C:/Users/srchi/OneDrive/Pictures/Ats.png");
                CC.Create_Items("Create Item", "CVA_Catalog0008_4", "CVA_Catalog0008_4", "Computer Accessories and Supplies", "Keyboard Dust Covers, Key Top Covers, Keyboard Drawers, Wrist Supports, etc.", "10Pack", "10", "CVA_Catalog0008_4", "CVA", "UAE Dirham", "CVA", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c", "20", "Eng", "Approve ASAP", "C:/Users/srchi/OneDrive/Pictures/Sharingan.png");
                _test.Log(Status.Pass, "Line Created");

                CC.Action();
                CC.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");

                CC.Action();
                CC.Submit();
                _test.Log(Status.Pass, "Catalog Submitted Succesfully");

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
                        CC.ErrorValidation();
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
                CC.closeBrowser();
            }
        }

    }
}
