using OpenQA.Selenium;
using System.Collections.Generic;

namespace nevermind.Pages
{
    class homePage
    {
        private readonly IWebDriver driver;

        public IWebElement SearchBox => driver.FindElement(By.Id("searchInput"));
        public IWebElement AgreeWihCookie => driver.FindElement(By.CssSelector("[class*='button agree']"));
        public IWebElement PriceFrom => driver.FindElement(By.ClassName("price -from"));
        public IList<IWebElement> ElementList => (IList<IWebElement>)driver.FindElements(By.CssSelector("[class*='price notranslate']"));
        public IList<IWebElement> ToCart => (IList<IWebElement>)driver.FindElements(By.CssSelector("[class*='btn-primary btn-full-width btn']"));
        public IWebElement CloseSuggestion => driver.FindElement(By.Id("close"));
        public IWebElement CartIcon => driver.FindElement(By.Id("spanText"));

        
        public homePage(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
