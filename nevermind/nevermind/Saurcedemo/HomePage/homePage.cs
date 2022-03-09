using OpenQA.Selenium;

namespace nevermind.Saurcedemo.HomePage
{
    class homePage
    {
        private readonly IWebDriver driver;

        public IWebElement Username => driver.FindElement(By.Id("user-name"));

        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));

        public homePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
