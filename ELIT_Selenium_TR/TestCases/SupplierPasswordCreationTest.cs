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
    public class SupplierPasswordCreationTest:ReportsGenerationClass
    {
        SupplierPasswordCreation SPC;

        [Test,Order(2)]
        [Category("Creating Password For New Supplier")]
        public void Valid_Password_Creation()
        {
            SPC = new SupplierPasswordCreation(GetDriver());

            try
            {
                SPC.GoToPage("https://dev.elit.ai/supplier/register/verification/C3F486AD-EED8-45C7-92F9-5CA550FFADED");
                SPC.Password("Atsdxb@2021");
                _test.Log(Status.Pass, "Password Entered");

                SPC.Reenter_Password("Atsdxb@2021");
                _test.Log(Status.Pass, "Password Re-Entered");

                SPC.Submit_Password();
                _test.Log(Status.Pass, "Clicked on Create Password");
                SPC.Profile();
                SPC.Logout();
                _test.Log(Status.Pass, "Password Created Succesfully");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    DateTime time = DateTime.Now;
                    String fileName = this.GetType().Name+"-"+ time.ToString("dd_MMM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        SPC.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = this.GetType().Name + "-" + time.ToString("dd_MMM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                SPC.closeBrowser();
            }

        }

        [Test,Order(1)]
        [Category("Creating Password For New Supplier")]
        public void InValid_Password_Creation()
        {
            SPC = new SupplierPasswordCreation(GetDriver());

            try
            {
                SPC.GoToPage("https://dev.elit.ai/supplier/register/verification/C3F486AD-EED8-45C7-92F9-5CA550FFADED");
                SPC.Password("Atsdxb@2020");
                _test.Log(Status.Pass, "Password Entered");

                SPC.Reenter_Password("Atsdxb@2021");
                _test.Log(Status.Pass, "Password Re-Entered");

                SPC.Submit_Password();
                _test.Log(Status.Pass, "Clicked on Create Password");
                SPC.Profile();
                SPC.Logout();
                _test.Log(Status.Pass, "Password Created Succesfully");

            }
            catch (Exception ex)
            {
                if ((ex.GetType() == typeof(OpenQA.Selenium.NoSuchElementException) | (ex.GetType() == typeof(OpenQA.Selenium.WebDriverTimeoutException))))
                {
                    DateTime time = DateTime.Now;
                    String fileName = this.GetType().Name + "-" + time.ToString("dd_MMM_yyyy_hh_mm_ss") + ".png";
                    String screenShotPath = Capture(_driver, fileName);
                    _test.Log(Status.Fail, ex.ToString());
                    _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                }
                else
                {
                    try
                    {
                        SPC.ErrorValidation();
                    }
                    catch (Exception innerexception)
                    {
                        DateTime time = DateTime.Now;
                        String fileName = this.GetType().Name + "-" + time.ToString("dd_MMM_yyyy_hh_mm_ss") + ".png";
                        String screenShotPath = Capture(_driver, fileName);
                        _test.Log(Status.Fail, innerexception.ToString());
                        _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
                    }
                }
            }
            finally
            {
                SPC.closeBrowser();
            }

        }

    }
}
