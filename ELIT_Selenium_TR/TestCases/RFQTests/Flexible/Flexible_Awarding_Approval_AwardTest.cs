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
    public class Flexible_Awarding_Approval_AwardTest:ReportsGenerationClass
    {
        Awarding_Approval_Award AAA;

        [Test, Order(3)]
        [Category("Flexible Document Award Approval")]
        public void Flexible_Accept_Award_Approval()
        {
            AAA = new Awarding_Approval_Award(GetDriver());

            try
            {
                AAA.GoToPage("http://localhost:3000/");
                AAA.UserName("ATHANIGA");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                AAA.Sourcing();
                AAA.Quotation();
                AAA.Closed_Document();
                AAA.Closed_Document_Search("FLEXIBLE RFQ CREATION 12 of 40 on JAN2022");  //Go To line 51
                AAA.Document();
                AAA.Doc_Action();
                AAA.Award_Quote();
                AAA.Award_Lines();
                AAA.Award_Apply();
                _test.Log(Status.Pass, "Lines are awarded");
                AAA.Buyer_Comments();
                AAA.Award_Apply();
                AAA.Doc_Action();
                AAA.Req_Award_Approval();
                _test.Log(Status.Pass, "Requested for Award Approval");
                AAA.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                AAA.UserName("RAMANA.KALLEPALLI");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");
                AAA.Approval();
                AAA.Approval_Notification();
                AAA.Document_Award();
                AAA.Document_Search("FLEXIBLE RFQ CREATION 12 of 40 on JAN2022");  //Go To Line 64
                AAA.Document_AW();
                AAA.Action();
                AAA.Approve("Award Request Approved");
                AAA.Approver_LogOut();

                AAA.UserName("ATHANIGA");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                AAA.Sourcing();
                AAA.Quotation();
                AAA.Closed_Document();
                AAA.Closed_Document_Search("FLEXIBLE RFQ CREATION 12 of 40 on JAN2022");
                AAA.Document();
                AAA.Doc_Action();
                AAA.Complete_Award();
                _test.Log(Status.Pass, "RFQ Awarding Completed");
                AAA.Buyer_Logout();
                _test.Log(Status.Pass, "Buyer Logged Out");


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
                        AAA.ErrorValidation();
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
                AAA.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Flexible Document Award Approval")]
        public void Flexible_RFQ_Award()
        {
            AAA = new Awarding_Approval_Award(GetDriver());

            try
            {
                AAA.GoToPage("http://localhost:3000/");
                AAA.UserName("ATHANIGA");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                AAA.Sourcing();
                AAA.Quotation();
                AAA.Closed_Document();
                AAA.Closed_Document_Search("FLEXIBLE RFQ CREATION 5 of 40 on JAN2022"); //go to line 121
                AAA.Document();
                AAA.Doc_Action();
                AAA.Award_Quote();
                //AAA.Flexible_Award_Line1();
                //AAA.Flexible_Award_Line2();
                //AAA.Flexible_Award_Line3();
                //AAA.Flexible_Award_Line4();
                AAA.Award();
                _test.Log(Status.Pass, "Lines are awarded");

                AAA.Award_Apply();
                AAA.Doc_Action();
                AAA.Complete_Award();
                _test.Log(Status.Pass, "Clicked on Complete Award");
                AAA.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");
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
                        AAA.ErrorValidation();
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
                AAA.closeBrowser();
            }
        }


        [Test, Order(1)]
        [Category("Flexible Document Award Approval")]
        public void Flexible_Reject_Award_Approval()
        {
            AAA = new Awarding_Approval_Award(GetDriver());

            try
            {
                AAA.GoToPage("http://localhost:3000/");
                AAA.UserName("ATHANIGA");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");
                AAA.Sourcing();
                AAA.Quotation();
                AAA.Closed_Document();
                AAA.Closed_Document_Search("FLEXIBLE RFQ CREATION 13 of 40 on JAN2022"); //go to line 121
                AAA.Document();
                AAA.Doc_Action();
                AAA.Award_Quote();
                AAA.Award();
                _test.Log(Status.Pass, "Lines are awarded");
                AAA.Buyer_Comments();
                AAA.Award_Apply();
                AAA.Doc_Action();
                AAA.Req_Award_Approval();
                _test.Log(Status.Pass, "Requested for Award Approval");
                AAA.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                AAA.UserName("RAMANA.KALLEPALLI");
                AAA.Password("Atsdxb@003");
                AAA.SignIn();
                _test.Log(Status.Pass, "Approver Logged In");
                AAA.Approval();
                AAA.Approval_Notification();
                AAA.Document_Award();
                AAA.Document_Search("FLEXIBLE RFQ CREATION 13 of 40 on JAN2022");
                AAA.Document_AW();
                AAA.Action();
                AAA.Reject("Please contact our Support Team for Further Information");
                _test.Log(Status.Pass, "Awarding Request Rejected");
                AAA.Approver_LogOut();
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
                        AAA.ErrorValidation();
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
                AAA.closeBrowser();
            }
        }
    }
}
