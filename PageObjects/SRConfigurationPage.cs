using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class SRConfigurationPage
    {
        private IWebDriver Driver;
        HomePage homePage;
        Scaleconfig scaleConfigurationPage;
        ConfigurationPage configurationPage;

        public SRConfigurationPage(IWebDriver driver)
        {
            Driver = driver;
            scaleConfigurationPage = new Scaleconfig(driver);
            homePage = new HomePage(Driver);
            configurationPage = new ConfigurationPage(Driver);
        }

        IWebElement HQNewContentSymbolName => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]"));
        IWebElement NewContentSymbolNameEdit => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]/div/div/div[1]/input"));
        IWebElement SRContentSymbolName => Driver.FindElement(By.XPath("//*[@id='gridSCLCNTSYMB']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]"));
        IWebElement EditContentSymbol => Driver.FindElement(By.XPath("(//div[@ng-click='ctrl.toggleEditMode(false)'])[2]"));

        IWebElement PrintFormatcodeverification => Driver.FindElement(By.XPath("//*[text()='OpenSansBiscuits']"));

        IWebElement ContentSymbolTab => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[3]"));

        public void CompareDetails()
        {
            Thread.Sleep(3000);
            string SearchContentSymbol = homePage.getConfiguration("TestData.json", "SrchContentSymbol");
            configurationPage.SearchContentSymbol(SearchContentSymbol);
            EditContentSymbol.Click();
            HQNewContentSymbolName.Click();
            string ContentSymbolnew = NewContentSymbolNameEdit.GetAttribute("value").ToString();
            Driver.SwitchTo().Window(Driver.WindowHandles[1]); //switches to SR tab
            ContentSymbolTab.Click();
            Thread.Sleep(3000);
            configurationPage.SearchContentSymbol(SearchContentSymbol);
            Thread.Sleep(3000);
            string SRvalue = SRContentSymbolName.Text;
            Debug.Assert(SRvalue == ContentSymbolnew);
            Driver.SwitchTo().Window(Driver.WindowHandles[0]);
        }

        public void ComparePrintFormat(string searchcode , string verifytext)
        {
            Thread.Sleep(3000);
            //string SearchContentSymbol = homePage.getConfiguration("TestData.json", "SrchContentSymbol");
            string printformattext = searchcode;
            configurationPage.Printformat(printformattext);
            string Printformattextvalue = PrintFormatcodeverification.Text;
            Assert.AreEqual(Printformattextvalue, verifytext);
            
        }
    }
}
