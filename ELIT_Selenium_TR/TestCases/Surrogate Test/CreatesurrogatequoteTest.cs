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
    public class Createsurrogatequote : ReportsGenerationClass
    {
        Surrogatequote sq;

        [Test, Order(1)]
        [Category("Surrogatequote Testing")]
        public void Surrogatequote()
        {
            sq = new Surrogatequote(GetDriver());

            try
            {
                sq.GoToPage("https://dev.elit.ai/");
                sq.Username("ATHANIGA");
                sq.Password("Atsdxb@003");
                sq.LoginNow();
                _test.Log(Status.Pass, "Supplier Logged In");
                sq.Sidebar();
                sq.Sourcing();
                sq.Active("5591");
                sq.Action();
                sq.SelectSupplier("TATATIG");
                sq.Acknowleadge("Participate");
                _test.Log(Status.Pass, "Successfully Acknowleadged");
                sq.Createquote();
                sq.Attachments("Tec1", "File", @"C:\Users\ATS003A\Pictures\ELIT-120.png", "From Supplier Miscellaneous", "Technical Document");
                sq.Lines();
                sq.Lines_D();
                sq.Lines_Details();
                sq.Quote_Action();
                sq.Submit_Quote();
                _test.Log(Status.Pass, "Quote Creation has been Done");
                sq.Profile_logout();
                sq.Logout();
                _test.Log(Status.Pass, "Supplier Logged out");




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
                        sq.ErrorValidation();
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
                sq.closeBrowser();

            }

        }

    }
}

            


