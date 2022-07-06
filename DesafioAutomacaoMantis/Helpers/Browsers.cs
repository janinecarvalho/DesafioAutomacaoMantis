using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Remote;
using System;

namespace DesafioAutomacaoMantis.Helpers
{
    public class Browsers
    {
        private static string seleniumHub = JsonBuilder.GetAppSettings("SELENIUM_HUB");

        #region Chrome
        public static IWebDriver GetLocalChrome()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.AddArgument("enable-automation");
            chromeOptions.AddArgument("--no-sandbox");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            chromeOptions.AddArgument("--disable-browser-side-navigation");
            chromeOptions.AddArgument("--disable-gpu");
            chromeOptions.PageLoadStrategy = PageLoadStrategy.Normal;

            return new ChromeDriver(chromeOptions);
        }
        public static IWebDriver GetRemoteChrome()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("no-sandbox");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            chromeOptions.AddArgument("--lang=pt-BR");

            return new RemoteWebDriver(new Uri(seleniumHub), chromeOptions.ToCapabilities());
        }
        public static IWebDriver GetLocalChromeHeadless()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--headless");

            return new ChromeDriver(chromeOptions);
        }

        public static IWebDriver GetRemoteChromeHeadless()
        {
            ChromeOptions chromeOptions = new ChromeOptions();

            chromeOptions.AddArgument("no-sandbox");
            chromeOptions.AddArgument("--allow-running-insecure-content");
            chromeOptions.AddArgument("--lang=pt-BR");
            chromeOptions.AddArgument("--headless");

            return new RemoteWebDriver(new Uri(seleniumHub), chromeOptions.ToCapabilities()); ;
        }
        #endregion

        #region Firefox
        public static IWebDriver GetLocalFirefox()
        {
            return new FirefoxDriver();
        }

        public static IWebDriver GetRemoteFirefox()
        {
            FirefoxOptions firefoxOptions = new FirefoxOptions();

            var profile = new FirefoxProfile();
            firefoxOptions.Profile = profile;
            firefoxOptions.SetPreference("intl.accept_languages", "pt-BR");

            return new RemoteWebDriver(new Uri(seleniumHub), firefoxOptions.ToCapabilities());
        }
        #endregion

        #region Edge
        public static IWebDriver GetLocalEdge()
        {
            var options = new EdgeOptions();
            options.UseChromium = true;
            return new EdgeDriver(options);
        }

        public static IWebDriver GetRemoteEdge()
        {
            EdgeOptions edgeOptions = new EdgeOptions();

            return new RemoteWebDriver(new Uri(seleniumHub), edgeOptions.ToCapabilities());
        }
        #endregion
    }
}
