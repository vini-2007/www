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
        public void CheckLoginTest()
        {
            LoginPage.Open();
            LoginPage.EmailOrPhone.SendKeys("vikentev@hotmail.com"); // enter valid email as a parameter
            LoginPage.Password.SendKeys("v20072007"); // enter valid password as a parameter
            LoginPage.SignIn.Click();
            Assert.IsNotNull(LoginPage.ProfileImage, "The user is not authorized: ");
        }
    }
}
