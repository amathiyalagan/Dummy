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
    public class Adding_Internal_userTest : ReportsGenerationClass
    {
        Adding_Internal_User AIU;

        [Test, Order(1)]
        [Category("DemoAdmin_Adding Internal User")]
        public void Adding_Internal_User()
        {
            AIU = new Adding_Internal_User(GetDriver());

            try
            {
                AIU.GoToPage();
                AIU.UserName("DEMO_ADMIN");
                AIU.Password("Atsdemo@2021");
                AIU.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AIU.General();
                AIU.User();
                _test.Log(Status.Info, "Clicked on Add New Internal User");

                AIU.Title("Mr.");
                AIU.First_Name("shakthi");
                AIU.Middle_Name("charan");
                AIU.Last_Name("Kuppuswamy");
                AIU.Position("Developer");
                AIU.Email_Address("skuppuswamy@appstec-me.com");
                AIU.Phone_Number("7661950580");
                AIU.Alternate_Number("8247352755");
                AIU.Role_Name("Demo Administrator");
                AIU.Image();
                AIU.User_UserName("skuppuswamy");
                _test.Log(Status.Info, "Filled details of New iNternal User");

                AIU.Add();
                _test.Log(Status.Info, "Added New iNternal User");

                bool titlevalidation = AIU.TitleValidation();
                Assert.AreEqual(false, titlevalidation);

                bool firstnamevalidation = AIU.FirstNameValidation();
                Assert.AreEqual(false, firstnamevalidation);

                bool lastnamevalidation = AIU.LastNameValidation();
                Assert.AreEqual(false, lastnamevalidation);

                bool emailaddressvalidation = AIU.EmailAddressValidation();
                Assert.AreEqual(false, emailaddressvalidation);

                bool phonenumbervalidation = AIU.PhoneNumberValidation();
                Assert.AreEqual(false, phonenumbervalidation);

                bool rolenamevalidation = AIU.RoleNameValidation();
                Assert.AreEqual(false, rolenamevalidation);

                bool usernamevalidation = AIU.UserNameValidation();
                Assert.AreEqual(false, usernamevalidation);

                AIU.LogOut();
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
                AIU.closeBrowser();
            }
        }


        [Test, Order(1)]
        [Category("DemoAdmin_Adding Internal User")]
        public void AddingDuplicate_Internal_User()
        {
            AIU = new Adding_Internal_User(GetDriver());

            try
            {
                AIU.GoToPage();
                AIU.UserName("DEMO_ADMIN");
                AIU.Password("Atsdemo@2021");
                AIU.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AIU.General();
                AIU.User();
                _test.Log(Status.Info, "Clicked on Add New Internal User");

                AIU.Title("Mrs.");
                AIU.First_Name("Ayesha");
                AIU.Middle_Name("Shajahan");
                AIU.Last_Name("Shail");
                AIU.Position("Trainee");
                AIU.Email_Address("ayesha@appstec-me.com");
                AIU.Phone_Number("9876543210");
                AIU.Alternate_Number("9638527410");
                AIU.Role_Name("Demo Administrator");
                AIU.Image();
                AIU.User_UserName("Ayesha");
                _test.Log(Status.Info, "Filled details of New iNternal User");

                AIU.Add();
                _test.Log(Status.Info, "Added New iNternal User");

                bool titlevalidation = AIU.TitleValidation();
                Assert.AreEqual(false, titlevalidation);

                bool firstnamevalidation = AIU.FirstNameValidation();
                Assert.AreEqual(false, firstnamevalidation);

                bool lastnamevalidation = AIU.LastNameValidation();
                Assert.AreEqual(false, lastnamevalidation);

                bool emailaddressvalidation = AIU.EmailAddressValidation();
                Assert.AreEqual(false, emailaddressvalidation);

                bool phonenumbervalidation = AIU.PhoneNumberValidation();
                Assert.AreEqual(false, phonenumbervalidation);

                bool rolenamevalidation = AIU.RoleNameValidation();
                Assert.AreEqual(false, rolenamevalidation);

                bool usernamevalidation = AIU.UserNameValidation();
                Assert.AreEqual(false, usernamevalidation);

                AIU.LogOut();
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
                AIU.closeBrowser();
            }
        }


    }
}
