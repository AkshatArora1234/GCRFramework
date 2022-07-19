using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using OpenQA.Selenium.Support.UI;

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

        IWebElement FontNewButton => Driver.FindElement(By.XPath("(//span[text()='New'])[1]"));

        IWebElement TareNewButton => Driver.FindElement(By.XPath("(//span[text()='New'])[5]"));

        IWebElement PresetNewButton => Driver.FindElement(By.XPath("(//span[text()='New'])[4]"));

        IWebElement ContentNewButton => Driver.FindElement(By.XPath("(//span[text()='New'])[2]"));


        IWebElement NutritionalPanel => Driver.FindElement(By.XPath("(//span[text()='New'])[6]"));

        IWebElement LeftMenu => Driver.FindElement(By.XPath("//*[@class='SideMenuWrapper SideMenuWrapperSmall']//*[@class='fa fa-bars N_P_A']"));
        IWebElement ScaleConfigurationMenu => Driver.FindElement(By.XPath("//span/strong[text()='Scale Configuration']"));
        IWebElement ElementSelectFromTable => Driver.FindElement(By.XPath(" //*[@id='gridSCALEPF']/div/div[6]/div/div/div[1]/div/table/tbody/tr[last()-1]/td[1]"));
        IWebElement EnterCode => Driver.FindElement(By.XPath("(//*[@name='pFCode'])"));

        IWebElement EnterFontCode => Driver.FindElement(By.XPath("//*[@name='scaleFontCode']"));

        IWebElement EnterTareCode => Driver.FindElement(By.XPath("//*[@name='symbolCode']"));

        IWebElement EnterContenteCode => Driver.FindElement(By.XPath("//*[@name='symbolCode']"));

        IWebElement EnterContentName => Driver.FindElement(By.XPath("//*[@name='symbolName']"));

        IWebElement EnterContentValue => Driver.FindElement(By.XPath("//*[@name='scaleFontName']"));

        IWebElement EnterPresetCode => Driver.FindElement(By.XPath("//*[@name='scalePresetMessageCode']"));

        IWebElement EnterPresetMessage => Driver.FindElement(By.XPath("//*[@name='scalePresetMessage']"));

        IWebElement EnterTareName => Driver.FindElement(By.XPath("//*[@name='tareName']"));

        IWebElement EnterTareValue => Driver.FindElement(By.XPath("//*[@name='tareValue']"));

        IWebElement EnterNutritionalCode => Driver.FindElement(By.XPath("//*[@name='panelCode']"));

        IWebElement EnterNutritionalPrintFormat => Driver.FindElement(By.XPath("//*[@name='panelName']"));


        IWebElement EnterFontPrintFormat => Driver.FindElement(By.XPath("//*[@name='scaleFontName']"));

        IWebElement EnterPrintFormat => Driver.FindElement(By.XPath("(//*[@name='pFName'])"));

        IWebElement Save => Driver.FindElement(By.XPath("//button[@class='button-save ng-scope']"));

        IWebElement Savenew => Driver.FindElement(By.XPath("//*[@class='button-save']"));
        IWebElement Close => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.onCancel()']"));

        IWebElement ClickEdit => Driver.FindElement(By.XPath("(//*[contains(text(),'OpenSansBiscuits')])[1]"));

        IWebElement CheckProductlife => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasProductLife']"));
        IWebElement CheckTare => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasTare']"));

        IWebElement CheckContent => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasContent']"));

        IWebElement CheckPresetmessages => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasPresetMessage']"));

        IWebElement CheckPrintdateformat => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasPackedTime']"));

        IWebElement CheckHasContentSymbol => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasContentSymbol']"));

        IWebElement AddSection => Driver.FindElement(By.XPath("(//span[text()='Add Section'])[1]"));

        private CustomControls EnterFontValue => new CustomControls(Driver, By.XPath("//select[@ng-model='section.scaleFontId']"));

        private CustomControls NutritionalEmenetDropDownValue => new CustomControls(Driver, By.Id("nutritionalElementName"));

        private CustomControls MeasurmentDropDown => new CustomControls(Driver, By.XPath("//select[@name='nutritionalMeasurementsUnit']"));
        IWebElement AddDesc => Driver.FindElement(By.XPath("//input[@ng-model='section.sectionDescription']"));

        IWebElement ClickStore => Driver.FindElement(By.XPath("//*[@ng-disabled='selectDisabled']"));

        IWebElement PublishPF => Driver.FindElement(By.XPath("(//i[@ng-click='ctrl.actions.publishPrintFormat(row.data)'])[1]"));
        IWebElement DeletePF => Driver.FindElement(By.XPath("(//i[@ng-click='ctrl.actions.deletePrintFormat(row.data)'])[1]"));

        private CustomControls NutrionalTemplateDropdown => new CustomControls(Driver, By.XPath("//select[@name='nutritionalTemplateName-2']"));

        IWebElement SelectStore => Driver.FindElement(By.XPath("//*[@class='checkboxInput']"));
        IWebElement Deletebutton => Driver.FindElement(By.Id("submitButton"));
        IWebElement Clickok => Driver.FindElement(By.XPath("//*[text()='OK']"));

        IWebElement Searchbox => Driver.FindElement(By.XPath("(//*[@class='dx-texteditor-input'])[19]"));

        //Print Format- 
        IWebElement TabPrintFormat => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[2]"));
        IWebElement TabConfigration => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[1]"));
        IWebElement ClickEditNEWPF => Driver.FindElement(By.XPath("(//*[contains(text(),'OpenSansBiscuits1')])"));

        IWebElement ClickEditNutritionalPanel => Driver.FindElement(By.XPath("(//*[contains(text(),'ChocoCream')])"));

        IWebElement Manadatory => Driver.FindElement(By.XPath("(//input[@ng-model='section.isMandatory'])[1]"));
        IWebElement FixedWidth => Driver.FindElement(By.XPath("(//input[@ng-model='section.isFixedWidth'])[1]"));

        IWebElement Row => Driver.FindElement(By.XPath("//input[@name='rows--1']"));
        IWebElement Characters => Driver.FindElement(By.XPath("//input[@name='characters--1']"));

        IWebElement Manadatory2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.isMandatory'])[2]"));
        IWebElement FixedWidth2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.isFixedWidth'])[2]"));

        IWebElement AddDesc2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.sectionDescription'])[2]"));

        IWebElement Row_Font => Driver.FindElement(By.XPath("//input[@name='rows--3']"));
        IWebElement Characters_Font => Driver.FindElement(By.XPath("//input[@name='characters--3']"));

        private CustomControls EnterNutritionalFontValue => new CustomControls(Driver, By.XPath("(//select[@ng-model='section.scaleFontId'])[2]"));

        IWebElement Support_Basic_Mode => Driver.FindElement(By.XPath("//input[@ng-model='section.hasBasicMode']"));

        IWebElement HeaderRows => Driver.FindElement(By.XPath("//input[@id='header--rows--2']"));

        IWebElement TableRows => Driver.FindElement(By.XPath(" //input[@id='table--rows--2']"));
        IWebElement SearchCode => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[20]"));
        IWebElement ChangeCode => Driver.FindElement(By.Id("printFormatCode"));
        IWebElement ClickEditNice => Driver.FindElement(By.XPath("(//*[contains(text(),'NiceBiscuits')])[1]"));
        IWebElement PrintFormatName => Driver.FindElement(By.XPath("//*[@name='printFormatName']"));
        IWebElement NutrionalPanelName => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[17]"));

        IWebElement EnterValueinMask => Driver.FindElement(By.XPath("//*[@name='nutritional-ele-mask']"));
        public void ClickLeftMenu()
        {
            Thread.Sleep(4000);
            LeftMenu.Click();
        }

        public void ScaleConfiguration() => Searchbar.SendKeys("Scale Configuration");

        public void MenuScaleConfigurationClick() => ScaleConfigurationMenu.Click();

        public void TabPrintFormatClick() => TabPrintFormat.Click();

        public void TabConfiGrationClick() => TabConfigration.Click();

        public void ClickFontNewButton() => FontNewButton.Click();

        public void ClickTareNewButton() => TareNewButton.Click();

        public void ClickPresetNewButton() => PresetNewButton.Click();

        public void ClickContentSymbolNewButton() => ContentNewButton.Click();

        





        public void ClickNutritionalNewButton() => NutritionalPanel.Click();

        public void NutrionalPanelNam2(string nutritional)
        {
            Thread.Sleep(5000);
            NutrionalPanelName.SendKeys(nutritional);
        }
        public void EditNutritionalPanel()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditNutritionalPanel).Perform();
        }

        public void ClickNewButton() => NewItembutton.Click();

        public void EnterCodeandName(string code, string name)
        {
            EnterCode.SendKeys(code);
            EnterPrintFormat.SendKeys(name);
            Save.Click();
        }

        public void EnterFontCodeandName(string code, string name)
        {
            EnterFontCode.SendKeys(code);
            EnterFontPrintFormat.SendKeys(name);
            // Save.Click();
        }

        public void EnterTaretCodeNameValue(string code, string name, string value)
        {
            EnterTareCode.SendKeys(code);
            EnterTareName.SendKeys(name);
            EnterTareValue.SendKeys(value);
        }

        public void EnterContentCodeNameDescription(string code, string name, string value)
        {
            EnterContenteCode.SendKeys(code);
            EnterContentName.SendKeys(name);
            EnterContentValue.SendKeys(value);
        }

        public void EnterPresetCodeNameValue(string code, string name)
        {
            EnterPresetCode.SendKeys(code);
            EnterPresetMessage.SendKeys(name);
            
        }
        public void EnterNutritionalCodeandName(string code, string name)
        {
            EnterNutritionalCode.SendKeys(code);
            EnterNutritionalPrintFormat.SendKeys(name);
        }

        public void EnterSearchBox(string code, string name)
        {
            EnterCode.SendKeys(code);
            EnterPrintFormat.SendKeys(name);
            Save.Click();
        }
        public void ClickonSave()
        {
            Save.Click();
        }

        public void ClickonSaveclass()
        {
            Savenew.Click();
        }

        public void EditCode()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEdit).Perform();
        }
        public void EditCode3()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromTable).Perform();
        }

        public void Checkboxes()
        {
            CheckProductlife.Click();
            System.Threading.Thread.Sleep(2000);
            CheckTare.Click();
            CheckPresetmessages.Click();
            CheckPrintdateformat.Click();
            CheckContent.Click();
            Thread.Sleep(5000);

        }

        public void VerifyContentSymbol() => Assert.IsTrue(CheckHasContentSymbol.Enabled);

        public void ClickonAddSection()
        {
            AddSection.Click();
            Thread.Sleep(3000);
        }

        public void ClickonFontDropdown(string fontdropdown)
        {
            EnterFontValue.SelectByText(fontdropdown);
            Thread.Sleep(5000);
        }
        
        public void ClickonNutritionalElementtDropdown(string fontdropdown)
        {
            NutritionalEmenetDropDownValue.SelectByText(fontdropdown);
            Thread.Sleep(5000);
        }

        public void SelectMeasurementDropdown(string fontdropdown)
        {
            MeasurmentDropDown.SelectByText(fontdropdown);
            Thread.Sleep(5000);
        }

        public void AddDiscription(string desc) => AddDesc.SendKeys(desc);

        public void SavetheFontwithData() => Save.Click();

        public void ClosePF() => Close.Click();


        public void PublishPrint()
        {
            Actions action = new Actions(Driver);
            action.Click(PublishPF).Perform();
            Thread.Sleep(5000);
        }

        public void SelectStoreLatest()
        {
            ClickStore.Click();
            SelectStore.Click();
            Thread.Sleep(3000);
            ClickStore.Click();
            Clickok.Click();
            Thread.Sleep(5000);
        }

        public void DeletePrint()
        {
            Actions action = new Actions(Driver);
            action.Click(DeletePF);
            action.Perform();
            Thread.Sleep(3000);
            Deletebutton.Click();
        }

        public void SeachPFname(string code) => Searchbox.SendKeys(code);

        public void EditRow()
        {

            Actions actions = new Actions(Driver);

            actions.DoubleClick(ClickEditNice).Perform();
        }


        public void EditCode2()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditNEWPF).Perform();
        }

        public void ManadatoryFixedWidthCheckBoxCheckboxes()
        {
            Manadatory.Click();
            FixedWidth.Click();
        }

        public void ConfigureTheRowCharactersValues()
        {
            Row.SendKeys("2");
            Characters.Clear();
            Characters.SendKeys("2");
        }

        public void ManadatoryFixedWidthCheckBoxCheckboxes2()
        {
            Manadatory2.Click();
            FixedWidth2.Click();
        }

        public void AddDiscription2(string desc) => AddDesc2.SendKeys(desc);

        public void ConfigureTheRowCharactersValuesFont()
        {
            Row_Font.SendKeys("2");
            Characters_Font.Clear();
            Characters_Font.SendKeys("2");
        }

        public void ClickonFontDropdown2(string fontdropdown)
        {
            EnterNutritionalFontValue.SelectByText(fontdropdown);
            Thread.Sleep(5000);
        }

        public void FetchValueForNutritionalSection() => NutrionalTemplateDropdown.SelectByText("NP1");

        public void ClickSupportBasicMode()
        {
            Support_Basic_Mode.Click();
            HeaderRows.Clear();
            HeaderRows.SendKeys("4");
            TableRows.Clear();
            TableRows.SendKeys("6");
        }
        public void SearchPF(string text) => SearchCode.SendKeys(text);
        public void ChangePFCode(string code)
        {
            ChangeCode.Clear();
            ChangeCode.SendKeys(code);
        }
        public void UpdatePF()
        {
            CheckTare.Click();
            CheckPresetmessages.Click();
            CheckPrintdateformat.Click();
            CheckContent.Click();
            Thread.Sleep(5000);
        }

        public void PFClear()
        {
            PrintFormatName.Clear();
        }
        public void EditPrintFormatName(string printFormat)
        {

            PrintFormatName.SendKeys(printFormat);
            SavetheFontwithData();

            // Add New
            ClickonAddSection();
            // ClickonFontDropdown(Font2);



        }

        public void EnterValueinMaskfield(string maskvalue)
        {
            Thread.Sleep(5000);
            EnterValueinMask.SendKeys(maskvalue);
        }









    }
}
