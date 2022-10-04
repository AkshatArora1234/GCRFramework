using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class Store_Location
    {
        private IWebDriver Driver;
        HomePage homePage;
       
     
        public Store_Location(IWebDriver driver)
        {
            Driver = driver;
            homePage = new HomePage(Driver);
         
        }
  
       

        IWebElement TabStore_Location => Driver.FindElement(By.XPath("//a[@ng-click='select($event)']//uib-tab-heading[text()='Stores / Locations']"));
        IWebElement NewLocation => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createStoreLocation()']"));
        IWebElement Productlife => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasProductLife']"));
        IWebElement SellBy => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasSellBuy']"));
        IWebElement Tare => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasTare']"));
        IWebElement Content => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasContent']"));
        IWebElement Presetmessages => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasPresetMessage']"));
        IWebElement Printdateformat => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasPackedTime']"));
        IWebElement CookingTime => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasSellBuy']"));
        IWebElement PerKG => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasSellBuy']"));
        IWebElement SaveAndClosePF => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(ctrl.editPrintFormatForm,1)']"));
        IWebElement storeNameTxtBox => Driver.FindElement(By.XPath("(//div [contains (@class ,'selectize-input')])[1]"));
        IWebElement Storename => Driver.FindElement(By.XPath("//div[text()='Kingston (1500)']"));
        IWebElement locCode => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationCode']"));
        IWebElement locName => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationName']"));
        IWebElement SaveLocation => Driver.FindElement(By.XPath("//span[text()='Save']"));
        IWebElement storeLocationRowOne => Driver.FindElement(By.XPath("(//div[text()='Location Name']/ancestor::div[@class='item-list-table clearfix']//table[@class='dx-datagrid-table dx-datagrid-table-fixed'])[2]//tr[1]"));
        IWebElement storeLocationCodeTxtbx => Driver.FindElement(By.XPath("((//div[text()='Location Code']/ancestor::div[@class='item-list-table clearfix']//table[@class='dx-datagrid-table dx-datagrid-table-fixed'])[1]//td[@aria-colindex='2'])[2]"));
        IWebElement ShowColumnChooser => Driver.FindElement(By.XPath("(//div[@aria-label='Show Column Chooser'])[6]"));
        IWebElement Search => Driver.FindElement(By.XPath("//input[@aria-label='Search']"));
        IWebElement DDFrom => Driver.FindElement(By.XPath("//div[text()='Send Department/Commodity']"));
        IWebElement DDTo => Driver.FindElement(By.XPath("(//div[text()='Location Code']/ancestor::div[@class='item-list-table clearfix']//table[@class='dx-datagrid-table dx-datagrid-table-fixed'])[1]"));
        IWebElement columnChooserClosebtn => Driver.FindElement(By.XPath("//i[@class='dx-icon dx-icon-close']"));

        public void TabStore_LocationClick() => TabStore_Location.Click();
        public void AddNewStoreLocation() => NewLocation.Click();
        public void CheckProductlife() => Productlife.Click();
        public void CheckSellBy() => SellBy.Click();
        public void CheckTare() => Tare.Click();
        public void CheckPresetmessages() => Presetmessages.Click();
        public void CheckPrintdateformat() => Printdateformat.Click();
        public void CheckCookingTime() => CookingTime.Click();
        public void CheckPerKG() => PerKG.Click();
        public void SavePFAndClose() => SaveAndClosePF.Click();



        public void CreateNewLocation(string code, string name)
        {
            Thread.Sleep(2000);
            storeNameTxtBox.Click();
            Storename.Click();
            locCode.SendKeys(code);
            locName.SendKeys(name);
            Thread.Sleep(1000);
            SaveLocation.Click();
            Thread.Sleep(2000);
        }

        public void ChooseAColumn(string columnName)
        {
            Actions actions = new Actions(Driver);
            Thread.Sleep(3000);
            ShowColumnChooser.Click();
            Search.SendKeys(columnName);
            actions.DragAndDrop(DDFrom, DDTo).Perform();
            Thread.Sleep(3000);
            actions.DragAndDrop(DDFrom, DDTo).Perform();
            actions.Release();
            Thread.Sleep(1000);
            columnChooserClosebtnClick();
        }
        public void columnChooserClosebtnClick()
        {
            columnChooserClosebtn.Click();
        }
        public void storeLocationCodeTxtbxEnter(string locCode)
        {
            storeLocationCodeTxtbx.SendKeys(locCode);
            Thread.Sleep(1000);
        }
        public void storeLocationRowOneSelect()
        {
            storeLocationRowOne.Click();
        }

    }
}
