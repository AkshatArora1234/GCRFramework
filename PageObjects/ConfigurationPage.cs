using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    class ConfigurationPage
    {
        private IWebDriver Driver;
        HomePage homePage;
      

        public ConfigurationPage(IWebDriver driver)
        {
            Driver = driver;
            homePage = new HomePage(driver);
            
        }

        IWebElement ScaleConfigurationTab => Driver.FindElement(By.XPath("(//span[text()='Scale Configuration'])[2]"));
        IWebElement ConfigurationTab => Driver.FindElement(By.XPath("//a/uib-tab-heading[text()='Configuration']"));
        IWebElement ContentCodeSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[5]"));
        IWebElement EditContentSymbol => Driver.FindElement(By.XPath("(//div[@ng-click='ctrl.toggleEditMode(false)'])[2]"));
        IWebElement NewContentSymbolName => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]"));
        private CustomControls NewContentSymbolNameEdit => new CustomControls(Driver, By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[2]/div/div/div[1]/input"));
        IWebElement NextElement => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[5]/div/table/tbody/tr[2]/td[2]/div/div/div/div/div[1]/input"));
        IWebElement NextElementClick => Driver.FindElement(By.XPath("//*[@id='gridCONTSYM']/div/div[6]/div/div/div[1]/div/table/tbody/tr[1]/td[3]/div/div/div[1]/input"));
        IWebElement ContentSymbolSave => Driver.FindElement(By.XPath("(//span[text()='Save'])[1]"));
        IWebElement ContentSymbolSaveYes => Driver.FindElement(By.Id("submitButton"));
        IWebElement NutriSearch => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[16]"));
        IWebElement DeleteNutriPanel => Driver.FindElement(By.XPath("//*[@id='gridSCALENP']/div/div[6]/div[1]/div/div/div/table/tbody/tr[1]/td/div/div/div[@class='action-delete ng-scope']"));
        IWebElement DeleteNutriYes => Driver.FindElement(By.Id("submitButton"));
        IWebElement NutriDeletemessage => Driver.FindElement(By.XPath("//p[@class='ng-binding']"));
        IWebElement LinkNutriNo => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.deleteWithoutLinking()']"));



        public void PageNavigationToScaleConfigPage() =>  ScaleConfigurationTab.Click();
        public void PageNavigationToConfigPage() => ConfigurationTab.Click();
        
        public void SearchContentSymbol(string text) => ContentCodeSearch.SendKeys(text);

        public void EditContent(string text)
        {
            Thread.Sleep(3000);
            EditContentSymbol.Click();
            NewContentSymbolName.Click();
            NewContentSymbolNameEdit.FillUsingJavascipt(text);
            NextElement.Click();
            ////   Driver.Navigate().Refresh();
            //configurationPage.PageNavigationToScaleConfigPage();
            //configurationPage.PageNavigationToConfigPage();
            //EditContentSymbol.Click();
            //NewContentSymbolName.Click();
            //NewContentSymbolNameEdit.FillUsingJavascipt(text);
            //Actions act = new Actions(Driver);
            //act.SendKeys(Keys.Tab);
            ContentSymbolSave.Click();
            ContentSymbolSaveYes.Click(); 
        }

        public void NutriPanelSearch(string text) => NutriSearch.SendKeys(text);
        public void DeleteNutrionalPanel()
        {
            Actions action = new Actions(Driver);
            action.Click(DeleteNutriPanel);
            action.Perform();
            Thread.Sleep(3000);
            if (NutriDeletemessage.Text.Equals("Nutritional panel 'Coco cola' is in use. Link items to another nutritional panel?"))
            {
                LinkNutriNo.Click();
            }
            else
            {
                DeleteNutriYes.Click();
            }
        }
    }
}
