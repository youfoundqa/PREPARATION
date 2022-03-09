using System;
using TechTalk.SpecFlow;
using nevermind.Saurcedemo.HomePage;
using OpenQA.Selenium;
using System.Globalization;

namespace nevermind.StepDefinitions
{
    [Binding]
    public class SaucedemoSteps
    {
        IWebDriver driver;
        int Item = 0;

        [Given(@"username is- standard_user-(.*) and password id-(.*)")]
        public void GivenUsernameIs_Standard_UserStandard_UserAndPasswordId_Secret_SauceSecret_Sauce(string user, string pass)
        {
            driver = OpensABrowserNavigatesToWebAndAssertsSteps.driver;
            var pageObj = new homePage(driver);
            pageObj.Username.SendKeys(user);
            pageObj.Password.SendKeys(pass);
            pageObj.Password.SendKeys(Keys.Enter);
        }
        
        [When(@"select cheapest item form inventory")]
        public void WhenSelectCheapestItemFormInventory()
        {
            var pageObj = new inventory(driver);
            Decimal Price = Decimal.Parse(pageObj.ItemList[0].Text, NumberStyles.Currency);
            for (int i = 0; i < pageObj.ItemList.Count; i++){
                if (Price > Decimal.Parse(pageObj.ItemList[i].Text, NumberStyles.Currency))
                {
                    Price = Decimal.Parse(pageObj.ItemList[i].Text, NumberStyles.Currency);
                    Item = i;
                }
            }
        }
        
        [Then(@"add item to cart")]
        public void ThenAddItemToCart()
        {
            var pageObj = new inventory(driver);
            pageObj.AddToCardList[Item].Click();
        }
        
        [Then(@"Navigate to cart")]
        public void ThenNavigateToCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Chechout")]
        public void ThenChechout()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add Firdt name - , Last name - , ZipCode -")]
        public void ThenAddFirdtName_LastName_ZipCode_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"in checkout-step-two press Finish")]
        public void ThenInCheckout_Step_TwoPressFinish()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"validate checkout-complete page message")]
        public void ThenValidateCheckout_CompletePageMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
