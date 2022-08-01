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
    public class PublishApprovalTest : ReportsGenerationClass
    {
        PublishApproval PA;

        [Test, Order(1)]
        [Category("RFQ Publish Approval")]
        public void Approve_Publish()
        {
            PA = new PublishApproval(GetDriver());

            try
            {
                PA.GoToPage("http://localhost:3000/");
                PA.UserName("RAMANA.KALLEPALLI");
                PA.Password("Atsdxb@003");
                PA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");

                PA.Approval();
                PA.Approval_Notifications();
                PA.Document_Publish();
                _test.Log(Status.Pass, "Selected Document Publish");
                PA.Document_search("STANDARD RFQ CREATION 16 of 40 on JAN2022");   
                PA.Select_RFQ();
                PA.Action();
                PA.Accept_RFQ();
                PA.Comments("Approved");
                PA.Publish_Approval();
                _test.Log(Status.Pass, "RFQ Approved");

                PA.LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");
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
                        PA.ErrorValidation();
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
                PA.closeBrowser();
            }
        }

        [Test, Order(2)]
        [Category("RFQ Publish Approval")]
        public void Reject_Publish()
        {
            PA = new PublishApproval(GetDriver());

            try
            {
                PA.GoToPage("http://localhost:3000/");
                PA.UserName("RAMANA.KALLEPALLI");
                PA.Password("Atsdxb@003");
                PA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");

                PA.Approval();
                PA.Approval_Notifications();
                PA.Document_Publish();
                _test.Log(Status.Pass, "Selected Document Publish");

                PA.Document_search("Simple RFQ creation 20 of 20 on JAN2022");
                PA.Select_RFQ();
                PA.Action();
                PA.Reject_RFQ();
                PA.Comments("RFQ is Rejected Due to Insuffiecient Data, Please Contact Our Support Team");
                PA.Publish_Rejection();
                _test.Log(Status.Pass, "RFQ Rejected");

                PA.LogOut();
                _test.Log(Status.Pass, "Approver Logged Out");
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
                        PA.ErrorValidation();
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
                PA.closeBrowser();
            }
        }
    }
}
