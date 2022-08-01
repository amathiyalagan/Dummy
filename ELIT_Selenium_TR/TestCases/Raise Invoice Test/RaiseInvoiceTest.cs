using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Raise_Invoice;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Raise_Invoice_Test
{
    [TestFixture]

    public class RaiseInvoiceTest : ReportsGenerationClass
    {

        RaiseInvoice RI;

        [Test, Order(1)]
        [Category("Raise Invoice")]
        public void Rasie_Invoice()
        {
            RI = new RaiseInvoice(GetDriver());

            try
            {
                RI.GoToPage("http://localhost:4914/");
                RI.UserName("ATHANIGA@APPSTEC-ME.COM");
                RI.Password("Atsdxb@003");
                RI.SignIn();

                RI.Supplier();
                RI.SupplierProfile();
                RI.PurchaseOrder();
                RI.PO_Search("1116");
                RI.Raise_Invoice();
                RI.Line_Select();
                RI.Create_Invoice("Create Shipment");
                RI.Invoice_Number("");
                RI.Invoice_Date("");
                RI.Invoice_Description("");
                RI.FileUpload("");
                RI.Invoice_Lines();
                RI.Invoice_Lines_Pager();
                RI.Invoice_Lines_Details();
                RI.Action();
                RI.Submit();
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
                        RI.ErrorValidation();
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
                RI.closeBrowser();
            }
        }


    }
}
