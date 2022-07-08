using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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


        public void EnterText(IWebElement webElement, string value) => webElement.SendKeys(value);

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

        

         public void DoubleClickElement()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick().Perform();
        }

        public void ClickElement()
        {
            Actions actions = new Actions(Driver);
            actions.Click().Perform();
        }




    }
}

