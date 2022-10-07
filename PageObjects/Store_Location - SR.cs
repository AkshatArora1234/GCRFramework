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
 public class Store_Location_SR
    {
        private IWebDriver Driver;
        HomePage homePage;
        
        
        public Store_Location_SR(IWebDriver driver)
        {
            Driver = driver;
            homePage = new HomePage(Driver);    
        }
  
       

        IWebElement LocationTab => Driver.FindElement(By.XPath("//a[@ng-click='select($event)']//uib-tab-heading[text()='LOCATION']"));
        IWebElement NewLocation => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.addScaleLocation()']"));
        IWebElement locCode => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationNumber']"));
        IWebElement locName => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.locationName']"));
        IWebElement Save => Driver.FindElement(By.XPath("//span[text()='Save']"));
        IWebElement NewPF => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.gotoAddPrintFormat()']"));
        IWebElement EnterPFCode => Driver.FindElement(By.XPath("//*[@name='printFormatCode']"));
        IWebElement EnterPFName => Driver.FindElement(By.XPath("//*[@name='printFormatName']"));
        IWebElement PFSearchbox => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[6]"));
        IWebElement ElementSelectFromPFTable => Driver.FindElement(By.XPath("//*[@id='gridSCLPRINTFT']/div/div[6]/div/div/div[1]/div/table/tbody/tr[last()-1]/td[1]"));
        IWebElement ElementSelectFromLocationTable => Driver.FindElement(By.XPath("//*[@id='gridSCALELOC']/div/div[6]/div/div/div[1]/div/table/tbody/tr[last()-1]/td[1]"));
        IWebElement SaveClosePF => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(ctrl.editPrintFormatForm,1)']"));
        IWebElement LocSearchbox => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(ctrl.editPrintFormatForm,1)']"));
        private CustomControls VendorSelection => new CustomControls(Driver, By.XPath("//div[@class='selectize-input items not-full ng-valid ng-pristine has-options']"));
        private CustomControls PFSelection => new CustomControls(Driver, By.XPath("//button[@ng-click='toggleDropdown()']"));
        IWebElement SaveCloseLoc => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(1)']"));



        public void NavigateToLocationTab() => LocationTab.Click();
        public void AddNewSRLocation() => NewLocation.Click();
        public void SearchPFInSR(string pfcode) => PFSearchbox.SendKeys(pfcode);
        public void SearchLocationInSR(string locCode) => LocSearchbox.SendKeys(locCode);
        public void SaveandClosePFinSR() => SaveClosePF.Click();
        public void NewSRPFbuttonClick() => NewPF.Click();
        public void AddVendorinLoc() => VendorSelection.SelectByText("Wedderburn");
        public void LinkPFinLoc(string pfname) => PFSelection.SelectByText(pfname);
        public void SaveandCloseLocinSR() => SaveCloseLoc.Click();
        public void SRLocationCreation(string code, string name)
        {
            locCode.SendKeys(code);
            locName.SendKeys(name);
            Save.Click();
        }

        public void SRPFCreation(string code, string name)
        {
            EnterPFCode.SendKeys(code);
            EnterPFName.SendKeys(name);
            Save.Click();
        }

        public void EditPFinSR()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromPFTable).Perform();
        }

        public void EditLocationinSR()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromLocationTable).Perform();
        }       

    }
}
