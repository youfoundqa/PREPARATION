using System.Collections.Generic;
using OpenQA.Selenium;

namespace nevermind.Saurcedemo.HomePage
{
    class inventory
    {
        private readonly IWebDriver driver;

        public IList<IWebElement> ItemList => (IList<IWebElement>)driver.FindElements(By.CssSelector("[class*='inventory_item_price']"));

        public IList<IWebElement> AddToCardList => (IList<IWebElement>)driver.FindElements(By.CssSelector("[class*='btn btn_primary btn_small btn_inventory']"));
        public inventory(IWebDriver webDriver)
        {
            driver = webDriver;
        }
    }
}
