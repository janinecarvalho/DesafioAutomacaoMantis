using OpenQA.Selenium;
using System;
using System.Configuration;
using System.Collections.Specialized;

namespace DesafioAutomacaoMantis.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver INSTANCE { get; set; } = null;

        public static void CreateInstance()
        {
            string browser = JsonBuilder.GetAppSettings("BROWSER");
            string execution = JsonBuilder.GetAppSettings("EXECUTION");
            bool headless = bool.Parse(JsonBuilder.GetAppSettings("HEADLESS"));

            //string browser = JsonBuilder.GetAppSettings().BROWSER;

            if (INSTANCE == null)
            {
                switch (browser)
                {
                    case "chrome":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = headless ? Browsers.GetLocalChromeHeadless() : Browsers.GetLocalChrome();
                        }
                        if (execution.Equals("remota"))
                        {
                            INSTANCE = headless ? Browsers.GetRemoteChromeHeadless() : Browsers.GetRemoteChrome();
                        }
                        break;

                    case "firefox":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = Browsers.GetLocalFirefox();
                        }
                        if (execution.Equals("remota"))
                        {
                            INSTANCE = Browsers.GetRemoteFirefox();
                        }
                        break;

                    case "edge":
                        if (execution.Equals("local"))
                        {
                            INSTANCE = Browsers.GetLocalEdge();
                        }

                        if (execution.Equals("remota"))
                        {
                            INSTANCE = Browsers.GetRemoteEdge();
                        }
                        break;

                    default:
                        throw new Exception("O browser informando não existe ou não é suportado pela automação!");
                }
            }
        }

        public static void QuitInstance()
        {
            INSTANCE.Quit();
            INSTANCE.Dispose();
            INSTANCE = null;
        }
    }
}
