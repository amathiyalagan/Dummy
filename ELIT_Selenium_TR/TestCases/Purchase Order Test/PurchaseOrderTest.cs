using System;
using System.Collections.Generic;
using System.Linq;
using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Purchase_Order;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System.Text;

namespace ELIT_Selenium_TR.TestCases.Purchase_Order_Test
{
    [TestFixture]
    public class PurchaseOrderTest : ReportsGenerationClass
    {
        PurchaseOrderCreation POC;

        [Test, Order(1)]
        [Category("Purchase Order Creation")]
        public void PurchaseOrderCreationTest()
        {
            try
            { 
                POC = new PurchaseOrderCreation(GetDriver());

                POC.GoToPage("http://localhost:3000/");
                POC.UserName("ATHANIGA");
                POC.Password("Atsdxb@003");
                POC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");

                POC.Orders();
                POC.Purchase_order();
                POC.Create();
                POC.Header_Title("ATS by CVA on D17022022T1000");
                POC.Operating_Unit("Appstec ERP Solutions");
                POC.Order_Type("Standard Purchase Order");
                POC.Supplier("ATS ELIT CORPORATION");
                POC.Supplier_Site("DUBAI");
                POC.Supplier_Contact("Tausif Ahmed");
                POC.Currency_Code("UAE Dirham");
                POC.Notes_To_Approver("Please Approve the Purchase Order");
                POC.Attachment("C:/Users/srchi/OneDrive/Desktop/ELIT-TDL.docx");
                _test.Log(Status.Pass, "Filled Header");
                POC.Terms_Conditions();
                POC.Ship_To_Location("BLR");
                POC.Bill_to_Location("BLR");
                POC.Payment_Terms("10 Net (terms date + 10)");
                POC.Freight_Terms("Due");
                POC.Carrier("Aramex");
                _test.Log(Status.Pass, "Filled Terns and Conditions");
                POC.Lines();
                POC.CL_Goods("Create Line", "Goods", "MBA0001", "100", "1250", "BLR", "17-02-2022", "25-02-2022", "GOODS", "QUANTITY", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt");
                POC.CL_Services("Create Line", "Fixed Price Services", "Computer Accessories and Supplies", "Box of 100", "150", "1000", "BLR", "1000", "990", "1100", "16-02-2022", "25-02-2022", "SERVICES", "AMOUNT", "C:/Users/srchi/Downloads/TimesheetFormat.xlsx");
                POC.Action();
                POC.Preview();
                POC.Submit();
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
                        POC.ErrorValidation();
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
                POC.closeBrowser();
            }
        }
    }
}
