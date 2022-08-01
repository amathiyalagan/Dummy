using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases
{
    [TestFixture]
    public class POMCLASSTEST : ReportsGenerationClass
    {
        DOMCLASS DC;

        [Test, Order(1)]
        [Category("POM Testing")]
        public void POM_Testing()
        {
            DC = new DOMCLASS(GetDriver());

            try
            {
                DC.GoToPage("https://dev.elit.ai/");
                DC.Username("BENAKE@BOXIMAIL.COM");
                DC.Password("Atsdxb@2021");
                DC.LoginNow();
                DC.Sidebar();
                DC.Sourcing();
                DC.Open();
                DC.Search("5305");
                DC.RFQ();
                DC.Action();
                DC.Acknowledge();
                DC.Accept_Acknowledge("Participating");
                DC.Action();
                DC.Create_Quote();
                DC.Reference("q1w5e6tr5");
                DC.NoteToBuyer("Quote for Requested Materials");
                DC.Attachments();
                DC.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "From Supplier Miscellaneous", "Requirement");
                DC.Lines();
                DC.Lines_Details();
                DC.Quote_Action();
                DC.Submit_Quote();
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
                        DC.ErrorValidation();
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
                DC.LogOut();
            }
        }
    }
}
