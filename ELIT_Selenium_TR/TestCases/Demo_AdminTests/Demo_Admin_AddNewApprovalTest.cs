using AventStack.ExtentReports;
using ELIT_Selenium_TR.Config;
using ELIT_Selenium_TR.PageMethods.Demo_Admin;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIT_Selenium_TR.TestCases.Demo_AdminTests
{
    [TestFixture]
    public class Demo_Admin_AddNewApprovalTest : ReportsGenerationClass
    {
        Demo_Admin_AddNewApproval AADA;

        [Test, Order(1)]
        [Category("DemoAdmin_Adding new Approver")]
        public void Add_New_Approver()
        {
            AADA = new Demo_Admin_AddNewApproval(GetDriver());

            try
            {
                AADA.GoToPage();
                AADA.UserName("DEMO_ADMIN");
                AADA.Password("Atsdemo@2021");
                AADA.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AADA.General();
                AADA.Approval_Creation();
                AADA.Approval_Type("Bank Account Approval");
                AADA.Authorized_Person("SHUBHAM KHUVA");
                AADA.Level("3");
                AADA.Submit();

                bool ApprovalValidation = AADA.ApprovalTypeValidation();
                Assert.AreEqual(false, ApprovalValidation);

                bool AuthorizationValidation = AADA.Authorized_Person_Validation();
                Assert.AreEqual(false, AuthorizationValidation);

                bool LevelValidation = AADA.Level_Validation();
                Assert.AreEqual(false, LevelValidation);

                _test.Log(Status.Info, "New Approver Added");

                AADA.LogOut();
                _test.Log(Status.Info, "Demo Admin Logged Out");
            }
            catch (Exception ex)
            {
                DateTime time = DateTime.Now;
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                AADA.closeBrowser();
            }
        }

        [Test, Order(2)]
        [Category("DemoAdmin_Adding new Approver")]
        public void Duplicate_New_Approver()
        {
            AADA = new Demo_Admin_AddNewApproval(GetDriver());

            try
            {
                AADA.GoToPage();
                AADA.UserName("DEMO_ADMIN");
                AADA.Password("Atsdemo@2021");
                AADA.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AADA.General();
                AADA.Approval_Creation();
                AADA.Approval_Type("Bank Account Approval");
                AADA.Authorized_Person("Ayesha Shaik");
                AADA.Level("3");
                AADA.Submit();

                bool ApprovalValidation = AADA.ApprovalTypeValidation();
                Assert.AreEqual(false, ApprovalValidation);

                bool AuthorizationValidation = AADA.Authorized_Person_Validation();
                Assert.AreEqual(false, AuthorizationValidation);

                bool LevelValidation = AADA.Level_Validation();
                Assert.AreEqual(false, LevelValidation);

                _test.Log(Status.Info, "New Approver Added");

                AADA.LogOut();
                _test.Log(Status.Info, "Demo Admin Logged Out");
            }
            catch (Exception ex)
            {
                DateTime time = DateTime.Now;
                String fileName = "Screenshot_" + time.ToString("dd_MM_yyyy_hh_mm_ss") + ".png";
                String screenShotPath = Capture(_driver, fileName);
                _test.Log(Status.Fail, ex.ToString());
                _test.Log(Status.Fail, "Snapshot below: " + _test.AddScreenCaptureFromPath("Screenshots\\" + fileName));
            }
            finally
            {
                AADA.closeBrowser();
            }
        }
    }
}
