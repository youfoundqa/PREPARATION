using System;
using TechTalk.SpecFlow;
using nevermind.Saurcedemo.HomePage;
using OpenQA.Selenium;

namespace nevermind.StepDefinitions
{
    [Binding]
    public class SaucedemoSteps
    {
        IWebDriver driver;
        int item;

        [Given(@"username is- standard_user-(.*) and password id-(.*)")]
        public void GivenUsernameIs_Standard_UserStandard_UserAndPasswordId_Secret_SauceSecret_Sauce(string user, string pass)
        {
            var pageObj = new homePage(driver);
            pageObj.Username.SendKeys(user);
            pageObj.Password.SendKeys(pass);
            pageObj.Password.SendKeys(Keys.Enter);
        }
        
        [When(@"select cheapest item form inventory")]
        public void WhenSelectCheapestItemFormInventory()
        {
            var pageObj = new inventory(driver);
            int priceWeb;
            int t =0;
           
            int price = Int32.Parse(pageObj.ItemList[t].Text);
            foreach (IWebElement i in pageObj.ItemList) 
                {
                priceWeb = Int32.Parse(pageObj.ItemList[t].Text);
                if (price < priceWeb)
                {
                    price = priceWeb;
                    item = t;
                }
                t++;
            }
        }
        
        [Then(@"add item to cart")]
        public void ThenAddItemToCart()
        {
            var pageObj = new inventory(driver);
            pageObj.AddToCardList[item].Click();
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
