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
        string columChoosed;
        
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
        IWebElement ProductlifeSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isProductLife']"));
        IWebElement SellBySR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isSellBy']"));
        IWebElement TareSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isTare']"));
        IWebElement ContentSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isContent']"));
        IWebElement PresetmessagesSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isPresetMessages']"));
        IWebElement PrintdateformatSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isPackedOn']"));
        IWebElement CookingTimeSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isCookingTime']"));
        IWebElement PerKGSR => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.isPerKG']"));
        IWebElement SaveAndClosePF => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(ctrl.editPrintFormatForm,1)']"));
        IWebElement storeNameTxtBox => Driver.FindElement(By.XPath("(//div [contains (@class ,'selectize-input')])[1]"));
        IWebElement Storename => Driver.FindElement(By.XPath("//div[text()='Kingston (1500)']"));
        IWebElement locCode => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationCode']"));
        IWebElement locName => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationName']"));
        IWebElement SaveLocation => Driver.FindElement(By.XPath("//span[text()='Save']"));
        IWebElement storeLocationRowOne => Driver.FindElement(By.XPath("(//div[text()='Location Name']/ancestor::div[@class='item-list-table clearfix']//table[@class='dx-datagrid-table dx-datagrid-table-fixed'])[2]//tr[1]"));
        //IWebElement ShowColumnChooser => Driver.FindElement(By.XPath("(//div[@aria-label='Show Column Chooser'])[6]"));
        IWebElement ShowColumnChooser => Driver.FindElement(By.XPath("//gm-grid[@grid-id=\"'scaleStoreLocationGrid'\"]//div[@aria-label='Show Column Chooser']"));
        IWebElement Search => Driver.FindElement(By.XPath("//input[@aria-label='Search']"));
        IWebElement ClearSearch => Driver.FindElement(By.XPath("//span[@class='dx-icon dx-icon-clear']"));
        IWebElement DDFrom => Driver.FindElement(By.XPath($"//div[@class='dx-scrollable-container']//div[text()='{columChoosed}']"));
        IWebElement DDFrom2 => Driver.FindElement(By.XPath($"//div[text()='{columChoosed}']"));
        IWebElement DDTo => Driver.FindElement(By.XPath("(//div[text()='Location Code']/ancestor::div[@class='item-list-table clearfix']//table[@class='dx-datagrid-table dx-datagrid-table-fixed'])[1]"));
        IWebElement DDTo2 => Driver.FindElement(By.XPath("//div[@aria-label='A place to hide the columns']"));
        IWebElement columnChooserClosebtn => Driver.FindElement(By.XPath("//i[@class='dx-icon dx-icon-close']"));
        IWebElement StoreLocation => Driver.FindElement(By.XPath("(//uib-tab-heading[text()='Stores / Locations'])[2]"));
        IWebElement Scale_Store => Driver.FindElement(By.XPath("(//uib-tab-heading[text()='Stores / Locations'])[1]"));
        IWebElement EnterLocationCode => Driver.FindElement(By.XPath("//gm-grid[@grid-id=\"'scaleStoreLocationGrid'\"]//input[@role='spinbutton']"));

        IWebElement LocationName => Driver.FindElement(By.XPath("//div[text()='Location Name']"));
        IWebElement LocationSelect => Driver.FindElement(By.XPath($"(//td[text()='{LocSearch}'])[2]"));
        IWebElement EditItem => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Enable Editing'])[6]"));
        IWebElement SelectPF => Driver.FindElement(By.XPath($"(//div[text()='{PFName}'])[2]"));
        IWebElement PFTab => Driver.FindElement(By.XPath("(//div[text()='Print Formats'])[2]"));
        IWebElement SaveItem => Driver.FindElement(By.XPath("(//button[@class='button-save ng-scope'])[2]"));
        IWebElement ScaleConfigTab => Driver.FindElement(By.XPath("(//span[text()='Scale Configuration'])[2]"));
        IWebElement Confirm => Driver.FindElement(By.XPath("//button[@id='submitButton']"));
        IWebElement ItemTab => Driver.FindElement(By.XPath("//span[@uib-tooltip='Item (HQ): LADOTYRI MITILINIS']"));
        IWebElement PublishItem => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Publish'])[3]"));
        IWebElement EditStoreLocation => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Enable Editing'])[5]"));
        IWebElement LocNameCell => Driver.FindElement(By.XPath("(//td[contains(@class,'inline_edit_enabled_cell')])[3]"));
        IWebElement CommodityFlagCell => Driver.FindElement(By.XPath("(//td[@class='inline_edit_enabled_cell'])[3]"));
        IWebElement CommodityFlagChkbx => Driver.FindElement(By.XPath("//span[@class='dx-checkbox-icon']"));
        IWebElement CommodityFlagValue => Driver.FindElement(By.XPath("//span[@class='dx-checkbox-icon']/ancestor::div/input"));
        IWebElement SaveStores => Driver.FindElement(By.XPath("//span[text()='Save']/ancestor::a"));
        IWebElement Cancel => Driver.FindElement(By.XPath("//button[@class='button-cancel']"));
        IWebElement SelectLoc => Driver.FindElement(By.XPath($"(//td[text()='{LocSearch}'])[1]"));
        IWebElement Locationsearchbox => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[106]"));
        IWebElement StoreItemDropDown => Driver.FindElement(By.XPath("(//td[@class='inline_edit_enabled_cell'])[31]"));
        IWebElement DeleteLoc => Driver.FindElement(By.XPath("(//i[@class='fa fa-trash-o ng-scope'])[73]"));

        public void TabStore_LocationClick() => TabStore_Location.Click();
        public void AddNewStoreLocation() => NewLocation.Click();
        public void CheckProductlife() => Productlife.Click();
        public void CheckSellBy() => SellBy.Click();
        public void CheckTare() => Tare.Click();
        public void CheckPresetmessages() => Presetmessages.Click();
        public void CheckPrintdateformat() => Printdateformat.Click();
        public void CheckContent() => Content.Click();
        public void CheckCookingTime() => CookingTime.Click();
        public void CheckPerKG() => PerKG.Click();
        public void CheckProductlifeSR() => ProductlifeSR.Click();
        public void CheckSellBySR() => SellBySR.Click();
        public void CheckTareSR() => TareSR.Click();
        public void CheckPresetmessagesSR() => PresetmessagesSR.Click();
        public void CheckPrintdateformatSR() => PrintdateformatSR.Click();
        public void CheckContentSR() => ContentSR.Click();
        public void CheckCookingTimeSR() => CookingTimeSR.Click();
        public void CheckPerKGSR() => PerKGSR.Click();
        public void SavePFAndClose() => SaveAndClosePF.Click();


        public void ClickItemStoreLocation() => StoreLocation.Click();
        public void CreateNewLocation(string code, string name)
        {
            Thread.Sleep(2000);
            storeNameTxtBox.Click();
            Storename.Click();
            locCode.SendKeys(code);
            locName.SendKeys(name);
            // Thread.Sleep(1000);
            // SaveLocation.Click();
            Thread.Sleep(1000);
            locName.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
        }
        public void CreateLocation(string code, string name)
        {
            Thread.Sleep(2000);
            try
            {
                Storename.Click();
            }
            catch (Exception e)
            {
                Cancel.Click();
                Thread.Sleep(4000);
                NewLocation.Click();
                Thread.Sleep(1000);
                Storename.Click();
            }

            locCode.SendKeys(code);
            locName.SendKeys(name);
            Thread.Sleep(1000);
            locName.SendKeys(Keys.Enter);
            Thread.Sleep(1000);
        }

        public void ChooseAColumn(string columnName)
        {
            columChoosed = columnName;
            Actions actions = new Actions(Driver);
            Thread.Sleep(3000);
            ShowColumnChooser.Click();
            Thread.Sleep(1000);
            //ClearSearch.Click();
            Thread.Sleep(1000);
            Search.SendKeys(columnName);
            Thread.Sleep(1000);
            actions.DragAndDrop(DDFrom, DDTo).Perform();
            Thread.Sleep(3000);
            //actions.DragAndDrop(DDFrom, DDTo).Perform();
            actions.Release();
            Thread.Sleep(1000);
            ClearSearch.Click();
            Thread.Sleep(1000);
            columnChooserClosebtnClick();
        }
        public void RemoveChoosedColumn(string columnName)
        {
            columChoosed = columnName;
            Actions actions = new Actions(Driver);
            Thread.Sleep(3000);
            ShowColumnChooser.Click();
            Thread.Sleep(1000);
            Search.SendKeys("Test");
            Thread.Sleep(1000);
            actions.DragAndDrop(DDFrom2, DDTo2).Perform();
            Thread.Sleep(3000);
           // actions.DragAndDrop(DDFrom, DDTo2).Perform();
            actions.Release();
            Thread.Sleep(1000);
            ClearSearch.Click();
            Thread.Sleep(1000);
            columnChooserClosebtnClick();
        }
        public void columnChooserClosebtnClick()
        {
            columnChooserClosebtn.Click();
        }
        public void EditStoreLocationClick()
        {
            EditStoreLocation.Click();
        }
        public void EditCommodityFlagToYes()
        {
            Thread.Sleep(1000);
            CommodityFlagCell.Click();
            if (GetCommodityFlagValue()== "false")
            CommodityFlagChkbx.Click();
            Thread.Sleep(1000);
            //LocNameCell.Click();
            EnterLocationCode.Click();
            Thread.Sleep(1000);
            SaveStores.Click();
            Thread.Sleep(1000);
            Confirm.Click();
            Thread.Sleep(1000);
        }
        public string GetCommodityFlagValue()
        {
            return CommodityFlagValue.GetAttribute("value");
        }
       
        public void searchLocation(string locCode)
        {
            Thread.Sleep(1000);
            ScaleConfigTab.Click();
            Thread.Sleep(2000);
            Scale_Store.Click(); ;
            Thread.Sleep(3000);
            LocationName.Click();
            Thread.Sleep(3000);
            EnterLocationCode.SendKeys(locCode);
            Thread.Sleep(1000);
        }
        public void DeleteLocation(string locCode)
        {
            Actions act = new Actions(Driver);
            Thread.Sleep(1000);
            ScaleConfigTab.Click();
            Thread.Sleep(2000);
            Scale_Store.Click();
            Thread.Sleep(3000);
            LocationName.Click();
            Thread.Sleep(2000);
            EnterLocationCode.SendKeys(locCode);
            Thread.Sleep(1000);
            act.MoveToElement(SelectLoc).Perform();
            Thread.Sleep(1000);
            DeleteLoc.Click();
            Thread.Sleep(1000);
            Confirm.Click();
            Thread.Sleep(1000);

        }
        
        public void PublishLocFromItem(string LocName)
        {
            LocSearch = LocName;
            ItemTab.Click();
            StoreLocation.Click();
            PublishItem.Click();

        }

        public void AddPFAndLocationFromItem(string locname, string PFname)
        {
            Actions actions = new Actions(Driver);
            LocSearch = locname;
            PFName = PFname;
            Thread.Sleep(2000);
            EditItem.Click();
            Thread.Sleep(1000);
            Locationsearchbox.Click();
            Thread.Sleep(2000);
            Locationsearchbox.SendKeys(locname);
            Thread.Sleep(1000);
            // actions.DoubleClick(StoreItemDropDown).Perform();
            StoreItemDropDown.Click();
            Thread.Sleep(1000);
            //    SelectPF.Click();
            PFTab.Click();
            //    SaveItem.Click();
            Thread.Sleep(2000);

        }
        public void storeLocationRowOneSelect()
        {
            storeLocationRowOne.Click();
        }

    }
}
