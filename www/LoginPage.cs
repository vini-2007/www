using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace www
{
    public class LoginPage
    {
        public ChromeDriver Driver = new ChromeDriver();
        public string Url = "https://www.linkedin.com/login?fromSignIn=true&trk=guest_homepage-basic_nav-header-signin";

        public IWebElement EmailOrPhone => Driver.FindElementById("username");
        public IWebElement Password => Driver.FindElementById("password");
        public IWebElement SignIn => Driver.FindElementByClassName("login__form_action_container");
        public IWebElement ProfileImage => Driver.FindElementByClassName("global-nav__me-photo");

        public void Open()
        {
            Driver.Navigate().GoToUrl(Url);
        }

        public void Close()
        {
            Driver.Quit();
        }
    }
}
