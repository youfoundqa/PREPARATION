using OpenQA.Selenium;
using System.Collections.Generic;

namespace nevermind.Pages
{
    
    class cart
    {
        private readonly IWebDriver driver;

        public IWebElement CartPrice => driver.FindElement(By.CssSelector("[class*='color-orange notranslate float_right']"));

        public cart(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
