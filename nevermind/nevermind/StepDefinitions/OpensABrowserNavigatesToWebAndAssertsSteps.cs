using System;
using nevermind.Pages;
using nevermind.Globals;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace nevermind.StepDefinitions
{

   
    [Binding]
    public class OpensABrowserNavigatesToWebAndAssertsSteps
    {
        IWebDriver driver;
        String Price;

        [Given(@"open chrome browser and navigate to (.*)")]
        public void GivenOpenChromeBrowserAndNavigateToPigu_Lt(string url)
        {
            var functions = new functions();
            functions.InitiateBrowser(Browser.Chrome);
            driver = functions.driver;
            functions.driver.Url = "https://"+url;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        [Then(@"search fot product dešra")]
        public void WhenSearchFotProduct()
        {
            var pageObj = new homePage(driver);
            pageObj.AgreeWihCookie.SendKeys(Keys.Enter);
            pageObj.SearchBox.SendKeys("dešra");
            pageObj.SearchBox.SendKeys(Keys.Enter);
        }

        [Then(@"add item to card")]
        public void WhenAddItemToCard()
        {
            var pageObj = new homePage(driver);
            pageObj.ElementList[0].Click();
            Price = pageObj.ElementList[0].Text;
            pageObj.ToCart[0].Click();
            pageObj.CloseSuggestion.Click();
            pageObj.CartIcon.Click();
        }

        [Then(@"validate item is in card")]
        public void ThenValidateItemIsInCard()
        {
            var cart = new cart(driver);
            string CartPrice = cart.CartPrice.Text;
            bool isElementDisplayed = cart.CartPrice.Displayed;
            Assert.AreEqual(Price, CartPrice, $"Price in list and card is not equeal{Price}");
            Assert.AreEqual(isElementDisplayed, true, $"Element exists");
            driver.Quit();
        }
    }
}
