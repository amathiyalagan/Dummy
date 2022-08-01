using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Raise_Shipment;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Raise_Shipment_Test
{
    [TestFixture]

    public class RaiseShipmentTest : ReportsGenerationClass
    {
        RaiseShipment RS;

        [Test, Order(1)]
        [Category("Raise Shipment")]
        public void Rasie_Shipment()
        {
            RS = new RaiseShipment(GetDriver());

            try
            {
                RS.GoToPage("http://localhost:3000/");
                RS.UserName("ATHANIGA@APPSTEC-ME.COM");
                RS.Password("Atsdxb@003");
                RS.SignIn();

                RS.Supplier();
                RS.SupplierProfile();
                RS.PurchaseOrder();
                RS.PO_Search("1116");
                RS.Raise_Shipment();
                RS.Line_Select();
                RS.Create_Shipment("Create Shipment");
                RS.Shipment_Number("");
                RS.Shipment_Date("");
                RS.Expected_Receipt_Date("");
                RS.Number_Of_Container("");
                RS.WayBillNumber("");
                RS.PackingCode("");
                RS.HandlingCode("");
                RS.NetWeight("");
                RS.UOMNetWeight("");
                RS.Comments("");
                RS.FileUpload("");
                RS.Shipment_Lines();
                RS.Shipment_Lines_Pager();
                RS.Shipment_Lines_Details("","","","","","");
                RS.Action();
                RS.Submit();
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
                        RS.ErrorValidation();
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
                RS.closeBrowser();
            }
        }

    }
}
