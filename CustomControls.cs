using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecFlow_MSTestFrameWork
{
    public class CustomControls : DriverHelper
    {
        public By TexBoxLocator { get; }
        public IWebDriver Driver { get; }

        public CustomControls(IWebDriver driver, By texBoxLocator)
        {
            TexBoxLocator = texBoxLocator;
            Driver = driver;
        }


        public void EnterText(IWebElement webElement, string value)
        {
            webElement.Click();
            webElement.Clear();
            webElement.SendKeys(value);
        }
        public void Click(IWebElement webElement) => webElement.Click();

        public void SelectByValue(IWebElement webElement, string value)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByValue(value);
        }

        public void SelectByText(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);
            selectElement.SelectByText(text);
        }

        public void FindByXpath(IWebElement webElement, string element)
        {

        }

        public void SelectByOption(IWebElement webElement, string text)
        {
            SelectElement selectElement = new SelectElement(webElement);

        }

        public void SelectType(string text)
        {
            var textBoxElement = Driver.FindElement(TexBoxLocator);
            textBoxElement.Click();
            Actions keyDown = new Actions(Driver);
            keyDown.SendKeys(Keys.Down).SendKeys(Keys.Down).SendKeys(Keys.Enter).SendKeys(Keys.End).Build().Perform();
        }

        public void SelectByText(string text)
        {
            var textBoxElement = Driver.FindElement(TexBoxLocator);
            SelectElement selectElement = new SelectElement(textBoxElement);
            selectElement.SelectByText(text);
        }

        public void FillUsingJavascipt(string text)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            var element = Driver.FindElement(TexBoxLocator);
            js.ExecuteScript("arguments[0].scrollIntoView();", element);
            js.ExecuteScript("arguments[0].value=arguments[1];", element, text);
        }

        public void GetSelectedTextFromDropDown()
        {
            SelectElement oSelection = new SelectElement((IWebElement)Driver);
            string element = oSelection.SelectedOption.Text;
        }
        public void RightClick(IWebElement webElement)
        {
            Actions actions = new Actions(Driver);
            actions.ContextClick(webElement).Perform();
        }
        public void Double_Click(IWebElement webElement)
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(webElement).Perform();
        }
        public void MoveToAElement(IWebElement webElement)
        {
            Actions actions = new Actions(Driver);
            actions.MoveToElement(webElement).Perform();
        }
        public static IWebElement IsELementLoaded(IWebDriver driver, IWebElement elementtobeloaded, TimeSpan Time)
        {
            WebDriverWait Wait = new WebDriverWait(driver, Time);
            IWebElement element = Wait.Until(ExpectedConditions.ElementIsVisible((By)elementtobeloaded));
            return element;
        }
        public static IWebElement WaitforElementclickable(IWebDriver driver, IWebElement elementtobeloaded, TimeSpan Time)
        {
            WebDriverWait Wait = new WebDriverWait(driver, Time);
            IWebElement element = Wait.Until(ExpectedConditions.ElementToBeClickable((By)elementtobeloaded));
            return element;
        }
        public static Boolean WaitForTextToBePresentInElement(IWebDriver driver, IWebElement elementTobeLoaded, TimeSpan Time, String textTobeDisplayed)
        {
            WebDriverWait wait = new WebDriverWait(driver, Time);
            Boolean Element = wait.Until(ExpectedConditions.TextToBePresentInElement(elementTobeLoaded, textTobeDisplayed));
            return Element;
        }
        public void IsCheckboxSelected(IWebElement checkboxElement)
        {
            Boolean Isselected = checkboxElement.Selected;
            if(Isselected==false)
            {
                checkboxElement.Click();
            }
        }
        public void IsCheckboxDisplayed(IWebElement checkboxElement)
        {
            Boolean IsDisplayed = checkboxElement.Displayed;
            if (IsDisplayed == true)
            {
                checkboxElement.Click();
            }
        }

        public static void IsAlertLoaded(IWebDriver driver, TimeSpan Time)
        {
            WebDriverWait wait = new WebDriverWait(driver, Time);
            wait.Until(ExpectedConditions.AlertIsPresent());
        }
        public static void AcceptAlert(IWebDriver driver)
        {
            driver.SwitchTo().Alert().Accept();
        }
        public static void WaitFixedDurationSecs(int seconds)
        {
            Thread.Sleep(1000);
        }
        public static string GetCurrentDate()
        {
            return Math.Round(DateTime.UtcNow
                                .Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc))
                                .TotalMilliseconds, 0).ToString();
        }

        public static string GetStringOfRandomChars(int lenght)
        {
            var randomString = Path.GetRandomFileName();
            randomString = randomString.Replace(".", "");
            return randomString.Substring(0, lenght);
        }
    }
}

