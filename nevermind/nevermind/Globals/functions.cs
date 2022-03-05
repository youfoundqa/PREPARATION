using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace nevermind.Globals
{
    class functions
    {
        public IWebDriver driver;
        public void InitiateBrowser(Browser Webrowser)
        {
            switch (Webrowser)
            {
                case Browser.Chrome:
                    driver = new ChromeDriver();
                    break;
                case Browser.Opera:
                    break;
                case Browser.Ie:
                    break;
            }
        }
    }
}
