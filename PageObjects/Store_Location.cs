using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
        IWebElement NewLocation=> Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createStoreLocation()']"));

        public void TabStore_LocationClick() => TabStore_Location.Click();
        public void AddNewStoreLocation() => NewLocation.Click();



    }
}
