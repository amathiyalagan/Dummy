using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.RFQ.Simple;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.RFQTests.Flexible
{
    [TestFixture]
    public class RFQCreationTest : ReportsGenerationClass
    {
        RFQCreation RFQC;

        [Test, Order(1)]
        [Category("Flexible RFQ Creation")]
        public void Flexible_RFQ_Creation()
        {
            RFQC = new RFQCreation(GetDriver());

            try
            {
                RFQC.GoToPage("http://localhost:3000/");
                RFQC.UserName("ATHANIGA");
                RFQC.Password("Atsdxb@003");
                RFQC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");

                RFQC.Sourcing();
                RFQC.Quotation();
                RFQC.Create();
                _test.Log(Status.Pass, "Clicked on Create NEW RFQ");

                RFQC.Header_Title("FLEXIBLE RFQ CREATION 007 of 040 in 25FEB");
                RFQC.Document_Type("Flexible");  
                RFQC.Security("Public");
                RFQC.OU("Appstec Technology Services");
                RFQC.PO_Type("Standard");
                RFQC.Enable_EMD();
                RFQC.Description("FLEXIBLE RFQ CREATION 007 of 040 in 25FEB");
                _test.Log(Status.Pass, "Filled Header");

                RFQC.Terms_Conditions();
                RFQC.Bill_to_Address("BLR");
                RFQC.Ship_To_Address("BLR");
                RFQC.Payment_Terms("50%");
                RFQC.Freight_Terms("AIR");
                RFQC.EMD("10", "28-feb-2022", "Bank Guarantee", "Should pay as per Conditions");
                _test.Log(Status.Pass, "Filled Terms and Conditions");

                RFQC.Collaboration_Team();
                RFQC.Target_Date("28-feb-2022");
                RFQC.Add_CollaborationTeam("Ms.Sirisha Sagi", "Scoring", "Technical", "28-feb-2022");
                RFQC.Add_CollaborationTeam("DAYANANDA", "Scoring", "Commercial", "28-feb-2022");
                _test.Log(Status.Pass, "Added details of Collaboration Team");

                RFQC.Controls();
                RFQC.Controls_Reposition();
                RFQC.Controls_CloseDate("05-03-2022 11:00 AM");
                RFQC.Rules_SelectLines();
                RFQC.Rules_ReqFull_quantity();
                RFQC.Rules_MARS();
                RFQC.Rules_QWithdrawal();
                RFQC.Rules_ManualClose();
                RFQC.Rules_ManualExtend();
                RFQC.Rules_StaggeredAward();
                RFQC.Controls();
                _test.Log(Status.Pass, "Controls added Succesfully");

                RFQC.Notes_Attachments();
                RFQC.NA_NotesToBuyer("Required the full quantity in given time");
                RFQC.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "To Supplier", "Requirement");
                RFQC.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "To Internal", "Requirement");
                _test.Log(Status.Pass, "Attachments added Successfully");

                RFQC.Lines();
                RFQC.Lines_DisplayRank("Win/Lose");
                RFQC.Lines_Ranking("Scoring");
                RFQC.Lines_CostFactors("Buyer");
                _test.Log(Status.Pass, "Lines Details added Successfully");

                //Goods Type Line
                RFQC.CL_Goods("Create Line", "Goods", "MBA001", "150", "BLR", "06-Mar-2022", "16-Mar-2022");

                RFQC.Add_Attribute("Density", "Durability", "Optional", "Text", "5");
                _test.Log(Status.Pass, "Attributes added Successfully");

                RFQC.Add_CostFactor("DUTY", "5");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");


                //Fixed Price Service Type Line
                RFQC.CL_Services("Create Line", "Fixed Price Services", "Computer Accessories and Supplies", "Box of 100", "100", "BLR", "1200", "1700", "1600", "06-Mar-2022", "16-Mar-2022");

                RFQC.Add_Attribute("Density", "Durability", "Required", "Number", "6");
                _test.Log(Status.Pass, "Attributes added Successfully");

                RFQC.Add_CostFactor("DUTY", "5");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Goods Type Line
                RFQC.CL_Goods("Create Line", "Goods", "MBP002", "150", "BLR", "06-Mar-2022", "16-Mar-2022");

                RFQC.Add_Attribute("Density", "Durability", "Required", "Number", "7");
                _test.Log(Status.Pass, "Attributes added Successfully");

                RFQC.Add_CostFactor("DUTY", "5");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                RFQC.CL_Services("Create Line", "Fixed Price Services", "Computer Software for Microcomputers", "Box of 100", "100", "BLR", "1000", "1500", "1400", "06-Mar-2022", "16-Mar-2022");

                RFQC.Add_Attribute("Density", "Durability", "Optional", "Date", "28-Mar-2022");
                _test.Log(Status.Pass, "Attributes added Successfully");

                RFQC.Add_CostFactor("DUTY", "5");
                _test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                RFQC.Supplier();
                RFQC.Supplier("BENAKE BOXIMAIL PVT LTD", "SINCHANA", "Sinchana gowda");
                RFQC.Supplier("DUQESYCAB GETAIRMAIL PVT LTD", "JYOTHEESH", "Jyotheesh Kummara");
                RFQC.Supplier("ATS ELIT CORPORATION", "DUBAI", "Tausif Ahmed");
                _test.Log(Status.Pass, "Suppliers added Successfully");

                RFQC.Action();
                RFQC.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");
                RFQC.Action();
                RFQC.Publish();
                _test.Log(Status.Pass, "Flexible RFQ Published");

                RFQC.LOGOUT();
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
                        RFQC.ErrorValidation();
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
                RFQC.closeBrowser();
            }
        }


        [Test, Order(2)]
        [Category("Flexible RFQ Creation")]
        public void Flexible_RFQ_Creation_Approvals()
        {
            RFQC = new RFQCreation(GetDriver());

            try
            {
                RFQC.GoToPage("http://localhost:3000/");
                RFQC.UserName("ATHANIGA");
                RFQC.Password("Atsdxb@003");
                RFQC.SignIn();
                _test.Log(Status.Pass, "Buyer Logged In");

                RFQC.Sourcing();
                RFQC.Quotation();
                RFQC.Create();
                _test.Log(Status.Pass, "Clicked on Create NEW RFQ");

                RFQC.Header_Title("FLEXIBLE RFQ 003 of 040");
                RFQC.Document_Type("Flexible");  
                RFQC.Security("Public");
                RFQC.OU("Appstec Technology Services");
                RFQC.PO_Type("Standard");
                RFQC.Enable_EMD();
                RFQC.Description("FLEXIBLE RFQ 003 of 040");
                _test.Log(Status.Pass, "Filled Header");

                RFQC.Terms_Conditions();
                RFQC.Bill_to_Address("BLR");
                RFQC.Ship_To_Address("BLR");
                RFQC.Payment_Terms("50%");
                RFQC.Freight_Terms("AIR");
                RFQC.EMD("10", "18-feb-2022", "Bank Guarantee", "Should pay as per Conditions");
                _test.Log(Status.Pass, "Filled Terms and Conditions");

                RFQC.Collaboration_Team();
                RFQC.Collaboration_Team_Reposition();
                RFQC.Target_Date("18-feb-2022");
                RFQC.Add_CollaborationTeam("Mr.Ramana Kallepalli", "Scoring", "Technical", "18-feb-2022");
                RFQC.Add_CollaborationTeam("Ms.Sirisha Sagi", "Scoring", "Commercial", "18-feb-2022");
                _test.Log(Status.Pass, "Added details of Collaboration Team");

                RFQC.Controls();
                RFQC.Controls_Reposition();
                RFQC.Controls_CloseDate("20-02-2022 11:00 AM");
                RFQC.Rules_SelectLines();
                RFQC.Rules_ReqFull_quantity();
                RFQC.Rules_MARS();
                RFQC.Rules_QWithdrawal();
                RFQC.Rules_ManualClose();
                RFQC.Rules_ManualExtend();
                RFQC.Rules_StaggeredAward();
                RFQC.Rules_PublishingApproval();    
                RFQC.Rules_ManualCloseApproval();   
                RFQC.Rules_ManualExtendApproval();
                RFQC.Rules_AwardingApproval();
                RFQC.Controls();
                _test.Log(Status.Pass, "Controls added Succesfully");

                RFQC.Notes_Attachments();
                RFQC.NA_NotesToBuyer("Required the full quantity in given time");
                RFQC.NA_AddAttachment("Supplier Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/ELIT 4001 Testing.pdf", "To Supplier", "Requirement");
                RFQC.NA_AddAttachment("Internal Requirement Details", "File", "C:/Users/srchi/OneDrive/Desktop/Manual Rules.txt", "To Internal", "Requirement");
                _test.Log(Status.Pass, "Attachments added Successfully");

                RFQC.Lines();
                RFQC.Lines_DisplayRank("Win/Lose");
                RFQC.Lines_Ranking("Scoring");
                RFQC.Lines_CostFactors("Buyer");
                _test.Log(Status.Pass, "Lines added Successfully");

                //Goods Type Line
                RFQC.CL_Goods("Create Line", "Goods", "MBA001", "150", "BLR", "22-Feb-2022", "29-Feb-2022");

                //RFQC.Add_Attribute("Density", "Durability", "", "Number", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //RFQC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");


                //Fixed Price Service Type Line
                RFQC.CL_Services("Create Line", "Fixed Price Services", "MISC.MISC", "Box of 100", "100", "BLR", "1200", "1700", "1600", "22-feb-2022", "25-feb-2022");

                //RFQC.Add_Attribute("Density", "Durability", "", "Number", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //RFQC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Goods Type Line
                RFQC.CL_Goods("Create Line", "Goods", "MBP002", "150", "BLR", "22-feb-2022", "25-feb-2022");

                //RFQC.Add_Attribute("Density", "Durability", "", "Number", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //RFQC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                //Fixed Price Service Type Line
                RFQC.CL_Services("Create Line", "Fixed Price Services", "MISC.MISC", "Box of 100", "100", "BLR", "1200", "1700", "1600", "22-feb-2022", "25-feb-2022");

                //RFQC.Add_Attribute("Density", "Durability", "", "Number", "5");
                //_test.Log(Status.Pass, "Attributes added Successfully");

                //RFQC.Add_CostFactor("DUTY", "5");
                //_test.Log(Status.Pass, "CostFactors added Successfully");

                RFQC.LinesCreate_Apply();
                _test.Log(Status.Pass, "Created Line Successfully!!");

                RFQC.Supplier();
                RFQC.Supplier("BENAKE BOXIMAIL PVT LTD", "BENAKE", "Sinchana gowda");
                RFQC.Supplier("DUQESYCAB GETAIRMAIL PVT LTD", "BENAKE", "Jyotheesh Kummara");
                _test.Log(Status.Pass, "Suppliers added Successfully");

                RFQC.Action();
                RFQC.Preview();
                _test.Log(Status.Pass, "Entered Preview Mode");
                RFQC.Action();
                RFQC.ActionReqPublish();
                RFQC.PublishDescription("Please Approve for Publish");
                RFQC.ReqPublish();
                _test.Log(Status.Pass, "Requested for Publish");

                RFQC.LOGOUT();
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
                        RFQC.ErrorValidation();
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
                RFQC.closeBrowser();
            }
        }
    }
}
