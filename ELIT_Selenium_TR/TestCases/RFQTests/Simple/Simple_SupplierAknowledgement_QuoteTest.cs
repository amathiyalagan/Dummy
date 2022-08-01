using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Simple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Flexible
{
    [TestFixture]
    public class SimpleSupplierAknowledgement_QuoteTest:ReportsGenerationClass
    {

        SupplierAknowledgement_Quote SAQ;

        [Test, Order(1)]
        [Category("Simple Supplier Acknowledgement and Quote")]
        public void Accept_Acknowledge_Quote()
        {
            SAQ = new SupplierAknowledgement_Quote(GetDriver());

            try
            {
                SAQ.GoToPage("http://localhost:3000/");
                SAQ.UserName("BENAKE@BOXIMAIL.COM");
                SAQ.Password("Atsdxb@2021");
                SAQ.SignIn();
                _test.Log(Status.Pass, "Supplier Logged In");

                SAQ.Supplier();
                SAQ.Sourcing();
                SAQ.Open();
                SAQ.Open_Search("Simple RFQ11 by CVA on FEB2022");

                SAQ.Rfq();
                _test.Log(Status.Pass, "Opened RFQ");
                SAQ.Action();
                SAQ.Acknowledge();
                SAQ.AK_Description("Participating");
                SAQ.Aknowledgement_Submit();
                _test.Log(Status.Pass, "Acknowledged the Quote");

                SAQ.Action();
                SAQ.Create_Quote();
                _test.Log(Status.Pass, "Quote Created Successfully");

                SAQ.Reference("Simple RFQ11 by CVA on FEB2022");
                SAQ.Note_To_Buyer("Please check out our Prices and Material Quality");
                //SAQ.Attachments();
                //SAQ.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "From Supplier Miscellaneous", "Requirement");
                //_test.Log(Status.Pass, "Attachment for Technical Internal");

                //SAQ.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "From Supplier Miscellaneous", "Requirement");
                //_test.Log(Status.Pass, "Attachment for Commercial Internal");

                SAQ.Lines();
                SAQ.Lines_Details();
                _test.Log(Status.Pass, "Details of Lines Updated");

                SAQ.Action();
                SAQ.Submit_Quote();
                _test.Log(Status.Pass, "Quote Submitted");

                SAQ.Profile_logout();
                SAQ.Logout();
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
                        SAQ.ErrorValidation();
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
                SAQ.closeBrowser();

            }
        }


        [Test, Order(2)]
        [Category("Simple Supplier Acknowledgement and Quote")]
        public void Reject_Acknowledge_Quote()
        {
            SAQ = new SupplierAknowledgement_Quote(GetDriver());

            try
            {
                SAQ.GoToPage("http://localhost:3000/");
                SAQ.UserName("XAVYHIFEV@ABYSSMAIL.COM");
                SAQ.Password("Atsdxb@2021");
                SAQ.SignIn();
                _test.Log(Status.Pass, "Supplier Logged In");

                SAQ.Supplier();
                SAQ.Sourcing();
                SAQ.Open();
                SAQ.Open_Search("Simple RFQ creation 26 of 40 on JAN2022");
                _test.Log(Status.Pass, "Opened RFQ");

                SAQ.Rfq();
                SAQ.Action();
                SAQ.Acknowledge();
                SAQ.Reject();
                SAQ.AK_Description("Not Participating");
                SAQ.Aknowledgement_Submit();
                _test.Log(Status.Pass, "Acknowledged the Quote");
                SAQ.Profile_logout();
                SAQ.Logout();
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
                        SAQ.ErrorValidation();
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
                SAQ.closeBrowser();

            }
        }
    }
}
