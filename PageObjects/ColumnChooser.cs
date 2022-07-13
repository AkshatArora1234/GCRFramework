using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class ColumnChooser
    {

        private IWebDriver Driver;
        HomePage homePage;
        public ColumnChooser(IWebDriver driver)
        {
            Driver = driver;
            homePage = new HomePage(driver);
        }

        IWebElement ShowColumnChooser => Driver.FindElement(By.XPath("(//div[@aria-label='Show Column Chooser'])[8]"));
        IWebElement Search => Driver.FindElement(By.XPath("//input[@aria-label='Search']"));
        IWebElement DDFrom => Driver.FindElement(By.XPath("//div[text()='Scale Item']"));
        IWebElement DDTo => Driver.FindElement(By.XPath("//*[@id='gridITEMHQ']/div/div[5]/div/table/tbody/tr[1]"));
        IWebElement ScaleItemDropDown => Driver.FindElement(By.XPath("(//div[@aria-label='Select'])[5]"));
        IWebElement FirstScaleElement => Driver.FindElement(By.XPath("//*[@id='gridITEMHQ']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[1]"));
        IWebElement ClickScaleTab => Driver.FindElement(By.XPath("(//a[@ng-click='select($event)'])[11]"));
        private CustomControls PFDropDown => new CustomControls(Driver,By.XPath("(//a[@ng-click='select($event)'])[11]"));


        public void ChooseAColumn()
        {
            ShowColumnChooser.Click();
            string scaleColumn = homePage.getConfiguration("TestData.json", "ColumnName");
            Search.SendKeys(scaleColumn);
            Actions actions = new Actions(Driver);
            actions.DragAndDrop(DDFrom, DDTo).Build().Perform();
            Thread.Sleep(5000);
        }
        

        public void SelectScaleValue()
        {
            ScaleItemDropDown.Click();
            Actions actions = new Actions(Driver);
            actions.SendKeys(Keys.Down).SendKeys(Keys.Enter).Perform();
            Thread.Sleep(8000);
        }

        public void SelectFirstScaleRecord()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(FirstScaleElement).Perform();
            Thread.Sleep(5000);
        }

        public void ClickScaleTabInItems() => ClickScaleTab.Click();

        public void SelectPFForItem() => PFDropDown.SelectByText("Popcorn");

    }
}
