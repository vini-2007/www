using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace www
{
    [TestClass]
    public class UnitTest1
    {
        public LoginPage LoginPage;

        [TestInitialize]
        public void InitializePage()
        {
            LoginPage = new LoginPage();
        }

        [TestCleanup]
        public void ClosePage()
        {
            LoginPage.Close();
        }

        [TestMethod]
        [Description("This test checks login with valid username and password")]
        public void CheckLoginTest()
        {
            LoginPage.Open();
            LoginPage.EmailOrPhone.SendKeys(""); // enter valid email as a parameter
            LoginPage.Password.SendKeys(""); // enter valid password as a parameter
            LoginPage.SignIn.Click();
            Assert.IsNotNull(LoginPage.ProfileImage, "The user is not authorized: ");
        }

        //ToDo: Create the test that checks login with invalid password

    }
}
