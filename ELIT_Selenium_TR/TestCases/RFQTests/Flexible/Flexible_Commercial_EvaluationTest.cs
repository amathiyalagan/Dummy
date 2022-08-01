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
    public class Flexible_Commercial_EvaluationTest:ReportsGenerationClass
    {

        Commercial_Evaluation CET;

        [Test, Order(1)]
        [Category("Flexible Commercial Evaluation of Suppliers")]
        public void Commercial_Evaluation_Supplier()
        {
            CET = new Commercial_Evaluation(GetDriver());

            try
            {
                CET.GoToPage("http://localhost:3000/");
                CET.UserName("ATHANIGA");
                CET.Password("Atsdxb@003");
                CET.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                CET.Sourcing();
                CET.Quotation();
                CET.Closed_Document();
                CET.Closed_Document_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");  //line no 50
                CET.Document();
                CET.Doc_Action();
                CET.UnLock_Commercial();
                _test.Log(Status.Pass, "Commercial Evaluation Unlocked");
                CET.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                CET.UserName("SIRISHA.SAGI");
                CET.Password("Atsdxb@003");
                CET.SignIn();
                _test.Log(Status.Pass, "Commercial evaluator Logged in");
                CET.Sourcing();
                CET.Quotation();
                CET.Closed_Document();
                CET.Closed_Document_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");
                CET.Document();
                CET.Doc_Action();
                CET.Evaluate_Supplier();
                CET.Commercial_Ratings();
                CET.Comm_Commemts();
                CET.Commercial_Rating_Apply();
                _test.Log(Status.Pass, "Commercial rating is Submitted");
                CET.Comm_Eval_Logout();
                _test.Log(Status.Pass, "commercial evaluator Logged out");
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
                        CET.ErrorValidation();
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
                CET.closeBrowser();
            }
        }
    }
}
