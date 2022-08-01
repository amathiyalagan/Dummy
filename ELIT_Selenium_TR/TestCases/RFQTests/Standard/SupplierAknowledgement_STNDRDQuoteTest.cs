using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Standard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Standard
{
    [TestFixture]

    class SupplierAknowledgement_STNDRDQuoteTest : ReportsGenerationClass
    {

        SupplierAknowledgement_STNDRDQuote SRCA;

        [Test, Order(1)]
        [Category("Standard Supplier Acknowledgement and Quote")]
        public void Accept_Acknowledge_Quote()
        {
            SRCA = new SupplierAknowledgement_STNDRDQuote(GetDriver());

            try
            {
                SRCA.GoToPage("http://localhost:3000/");
                SRCA.UserName("DUQESYCAB@GETAIRMAIL.COM");
                SRCA.Password("Atsdxb@2021");
                SRCA.SignIn();
                _test.Log(Status.Pass, "Supplier Logged In");

                SRCA.Supplier();
                SRCA.Sourcing();
                SRCA.Open();
                SRCA.Open_Search("STANDARD RFQ CREATION 33 of 40 on JAN2022");
                _test.Log(Status.Pass, "Opened RFQ");

                SRCA.Rfq();
                SRCA.Action();
                SRCA.Acknowledge();
                SRCA.AK_Description("Participating");
                SRCA.Aknowledgement_Submit();
                _test.Log(Status.Pass, "Acknowledged the Quote");

                SRCA.Action();
                SRCA.Create_Quote();
                _test.Log(Status.Pass, "Quote Created Successfully");

                SRCA.Reference("STANDARD RFQ CREATION 33 of 40 on JAN2022");
                SRCA.Note_To_Buyer("Please check out our Prices and Material Quality");
                SRCA.Requirements();
                SRCA.Req_Technical();
                SRCA.Req_Technical_QuoteValue();
                SRCA.Req_Commercial();
                SRCA.Req_Commercial_QuoteValue();

                SRCA.Attachments();
                SRCA.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "From Supplier Technical", "Requirement");
                _test.Log(Status.Info, "Attachment for Supplier Technical ");

                SRCA.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "From Supplier Commercial", "Requirement");
                _test.Log(Status.Info, "Attachment for supplier Commercial");

                SRCA.Lines();
                SRCA.Lines_Details();
                _test.Log(Status.Pass, "Details of Lines Updated");

                SRCA.Action();
                SRCA.Submit_Quote();
                _test.Log(Status.Pass, "Quote Submitted");
                SRCA.Profile_logout();
                SRCA.Logout();
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
                        SRCA.ErrorValidation();
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
                SRCA.closeBrowser();
            }
        }

        [Test, Order(2)]
        [Category("Standard Supplier Acknowledgement and Quote")]
        public void Reject_Acknowledge_Quote()
        {
            SRCA = new SupplierAknowledgement_STNDRDQuote(GetDriver());

            try
            {
                SRCA.GoToPage("http://localhost:3000/");
                SRCA.UserName("DUQESYCAB@GETAIRMAIL.COM");
                SRCA.Password("Atsdxb@2021");
                SRCA.SignIn();
                _test.Log(Status.Pass, "Supplier Logged In");

                SRCA.Supplier();
                SRCA.Sourcing();
                SRCA.Open();
                SRCA.Open_Search("STANDARD RFQ CREATION 9 of 40 on JAN2022");
                _test.Log(Status.Pass, "Opened RFQ");

                SRCA.Rfq();
                SRCA.Action();
                SRCA.Acknowledge();
                SRCA.Reject();
                SRCA.AK_Description("Not Participating");
                SRCA.Aknowledgement_Submit();
                _test.Log(Status.Pass, "Acknowledged the Quote as NOT PARTICIPATING");
                SRCA.Profile_logout();
                SRCA.Logout();
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
                        SRCA.ErrorValidation();
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
                SRCA.closeBrowser();
            }
        }
    }
}
