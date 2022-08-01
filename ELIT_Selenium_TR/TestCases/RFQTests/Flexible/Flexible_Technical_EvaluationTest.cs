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
    public class Flexible_Technical_EvaluationTest:ReportsGenerationClass
    {
        Technical_Evaluation TE;

        [Test, Order(1)]
        [Category("Flexible Technical Evaluation of Suppliers")]
        public void Technical_Evaluation()
        {
            TE = new Technical_Evaluation(GetDriver());

            try
            {
                TE.GoToPage("http://localhost:3000/");
                TE.UserName("ATHANIGA");
                TE.Password("Atsdxb@003");
                TE.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                TE.Sourcing();
                TE.Quotation();
                TE.Closed_Document();
                TE.Closed_Document_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");  //Go to line 50
                TE.Document();
                TE.Doc_Action();
                TE.Unlock_Technical();
                _test.Log(Status.Pass, "Unlocked Technical Evaluation");
                TE.Buyer_Profile();
                TE.Buyer_LogOut();
                _test.Log(Status.Pass, "Buyer Logged Out");

                TE.UserName("RAMANA.KALLEPALLI");
                TE.Password("Atsdxb@003");
                TE.SignIn();
                _test.Log(Status.Pass, "Technical Evaluator Logged in");
                TE.Sourcing();
                TE.Quotation();
                TE.Closed_Document();
                TE.Closed_Document_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022");  //go to line 70
                TE.Evaluate_Doc();
                TE.Doc_Action();
                TE.Evaluate_Supplier();
                TE.Technical_Ratings();
                TE.Tech_Commemts();
                TE.Rating_Apply();
                TE.Approver_Profile();
                TE.Approver_LogOut();
                _test.Log(Status.Pass, "Technical Evaluator Logged Out");

                TE.UserName("ATHANIGA");
                TE.Password("Atsdxb@003");
                TE.SignIn();
                _test.Log(Status.Pass, "Buyer Logged in");
                TE.Sourcing();
                TE.Quotation();
                TE.Closed_Document();
                TE.Closed_Document_Search("FLEXIBLE RFQ CREATION 17 of 40 on JAN2022"); 
                TE.Document();
                TE.Doc_Action();
                TE.Completing_Technical();
                TE.Share_Tech_Rating();
                TE.Completed_Technical();
                _test.Log(Status.Pass, "Technical Evaluation is completed");
                TE.Buyer_Profile();
                TE.Buyer_LogOut();
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
                        TE.ErrorValidation();
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
                TE.closeBrowser();
            }
        }

    }
}
