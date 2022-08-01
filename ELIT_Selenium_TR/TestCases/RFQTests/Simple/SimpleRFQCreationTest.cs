using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Simple;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Simple
{
    [TestFixture]
    class SimpleSRCreationTest : ReportsGenerationClass
    {
        SimpleRFQCreation SRC;

        [Test, Order(1)]
        [Category("Simple RFQ Creation")]
        public void Simple_RFQ_Creation()
        {
            SRC = new SimpleRFQCreation(GetDriver());

            try
            {
                SRC.GoToPage("http://localhost:3000/");
                SRC.UserName("ATHANIGA");
                SRC.Password("Atsdxb@003");
                SRC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");

                SRC.Sourcing();
                SRC.Quotation();
                SRC.Create();
                _test.Log(Status.Pass, "Clicked on Create NEW RFQ");

                SRC.Header_Title("Simple RFQ16 by CVA on FEB2022");
                SRC.Document_Type("Simple");  //If Dcoument type is Simple then Quote Style should be called
                SRC.Quote_Style("Sealed");
                SRC.Security("Public");
                SRC.OU("Appstec Technology Services");
                SRC.PO_Type("Standard");
                SRC.Enable_EMD();
                SRC.Description("Simple RFQ16 by CVA on FEB2022");
                _test.Log(Status.Pass, "Filled Header Details of RFQ");

                SRC.Terms_Conditions();
                SRC.Bill_to_Address("BLR");
                SRC.Ship_To_Address("BLR");
                SRC.Payment_Terms("50%");
                SRC.Freight_Terms("AIR");
                SRC.EMD("10", "26-feb-2022", "Bank Guarantee", "Should pay as per Conditions");
                _test.Log(Status.Pass, "Filled Terms and Conditions");

                SRC.Collaboration_Team();
                SRC.Target_Date("26-feb-2022");

                //SRC.Add_CollaborationTeam("Mr.Ramana Kallepalli", "Full", "08-feb-2022");
                //SRC.Add_CollaborationTeam("Ms.Sirisha Sagi", "Full", "08-feb-2022");
                _test.Log(Status.Pass, "Added details of Collaboration Team");

                SRC.Controls();
                SRC.Controls_CloseDate("28-feb-2022");
                SRC.Rules_SelectLines();
                SRC.Rules_ReqFull_quantity();
                SRC.Rules_MARS();
                SRC.Rules_QWithdrawal();
                SRC.Rules_ManualClose();
                SRC.Rules_ManualExtend();
                SRC.Rules_StaggeredAward();
                SRC.Controls();
                _test.Log(Status.Pass, "Controls added Succesfully");

                //SRC.Notes_Attachments();
                //SRC.NA_NotesToBuyer("Required the full quantity in given time");
                //SRC.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "To Supplier", "Requirement");
                //SRC.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "To Internal", "Requirement");
                //_test.Log(Status.Pass, "Attachments added Successfully");

                SRC.Lines();
                SRC.Lines_DisplayRank("Win/Lose");
                SRC.Lines_Ranking("Scoring");
                SRC.Lines_CostFactors("Buyer & Supplier");
                _test.Log(Status.Pass, "Lines added Successfully");

                //Goods Type Line
                SRC.CL_Goods("Create Line", "Goods", "MBA001", "150", "BLR", "01-Mar-2022", "05-Mar-2022");
                _test.Log(Status.Pass, "Line Created Successfully");

                SRC.Add_Attribute("Density", "Durability", "Required", "Number", "6");
                _test.Log(Status.Pass, "Attributes added Successfully");

                SRC.Add_CostFactor("DUTY", "5");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                SRC.CL_Services("Create Line", "Fixed Price Services", "Computer Accessories and Supplies", "Box of 100", "100", "BLR", "1200", "1700", "1600", "01-Mar-2022", "05-Mar-2022");

                SRC.Add_Attribute("Density", "Durability", "Required", "Date", "05-Mar-2022");
                _test.Log(Status.Pass, "Attributes added Successfully");

                SRC.Add_CostFactor("DUTY", "6");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Goods Type Line
                SRC.CL_Goods("Create Line", "Goods", "MBP002", "150", "BLR", "01-Mar-2022", "05-Mar-2022");

                SRC.Add_Attribute("Density", "Durability", "Required", "Text", "7");
                _test.Log(Status.Pass, "Attributes added Successfully");

                SRC.Add_CostFactor("DUTY", "8");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                SRC.CL_Services("Create Line", "Fixed Price Services", "Computer Software for Microcomputers", "Box of 100", "100", "BLR", "1000", "1500", "1400", "01-Mar-2022", "05-Mar-2022");

                SRC.Add_Attribute("Density", "Durability", "Optional", "Text", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c");
                _test.Log(Status.Pass, "Attributes added Successfully");

                SRC.Add_CostFactor("DUTY", "9");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Supplier
                SRC.Supplier();
                SRC.Supplier("BENAKE BOXIMAIL PVT LTD", "BENAKE", "Sinchana gowda");
                SRC.Supplier("DUQESYCAB GETAIRMAIL PVT LTD", "BENAKE", "Jyotheesh Kummara");
                SRC.Supplier("ATS ELIT CORPORATION", "DUBAI", "Tausif Ahmed");
                _test.Log(Status.Pass, "Suppliers added Successfully");

                SRC.Action();
                SRC.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");
                SRC.Action();
                SRC.Publish();
                _test.Log(Status.Pass, "RFQ Published");

                SRC.LOGOUT();
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
                        SRC.ErrorValidation();
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
                SRC.closeBrowser();
            }
        } 
        
        [Test, Order(2)]
        [Category("Simple RFQ Creation")]
        public void Simple_RFQ_Creation_Publish_Approval()
        {
            SRC = new SimpleRFQCreation(GetDriver());

            try
            {
                SRC.GoToPage("http://localhost:3000/");
                SRC.UserName("ATHANIGA");
                SRC.Password("Atsdxb@003");
                SRC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");

                SRC.Sourcing();
                SRC.Quotation();
                SRC.Create();
                _test.Log(Status.Pass, "Clicked on Create NEW RFQ");

                SRC.Header_Title("Simple RFQ creation 30 of 40 on JAN2022");
                SRC.Document_Type("Simple");  //If Dcoument type is Simple then Quote Style should be called
                SRC.Quote_Style("Sealed");
                SRC.Security("Public");
                SRC.OU("Appstec Technology Services");
                SRC.PO_Type("Standard");
                SRC.Enable_EMD();
                SRC.Description("Simple RFQ creation 30 of 40 on JAN2022");
                _test.Log(Status.Pass, "Filled Header Details of RFQ");

                SRC.Terms_Conditions();
                SRC.Bill_to_Address("BLR");
                SRC.Ship_To_Address("BLR");
                SRC.Payment_Terms("50%");
                SRC.Freight_Terms("AIR");
                SRC.EMD("10", "08-feb-2022", "Bank Guarantee", "Should pay as per Conditions");
                _test.Log(Status.Pass, "Filled Terms and Conditions");

                SRC.Collaboration_Team();
                SRC.Target_Date("08-feb-2022");

                //SRC.Add_CollaborationTeam("Mr.Ramana Kallepalli", "Full", "08-feb-2022");
                //SRC.Add_CollaborationTeam("Ms.Sirisha Sagi", "Full", "08-feb-2022");
                _test.Log(Status.Pass, "Added details of Collaboration Team");

                SRC.Controls();
                SRC.Controls_CloseDate("10-feb-2022");
                SRC.Rules_SelectLines();
                SRC.Rules_ReqFull_quantity();
                SRC.Rules_MARS();
                SRC.Rules_QWithdrawal();
                SRC.Rules_ManualClose();
                SRC.Rules_ManualExtend();
                SRC.Rules_StaggeredAward();
                SRC.Rules_PublishingApproval();    //If Wanted to Publish RFQ Document without Approval Comment out this line
                SRC.Rules_ManualCloseApproval();   //If Wanted to Close RFQ Document without Approval Comment out this line
                SRC.Rules_ManualExtendApproval();
                SRC.Rules_AwardingApproval();
                SRC.Controls();
                _test.Log(Status.Pass, "Controls added Succesfully");

                SRC.Notes_Attachments();
                SRC.NA_NotesToBuyer("Required the full quantity in given time");
                SRC.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "To Supplier", "Requirement");
                SRC.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "To Internal", "Requirement");
                _test.Log(Status.Pass, "Attachments added Successfully");

                SRC.Lines();
                SRC.Lines_DisplayRank("Win/Lose");
                SRC.Lines_Ranking("Scoring");
                SRC.Lines_CostFactors("Buyer & Supplier");
                _test.Log(Status.Pass, "Lines added Successfully");

                //Goods Type Line
                SRC.CL_Goods("Create Line", "Goods", "MBA001", "150", "BLR", "10-Feb-2022", "15-Feb-2022");
                _test.Log(Status.Pass, "Line Created Successfully");

                //SRC.Add_Attribute("Density", "Durability", "Required", "Number", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //SRC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                SRC.CL_Services("Create Line", "Fixed Price Services", "MISC.MISC", "Box of 100", "100", "BLR", "1200", "1700", "1600", "10-feb-2022", "15-feb-2022");

                //SRC.Add_Attribute("Density", "Durability", "Required", "Date", "15-Feb-2022");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //SRC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Goods Type Line
                SRC.CL_Goods("Create Line", "Goods", "MBP002", "150", "BLR", "10-feb-2022", "15-feb-2022");
                _test.Log(Status.Pass, "Line Created Successfully");

                //SRC.Add_Attribute("Density", "Durability", "Required", "Text", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //SRC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                SRC.CL_Services("Create Line", "Fixed Price Services", "SUPPLIES.FACILITIES", "Box of 100", "100", "BLR", "1000", "1500", "1400", "10-feb-2022", "15-feb-2022");

                //SRC.Add_Attribute("Density", "Durability", "Optional", "URL", "https://djhablog.medium.com/selenium-with-nunit-extentreports-df8ac63acb2c");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //SRC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                SRC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Supplier
                SRC.Supplier();
                SRC.Supplier("BENAKE BOXIMAIL PVT LTD", "BENAKE", "Sinchana gowda");
                SRC.Supplier("DUQESYCAB GETAIRMAIL PVT LTD", "BENAKE", "Jyotheesh Kummara");
                _test.Log(Status.Pass, "Suppliers added Successfully");

                SRC.Action();
                SRC.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");
                SRC.Action();
                SRC.ActionReqPublish();
                SRC.PublishDescription("Please Approve for Publish");
                SRC.ReqPublish();
                _test.Log(Status.Pass, "Requested for Publish of RFQ");

                SRC.LOGOUT();
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
                        SRC.ErrorValidation();
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
                SRC.closeBrowser();
            }
        }
    }
}
