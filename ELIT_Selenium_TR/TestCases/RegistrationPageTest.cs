using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases
{
    [TestFixture]
    public class RegistrationPageTest:ReportsGenerationClass
    {
        RegistartionPage registrationpage;

        [Test,Order(1)]
        [Category("New Supplier Registration")]
        public void new_supplier_registration()
        {
            registrationpage = new RegistartionPage(GetDriver());
            try
            {
                registrationpage.GoToPage("http://localhost:3000/");
                registrationpage.Signup();
                _test.Log(Status.Pass, "Clicked on SignUp");

                registrationpage.Agree();
                registrationpage.Companyname("NYSEC BOXIMAIL PVT LTD");
                registrationpage.Licensenumber("NYSEC");
                registrationpage.Establishment_Year("2020");
                registrationpage.Issuedate("20-Jan-2020");
                registrationpage.ExpiryDate("25-Jul-2026");
                registrationpage.FileUpload("C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt");
                _test.Log(Status.Pass, "Company Details and License is Uploaded");

                registrationpage.Title("Mr.");
                registrationpage.FirstName("NYSEC");
                registrationpage.MiddleName("NB");
                registrationpage.LastName("BOXIMAIL");
                registrationpage.EmailAddress("nysec@boximail.com");
                registrationpage.PhoneNumber("7541298698");
                registrationpage.AlternativeNumber("9042575231");
                _test.Log(Status.Pass, "Contact Information filled");

                registrationpage.SubmitClick();
                _test.Log(Status.Pass, "Clicked on Submit");
                registrationpage.LoginPage();
				_test.Log(Status.Pass, "Requested for Registration Approval");

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
                        registrationpage.ErrorValidation();
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
                registrationpage.closeBrowser();
            }

        }

    }
}
