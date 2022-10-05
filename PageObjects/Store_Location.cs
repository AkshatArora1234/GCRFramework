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
 public class Store_Location
    {
        private IWebDriver Driver;
        HomePage homePage;
        string LocSearch;
        string PFName;
        
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
        IWebElement StoreLocation => Driver.FindElement(By.XPath("(//uib-tab-heading[text()='Stores / Locations'])[2]"));
        IWebElement Scale_Store => Driver.FindElement(By.XPath("(//uib-tab-heading[text()='Stores / Locations'])[1]"));
        IWebElement EnterLocationCode => Driver.FindElement(By.XPath("(//input[@role='spinbutton'])[4]"));
        IWebElement LocationName => Driver.FindElement(By.XPath("//div[text()='Location Name']"));
        IWebElement Locationsearchbox => Driver.FindElement(By.XPath("(//div[@class='dx-show-invalid-badge dx-textbox dx-texteditor dx-editor-outlined dx-widget'])[3]"));
        IWebElement LocationSelect => Driver.FindElement(By.XPath($"(//td[text()='{LocSearch}'])[2]"));
        IWebElement EditItem => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Enable Editing'])[6]"));
        IWebElement StoreItemDropDown => Driver.FindElement(By.XPath("//div[@class='dx-show-invalid-badge dx-selectbox dx-textbox dx-texteditor dx-dropdowneditor-button-visible dx-editor-outlined dx-texteditor-empty dx-widget dx-dropdowneditor dx-dropdowneditor-field-clickable']"));
        IWebElement SelectPF => Driver.FindElement(By.XPath($"(//div[text()='{PFName}'])[2]"));
        IWebElement PFTab => Driver.FindElement(By.XPath("(//div[text()='Print Formats'])[2]"));
        IWebElement SaveItem => Driver.FindElement(By.XPath("(//button[@class='button-save ng-scope'])[2]"));
        IWebElement ScaleConfigTab => Driver.FindElement(By.XPath("(//span[text()='Scale Configuration'])[2]"));
        IWebElement DeleteLoc => Driver.FindElement(By.XPath("(//i[@ng-click='ctrl.actions.deleteData(row.data)'])[63]"));
        IWebElement ConfirmDelete => Driver.FindElement(By.XPath("//button[@id='submitButton']"));
        IWebElement ItemTab => Driver.FindElement(By.XPath("//span[@uib-tooltip='Item (HQ): LADOTYRI MITILINIS']"));
        IWebElement PublishItem => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Publish'])[3]"));


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


        public void ClickItemStoreLocation() => StoreLocation.Click();
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
        public void CreateLocation(string code, string name)
        {
            Thread.Sleep(2000);
            // StoreNameClick.Click();
            Storename.Click();
            locCode.SendKeys(code);
            locName.SendKeys(name);
            Thread.Sleep(1000);
            locName.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
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
        public void DeleteLocation(string locCode)
        {
            Thread.Sleep(1000);
            ScaleConfigTab.Click();
            Thread.Sleep(2000);
            Scale_Store.Click();
            Thread.Sleep(3000);
            LocationName.Click();
            Thread.Sleep(2000);
            EnterLocationCode.SendKeys(locCode);
            Thread.Sleep(1000);
            DeleteLoc.Click();
            Thread.Sleep(1000);
            ConfirmDelete.Click();
            Thread.Sleep(1000);

        }
        public void PublishLocFromItem(string LocName)
        {
            LocSearch = LocName;
            ItemTab.Click();
            StoreLocation.Click();
            //Locationsearchbox.SendKeys(LocName);
            //LocationSelect.Click();
            PublishItem.Click();

        }

        public void AddPFAndLocationFromItem(string locname, string PFname)
        {
            Actions actions = new Actions(Driver);
            LocSearch = locname;
            PFName = PFname;
            EditItem.Click();
            Locationsearchbox.Click();
            LocationSelect.Click();
            actions.DoubleClick(StoreItemDropDown).Perform();
            SelectPF.Click();
            PFTab.Click();
            SaveItem.Click();
            Thread.Sleep(2000);

        }
        public void storeLocationRowOneSelect()
        {
            storeLocationRowOne.Click();
        }

    }
}
