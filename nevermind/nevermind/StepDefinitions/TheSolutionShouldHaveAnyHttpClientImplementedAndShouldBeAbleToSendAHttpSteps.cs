using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace nevermind.StepDefinitions
{
    [Binding]
    public class TheSolutionShouldHaveAnyHttpClientImplementedAndShouldBeAbleToSendAHttpSteps
    {
        private string getUrl = "https://api.meteo.lt/v1/places/";
        private string result;
        private dynamic bodyJson;

        [Given(@"the city name is (.*)")]
        public void GivenTheCityName(string name)
        {
            getUrl += name;
        }
        
        [When(@"Make request")]
        public async Task WhenMakeRequestAsync()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync(getUrl).Result;
            result = await response.Content.ReadAsStringAsync();
            bodyJson = JObject.Parse(result);
            httpClient.Dispose();
        }
        
        [Then(@"Validate that countryCode is (.*)")]
        public void ValidateCountryCode(string countryCode)
        {
            Assert.AreEqual(bodyJson.countryCode.ToString(), countryCode, $"countryCode is not equl to {countryCode}");
        }
    }
}
