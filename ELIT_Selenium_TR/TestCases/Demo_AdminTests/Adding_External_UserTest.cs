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
    public class Adding_External_UserTest : ReportsGenerationClass
    {
        Adding_External_User AEU;


        [Test, Order(1)]
        [Category("DemoAdmin_Adding External User")]
        public void Adding_External_User()
        {

            AEU = new Adding_External_User(GetDriver());

            try
            {
                AEU.GoToPage();
                AEU.UserName("DEMO_ADMIN");
                AEU.Password("Atsdemo@2021");
                AEU.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AEU.General();
                AEU.User();
                AEU.Create_ExternalUser();
                _test.Log(Status.Info, "Clicked on Add New External User");

                AEU.Supplier_Name("MALOJI9772@ALICDH.COM");
                AEU.Contact_Name("maloji");
                AEU.Title("Mrs.");
                AEU.First_Name("maloji");
                AEU.Middle_Name("");
                AEU.Last_Name("maloji");
                AEU.Position("Developer");
                AEU.Email_Address("maloji@appstec-me.com");
                AEU.Phone_Number("7608000100");
                AEU.Alternate_Number("8040406634");
                AEU.Role_Name("Demo Administrator");
                AEU.Image();
                AEU.User_UserName("maloji");
               
                _test.Log(Status.Info, "Filled details of New External User");

                AEU.Add();

                bool titlevalidation = AEU.TitleValidation();
                Assert.AreEqual(false, titlevalidation);

                bool firstnamevalidation = AEU.FirstNameValidation();
                Assert.AreEqual(false, firstnamevalidation);

                bool lastnamevalidation = AEU.LastNameValidation();
                Assert.AreEqual(false, lastnamevalidation);

                bool positionvalidation = AEU.PositionValidation();
                Assert.AreEqual(false, positionvalidation);

                bool emailaddressvalidation = AEU.EmailAddressValidation();
                Assert.AreEqual(false, emailaddressvalidation);

                bool phonenumbervalidation = AEU.PhoneNumberValidation();
                Assert.AreEqual(false, phonenumbervalidation);

                bool rolenamevalidation = AEU.RoleNameValidation();
                Assert.AreEqual(false, rolenamevalidation);

                bool usernamevalidation = AEU.UserNameValidation();
                Assert.AreEqual(false, usernamevalidation);

                _test.Log(Status.Info, "Added New External User");

                AEU.LogOut();
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
                AEU.closeBrowser();
            }
        }

        [Test, Order(1)]
        [Category("DemoAdmin_Adding External User")]
        public void Adding_Duplicate_External_User()
        {
            AEU = new Adding_External_User(GetDriver());

            try
            {
                AEU.GoToPage();
                AEU.UserName("DEMO_ADMIN");
                AEU.Password("Atsdemo@2021");
                AEU.SignIn();
                _test.Log(Status.Info, "Demo Admin Logged in");

                AEU.General();
                AEU.User();
                AEU.Create_ExternalUser();
                _test.Log(Status.Info, "Clicked on Add New External User");

                AEU.Supplier_Name("VIPEHEX960@DONMAH.COM");
                AEU.Contact_Name("Sreekanth");
                AEU.Title("Mr.");
                AEU.First_Name("Chinnakkagari");
                AEU.Middle_Name("Sreekanth");
                AEU.Last_Name("Reddy");
                AEU.Position("Trainee");
                AEU.Email_Address("chinnakagari@appstec-me.com");
                AEU.Phone_Number("8574930215");
                AEU.Alternate_Number("8247352844");
                AEU.Role_Name("Demo Administrator");
                AEU.Image();
                AEU.User_UserName("CVA");
                _test.Log(Status.Info, "Filled details of New External User");

                AEU.Add();

                bool titlevalidation = AEU.TitleValidation();
                Assert.AreEqual(false, titlevalidation);

                bool firstnamevalidation = AEU.FirstNameValidation();
                Assert.AreEqual(false, firstnamevalidation);

                bool lastnamevalidation = AEU.LastNameValidation();
                Assert.AreEqual(false, lastnamevalidation);

                bool positionvalidation = AEU.PositionValidation();
                Assert.AreEqual(false, positionvalidation);

                bool emailaddressvalidation = AEU.EmailAddressValidation();
                Assert.AreEqual(false, emailaddressvalidation);

                bool phonenumbervalidation = AEU.PhoneNumberValidation();
                Assert.AreEqual(false, phonenumbervalidation);

                bool rolenamevalidation = AEU.RoleNameValidation();
                Assert.AreEqual(false, rolenamevalidation);

                bool usernamevalidation = AEU.UserNameValidation();
                Assert.AreEqual(false, usernamevalidation);

                _test.Log(Status.Info, "Added New External User");

                AEU.LogOut();
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
                AEU.closeBrowser();
            }
        }



    }
}
