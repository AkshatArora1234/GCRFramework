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
        String PFname;
        string columChoosed;

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
        IWebElement LocSearchbox => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[9]"));
        IWebElement LocSearchboxSR => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[6]"));
        IWebElement RecordsFound => Driver.FindElement(By.XPath("//span[text()='No records found']"));
        private CustomControls VendorSelection => new CustomControls(Driver, By.XPath("//div[@class='selectize-control ng-pristine ng-untouched ng-valid ng-scope ng-isolate-scope single']"));
        IWebElement PFSelection => Driver.FindElement(By.XPath("//button[@ng-click='toggleDropdown()']"));
        IWebElement SelectPF => Driver.FindElement(By.XPath($"//span[text()='{PFname}']"));
        IWebElement SaveCloseLoc => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.submit(1)']"));
        IWebElement flagCheckbox => Driver.FindElement(By.XPath($"//span[text()='{columChoosed}']/ancestor::div/input[@type='checkbox']"));


        public void AddNewSRLocation()
        {
            try
            {
                NewLocation.Click();
            }
            catch(Exception e)
            {
                Thread.Sleep(5000);
                NewLocation.Click();
            }
        }
        public void SaveandClosePFinSR() => SaveClosePF.Click();
        public void NewSRPFbuttonClick() => NewPF.Click();
        public void AddVendorinLoc() => VendorSelection.SelectType("Wedderburn");
        public void LinkPFinLoc(string pfname)
        {
            PFname = pfname;
            PFSelection.Click();
            SelectPF.Click();
        }
        public void SaveandCloseLocinSR() => SaveCloseLoc.Click();
        public void NavigateToLocationTab()
        {
            Thread.Sleep(4000);
            LocationTab.Click();
        }
        public void SearchLocationInSR(string locCode)
        {
            LocSearchbox.Clear();
            Thread.Sleep(1000);
            LocSearchbox.SendKeys(locCode);
            Thread.Sleep(5000);
        }
        public void SearchDeletedLocationInSR(string locCode)
        {
            Thread.Sleep(1500);
            LocSearchboxSR.SendKeys(locCode);
            Thread.Sleep(1000);
            Assert.AreEqual("No records found", RecordsFound.Text);
            Thread.Sleep(500);
        }
        public void SearchPFInSR(string pfcode)
        {
            PFSearchbox.Clear();
            Thread.Sleep(1000);
            PFSearchbox.SendKeys(pfcode);
            Thread.Sleep(5000);
        }
        public void SRLocationCreation(string code, string name)
        {
            locCode.SendKeys(code);
            locName.SendKeys(name);
            Save.Click();
            Thread.Sleep(2000);
        }

        public void SRPFCreation(string code, string name)
        {
            EnterPFCode.SendKeys(code);
            EnterPFName.SendKeys(name);
            Save.Click();
            Thread.Sleep(2000);
        }

        public void EditPFinSR()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromPFTable).Perform();
            Thread.Sleep(3000);
        }

        public void EditLocationinSR()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromLocationTable).Perform();
            Thread.Sleep(3000);
        }  
        public void setFlagToTrue(string column)
        {
            columChoosed = column;
            flagCheckbox.Click();
        }
    }
}
