using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class Scaleconfig
    {

        private IWebDriver Driver;
        public Scaleconfig(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement SideMenu => Driver.FindElement(By.XPath("//div[@class='SideMenuWrapper SideMenuWrapperSmall']"));
        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@id='search-text']"));
        IWebElement ElementClick => Driver.FindElement(By.XPath("//span/strong[text()='Item Maintenance in HQ mode']"));
        IWebElement NewItembutton => Driver.FindElement(By.XPath("(//span[text()='New'])[7]"));
        IWebElement EnterBarcode => Driver.FindElement(By.XPath("//input[@name='barcode']"));
        IWebElement EnterItemDescription => Driver.FindElement(By.XPath("//input[@name='itemDescription']"));
        IWebElement EnterDropDown => Driver.FindElement(By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine has-options'])[1]"));
        IWebElement EnterDropDown1 => Driver.FindElement(By.XPath("(//div[@class='selectize-input items not-full ng-valid ng-pristine'])[3]"));
        IWebElement LeftMenu => Driver.FindElement(By.XPath("//*[@class='SideMenuWrapper SideMenuWrapperSmall']//*[@class='fa fa-bars N_P_A']"));
        IWebElement ScaleConfigurationMenu => Driver.FindElement(By.XPath("//span/strong[text()='Scale Configuration']"));

        IWebElement EnterCode => Driver.FindElement(By.XPath("(//*[@name='pFCode'])"));
        IWebElement EnterPrintFormat => Driver.FindElement(By.XPath("(//*[@name='pFName'])"));

        IWebElement Save => Driver.FindElement(By.XPath("//button[@class='button-save ng-scope']"));

        IWebElement ClickEdit => Driver.FindElement(By.XPath("(//*[contains(text(),'OpenSansBiscuits')])[2]"));

        IWebElement CheckProductlife => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasProductLife']"));
       // (//*[@class='ng-pristine ng-valid ng-empty ng-touched'])

        //Print Format
        IWebElement TabPrintFormat => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[2]"));
        public By TexBoxLocator { get; private set; }

        // private string jsonFile = @"C:\Source\Specflow_MSTest FrameWork\SpecFlow_MSTestFrameWork\bin\Debug\netcoreapp3.1\TestData.json";

        public void SearchForKeyword()
        {
            SideMenu.Click();
            /*var json = File.ReadAllText("TestData.json");
            var jObject = JObject.Parse(json);
            var searchItem = jObject["item"];*/
            Searchbar.SendKeys("Scale Configuration");
            ElementClick.Click();
        }

        public void CreateNewItem()
        {
            Thread.Sleep(5000);
            NewItembutton.Click();
            Random rand = new Random();
            int number = rand.Next(0, 9999);
            EnterBarcode.SendKeys("1" + number);
            EnterItemDescription.SendKeys("Test" + number);
            EnterDropDown.Click();
            Actions keyDown = new Actions(Driver);
            keyDown.SendKeys(Keys.Enter).SendKeys(Keys.End).Build().Perform();
            keyDown.SendKeys(Keys.Escape).Build().Perform();
                     

        }


        //Actions

        public void ClickLeftMenu()
        {
            Thread.Sleep(4000);
            LeftMenu.Click();
        }
        // customcontrol.Click();

        public void ScaleConfiguration()
        {
            Searchbar.SendKeys("Scale Configuration");
        }

        public void MenuScaleConfigurationClick()
        {
            ScaleConfigurationMenu.Click();
        }

        public void TabPrintFormatClick()
        {
            TabPrintFormat.Click();
        }

        public void ClickNewButton()
        {
            NewItembutton.Click();
        }

        public void EnterCodeandName(string code, string name)
        {
            EnterCode.SendKeys("12");
            EnterPrintFormat.SendKeys("OpenSansBiscuits");
            Save.Click();


        }

        public void EditCode()
        {
            Actions actions = new Actions(Driver);
            
            actions.DoubleClick(ClickEdit).Perform();
            
        }

        public void Checkboxes()
        {
            CheckProductlife.Click();
            System.Threading.Thread.Sleep(5000);
        }


    }
}
