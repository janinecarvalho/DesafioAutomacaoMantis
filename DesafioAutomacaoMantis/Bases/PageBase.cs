using DesafioAutomacaoMantis.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Diagnostics;
using System.Linq;

namespace DesafioAutomacaoMantis.Bases
{
    public class PageBase
    {
        #region objects and contructor
        protected WebDriverWait wait { get; private set; }
        protected IWebDriver driver { get; private set; }
        protected IJavaScriptExecutor javaScriptExecutor { get; private set; }

        public PageBase()
        {
            wait = new WebDriverWait(DriverFactory.INSTANCE, TimeSpan.FromSeconds(Convert.ToDouble(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT"))));
            driver = DriverFactory.INSTANCE;
            javaScriptExecutor = (IJavaScriptExecutor)driver;
        }
        #endregion

        #region Custom Actions

        protected void NavegarAteURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        private void WaitUntilPageReady()
        {
            Stopwatch timeOut = new Stopwatch();
            timeOut.Start();

            while (timeOut.Elapsed.Seconds <= Convert.ToInt32(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT")))
            {
                string documentState = javaScriptExecutor.ExecuteScript("return document.readyState").ToString();

                if (documentState.Equals("complete"))
                {
                    timeOut.Stop();
                    break;
                }
            }
        }

        
        protected IWebElement WaitForElement(By locator)
        {
            WaitUntilPageReady();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
            return element;
        }

        protected IWebElement WaitForElementNotClickable(By locator)
        {
            WaitUntilPageReady();
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            return element;
        }

        protected void ActionClickComboBox(By locatorCombobox, By locatorValorCombobox, string filtroCombobox)
        {
            Actions actions = new Actions(driver);
            actions.Click(WaitForElement(locatorCombobox)).Build().Perform();
            actions.SendKeys(filtroCombobox).Build().Perform();
            Click(locatorValorCombobox);
        }

        
        protected void Click(By locator)
        {
            Stopwatch timeOut = new Stopwatch();
            timeOut.Start();

            while (timeOut.Elapsed.Seconds <= Convert.ToInt32(JsonBuilder.GetAppSettings("TIMEOUT_DEFAULT")))
            {
                try
                {
                    WaitForElement(locator).Click();
                    timeOut.Stop();
                    return;
                }
                catch (System.Reflection.TargetInvocationException)
                {

                }
                catch (StaleElementReferenceException)
                {

                }
                catch (System.InvalidOperationException)
                {

                }
                catch (WebDriverException e)
                {
                    if (e.Message.Contains("Other element would receive the click"))
                    {
                        continue;
                    }

                    if (e.Message.Contains("Element is not clickable at point"))
                    {
                        continue;
                    }

                    throw e;
                }
            }

            throw new Exception("Given element isn't visible");
        }

        protected void EnterKeyBoardAction(By locator)
        {
            WaitForElement(locator).SendKeys(Keys.Enter);
        }

        protected void MoveMouseToElement(By locator)
        {
            Actions action = new Actions(driver);
            action.MoveToElement(WaitForElementNotClickable(locator)).Perform();
            //return element;
        }


        protected void SendKeys(By locator, string text)
        {
            WaitForElement(locator).SendKeys(text);
        }

        
        protected void ComboBoxSelectByVisibleText(By locator, string text)
        {
            SelectElement comboBox = new SelectElement(WaitForElement(locator));
            comboBox.SelectByText(text);
        }

        
        protected string GetText(By locator)
        {
            string text = WaitForElement(locator).Text;
            return text;
        }

        
        protected string GetValue(By locator)
        {
            string text = WaitForElement(locator).GetAttribute("value");
            return text;
        }

        
        protected bool ReturnIfElementIsDisplayed(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Displayed;
            return result;
        }

        
        protected bool ReturnIfElementIsEnabled(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Enabled;
            return result;
        }

        
        protected bool ReturnIfElementIsSelected(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            bool result = driver.FindElement(locator).Selected;
            return result;
        }

        
        protected void Clear(By locator)
        {
            WaitForElement(locator).Clear();
        }

        
        protected void ClearAndSendKeys(By locator, String text)
        {
            WaitForElement(locator).Clear();
            WaitForElement(locator).SendKeys(text);
        }
        #endregion

        #region JavaScript Actions

        protected void ComboBoxSelectByVisibleTextJavaScript(By locator, string value)
        {
            SelectElement comboBox = new SelectElement(WaitForElement(locator));

            javaScriptExecutor.ExecuteScript("var select = arguments[0]; for(var i = 0; i < select.options.length; i++){ if(select.options[i].text == arguments[1]){ select.options[i].selected = true; } }", comboBox, value);
        }

        protected void SendKeysJavaScript(By locator, string value)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].value='" + value + "';", WaitForElement(locator));
        }

        protected void ClearAndSendKeysJavaScript(By locator, String value)
        {
            WaitForElement(locator).Clear();
            javaScriptExecutor.ExecuteScript("arguments[0].value='" + value + "';", WaitForElement(locator));
        }
        protected void ClickJavaScript(By locator)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].click();", WaitForElement(locator));
        }

        protected void ClickCheckBoxAndRadioBoxJavaScript(By locator)
        {
            javaScriptExecutor.ExecuteScript("arguments[0].click();", WaitForElementNotClickable(locator));
        }
        
        protected void ScrollToElementJavaScript(By locator)
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));
            IWebElement element = driver.FindElement(locator);
            javaScriptExecutor.ExecuteScript("arguments[0].scrollIntoView(true);", WaitForElement(locator));
        }

        protected void ScrollToTop()
        {
            javaScriptExecutor.ExecuteScript("window.scrollTo(0, 0);");
        }
        #endregion

        #region Default Actions
        public void Refresh()
        {
            DriverFactory.INSTANCE.Navigate().Refresh();
        }

        public void NavigateTo(string url)
        {
            DriverFactory.INSTANCE.Navigate().GoToUrl(url);
        }

        public void OpenNewTab()
        {
            javaScriptExecutor.ExecuteScript("window.open();");
        }

        public void SetFocusToLastTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public void SetFocusToFirstTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public string GetTitle()
        {
            string title = driver.Title;

            return title;
        }

        public string GetURL()
        {
            string url = driver.Url;

            return url;
        }
        #endregion
    }
}
