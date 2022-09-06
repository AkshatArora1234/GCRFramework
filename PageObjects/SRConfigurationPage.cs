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
        String VerifyText;
        public SRConfigurationPage(IWebDriver driver)
        {
            Driver = driver;
            scaleConfigurationPage = new Scaleconfig(driver);
            homePage = new HomePage(Driver);
            configurationPage = new ConfigurationPage(Driver);

        }
  
        //  IWebElement PrintFormatcodeverification => Driver.FindElement(By.XPath("//*[text()='OpenSansBiscuits']"));
        IWebElement SRcodeverification() => Driver.FindElement(By.XPath($"//*[text()='{VerifyText}']"));

/*      IWebElement taretextvalue => Driver.FindElement(By.XPath("//*[@name='scaleTareName']"));
        IWebElement tarevalues => Driver.FindElement(By.XPath("//*[@name='tareValue']"));
        IWebElement tarevalue => Driver.FindElement(By.XPath("//*[@name='scaleTareCode']"));
        IWebElement presetmessagetext => Driver.FindElement(By.XPath("//*[@name='presetMessage']"));
        IWebElement presetmessagecode => Driver.FindElement(By.XPath("//*[@name='scalePresetMessageCode']"));
        IWebElement ContentSymboltext => Driver.FindElement(By.XPath("//*[@name='contentSymName']"));
        IWebElement contentsymbolcode => Driver.FindElement(By.XPath("//*[@name='contentSymbolCode']"));
        IWebElement contentsymbolvalue => Driver.FindElement(By.XPath("//*[@name='contentSymDesc']"));*/



        public void ComparePrintFormat(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string printformattext = searchcode;
            configurationPage.Printformat(printformattext);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);
        }

        /* public void CompareTare(string searchcode, string verifytext)
         {
             VerifyText = verifytext;
             Thread.Sleep(3000);
             string text = searchcode;
             configurationPage.Tare(text);
             string textvalue = SRcodeverification.Text;
             Assert.AreEqual(textvalue, verifytext);

         }
         public void CompareContentSymbol(string searchcode, string verifytext, string contentsymbolvalues)
         {
             VerifyText = verifytext;
             Thread.Sleep(3000);
             string text = searchcode;
             configurationPage.SearchContentSymbol(text);
             string Contentsymboltext = ContentSymboltext.GetAttribute("value").ToString();
             string Contentsymbolcode = contentsymbolcode.GetAttribute("value").ToString();
             string ContectSymbolValue = contentsymbolvalue.GetAttribute("value").ToString();
             Assert.AreEqual(Contentsymboltext, verifytext);
             Assert.AreEqual(Contentsymbolcode, searchcode);
             Assert.AreEqual(ContectSymbolValue, contentsymbolvalues);
             scaleConfigurationPage.ClosePF();

         }


         public void ComparePresetMsg(string searchcode, string verifytext)
         {
             Thread.Sleep(3000);
             string text = searchcode;
             configurationPage.PM(text);
             string presetmessagetext1 = presetmessagetext.GetAttribute("value").ToString();
             string presetmessagecode1 = presetmessagecode.GetAttribute("value").ToString();
             Assert.AreEqual(presetmessagetext1, verifytext);
             Assert.AreEqual(presetmessagecode1, searchcode);
             scaleConfigurationPage.CloseSRpage();

         }

         public void CompareTare(string searchcode, string verifytext, string tarevaluesg)
         {
             Thread.Sleep(3000);
             //string SearchContentSymbol = homePage.getConfiguration("TestData.json", "SrchContentSymbol");
             string tare = searchcode;
             configurationPage.Tare(tare);
             string TareTextValue = taretextvalue.GetAttribute("value").ToString();
             string Tarecodevalue = tarevalue.GetAttribute("value").ToString();
             string Tarevalue = tarevalues.GetAttribute("value").ToString();
             Assert.AreEqual(TareTextValue, verifytext);
             Assert.AreEqual(Tarecodevalue, searchcode);
             Assert.AreEqual(Tarevalue, tarevaluesg);
             scaleConfigurationPage.CloseSRpage();


         }*/

        public void CompareTare(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.Tare(text);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
        public void CompareContentSymbol(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.SearchContentSymbol(text);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
        public void ComparePresetMsg(string searchcode, string verifytext)
        {
            VerifyText = verifytext;
            Thread.Sleep(3000);
            string text = searchcode;
            configurationPage.PM(text);
            Thread.Sleep(5000);
            string textvalue = SRcodeverification().Text;
            Assert.AreEqual(textvalue, verifytext);

        }
    }
}
