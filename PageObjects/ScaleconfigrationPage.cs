using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class Scaleconfig
    {

        private IWebDriver Driver;
        string PFName;
        string Store;
        public Scaleconfig(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@id='search-text']"));
        IWebElement NewItembutton => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.addPrintFormat()']"));
        IWebElement NewItem => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.addNutritionalElement()']"));
        IWebElement FontNewButton => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createScaleFont()']"));
        IWebElement TareNewButton => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createTare()']"));
        IWebElement PresetNewButton => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createPresetMessage()']"));
        IWebElement ContentNewButton => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createContentSymbol()']"));
        IWebElement NutritionalPanel => Driver.FindElement(By.XPath("//a[@ng-click='ctrl.createNutritionalPanel()']"));
        IWebElement LeftMenu => Driver.FindElement(By.XPath("//*[@class='SideMenuWrapper SideMenuWrapperSmall']//*[@class='fa fa-bars N_P_A']"));
        IWebElement ScaleConfigurationMenu => Driver.FindElement(By.XPath("//span/strong[text()='Scale Configuration']"));
        IWebElement StoreMaintenanceMenu => Driver.FindElement(By.XPath("//span/strong[text()='Store Maintenanc']"));
        IWebElement ElementSelectFromTable => Driver.FindElement(By.XPath("//*[@id='gridSCALEPF']/div/div[6]/div/div/div[1]/div/table/tbody/tr[last()-1]/td[1]"));
        IWebElement EnterCode => Driver.FindElement(By.XPath("(//*[@name='pFCode'])"));
        IWebElement EnterFontCode => Driver.FindElement(By.XPath("//*[@name='scaleFontCode']"));
        IWebElement EnterTareCode => Driver.FindElement(By.XPath("//*[@name='tareCode']"));
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
        IWebElement SaveNClose => Driver.FindElement(By.XPath("//span[text()='Save & Close']"));
        IWebElement ClickEdit => Driver.FindElement(By.XPath("(//*[contains(text(),'OpenSansBiscuits')])[1]"));
        IWebElement ClickEditPF => Driver.FindElement(By.XPath($"//td[text()='{PFName}']"));
        IWebElement CheckProductlife => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasProductLife']"));
        IWebElement CheckTare => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasTare']"));
        IWebElement CheckContent => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasContent']"));
        IWebElement ContentSymbol => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasContentSymbol']"));
        IWebElement CookingTime => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasCookingTime']"));
        IWebElement SellBy => Driver.FindElement(By.XPath("//input[@ng-model='ctrl.formData.hasSellBuy']"));
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
        private CustomControls NutrionalTemplateDropdown => new CustomControls(Driver, By.XPath("(//select[@ng-model='section.scaleNPanelId'])[2]"));
        private CustomControls NutrionalTemplateDropdown1 => new CustomControls(Driver, By.XPath("//select[@ng-model='section.scaleNPanelId']"));
        IWebElement SelectStore => Driver.FindElement(By.XPath("//*[@class='checkboxInput']"));
        IWebElement Deletebutton => Driver.FindElement(By.Id("submitButton"));
        IWebElement Clickok => Driver.FindElement(By.XPath("//*[text()='OK']"));
        IWebElement Searchbox => Driver.FindElement(By.XPath("(//*[@class='dx-texteditor-input'])[19]"));
        IWebElement PFNameSearchbox => Driver.FindElement(By.XPath("(//*[@class='dx-texteditor-input'])[16]"));
        IWebElement PFCodeSearchbox => Driver.FindElement(By.XPath("(//*[@class='dx-texteditor-input'])[17]"));
        IWebElement TabPrintFormat => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[2]"));
        IWebElement TabConfigration => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[1]"));
        IWebElement SRPrintFormat => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[7]"));
        IWebElement SRTare => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[9]"));
        IWebElement SRContentSymbol => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[3]"));
        IWebElement SRPresetMsg => Driver.FindElement(By.XPath("(//a[@class='nav-link ng-binding'])[5]"));
        IWebElement ClickEditNEWPF => Driver.FindElement(By.XPath("(//*[contains(text(),'OpenSansBiscuits1')])"));
        IWebElement ClickEditNutritionalPanel => Driver.FindElement(By.XPath("(//*[contains(text(),'ChocoCream')])"));
        IWebElement ClickEditNutritionalPanelTwoZeroOne => Driver.FindElement(By.XPath("//*[@id='gridSCALENP']/div/div[6]/div/div/div[1]/div/table/tbody/tr[last()-1]/td[2]"));
        IWebElement Manadatory => Driver.FindElement(By.XPath("(//input[@ng-model='section.isMandatory'])[1]"));
        IWebElement FixedWidth => Driver.FindElement(By.XPath("(//input[@ng-model='section.isFixedWidth'])[1]"));
        IWebElement Manadatory2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.isMandatory'])[2]"));
        IWebElement FixedWidth2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.isFixedWidth'])[2]"));
        IWebElement Row => Driver.FindElement(By.XPath("//input[@name='rows--14']"));
        IWebElement Characters => Driver.FindElement(By.XPath("//input[@name='characters--14']"));
        IWebElement Row_Font => Driver.FindElement(By.XPath("//input[@name='rows--3']"));
        IWebElement Characters_Font => Driver.FindElement(By.XPath("//input[@name='characters--3']"));
        IWebElement AddDesc2 => Driver.FindElement(By.XPath("(//input[@ng-model='section.sectionDescription'])[2]"));
        private CustomControls EnterNutritionalFontValue => new CustomControls(Driver, By.XPath("(//select[@ng-model='section.scaleFontId'])[2]"));
        IWebElement Support_Basic_Mode => Driver.FindElement(By.XPath("//input[@ng-model='section.hasBasicMode']"));
        IWebElement HeaderRows => Driver.FindElement(By.XPath("(//input[@ng-model='ctrl.ngModel'])[3]"));
        IWebElement TableRows => Driver.FindElement(By.XPath("(//input[@ng-model='ctrl.ngModel'])[4]"));
        IWebElement SearchCode => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[17]"));
        IWebElement ChangeCode => Driver.FindElement(By.Id("printFormatCode"));
        IWebElement ClickEditNice => Driver.FindElement(By.XPath("(//*[contains(text(),'Popcorn')])[2]"));
        IWebElement PrintFormatName => Driver.FindElement(By.XPath("//*[@name='printFormatName']"));
        IWebElement NutritionalPanelName => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[17]"));
        IWebElement EnterValueinMask => Driver.FindElement(By.XPath("//*[@name='nutritional-ele-mask']"));
        IWebElement ClickEditPopCorn1 => Driver.FindElement(By.XPath("//td[contains(text(),'Popcorn1')]"));
        IWebElement ButtonSave => Driver.FindElement(By.XPath("//*[@class='button-save ng-scope']"));
        IWebElement TabScaleConfiguration => Driver.FindElement(By.XPath("(//*[@class='ng-binding' and contains(text(),'Scale Configuration')])[2]"));
        IWebElement ClickList => Driver.FindElement(By.XPath("//*[@ng-click='toggleDropdown()']"));
        IWebElement PresetOption4 => Driver.FindElement(By.XPath("(//*[@ng-keydown='option.disabled || keyDownLink($event)'])[4]"));
        IWebElement PresetOption5 => Driver.FindElement(By.XPath("(//*[@ng-keydown='option.disabled || keyDownLink($event)'])[5]"));
        IWebElement SaveAndCloseNutriPanel => Driver.FindElement(By.XPath("//button[@class='button-saveandclose']"));
        IWebElement Fontname => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[2]"));
        IWebElement VerifyFontmessage => Driver.FindElement(By.XPath("//p[@class='ng-binding']"));
        IWebElement Okbutton => Driver.FindElement(By.XPath("(//*[text()='OK'])[1]"));
        IWebElement DeleteFont1 => Driver.FindElement(By.XPath("//i[@ng-click='ctrl.actions.deleteFont(row.data)']"));
        IWebElement CloseSR => Driver.FindElement(By.XPath("//button[@ng-click='ctrl.cancelClicked()']"));
        IWebElement EnterLocationCode => Driver.FindElement(By.XPath("(//input[@role='spinbutton'])[4]"));
        IWebElement StoreEdit => Driver.FindElement(By.XPath("(//i[@class='fa fa-pencil-square-o'])[5]"));
        IWebElement ClickDropdown => Driver.FindElement(By.XPath("(//div[@class='dx-dropdowneditor-icon'])[6]"));
        IWebElement PFTextBox => Driver.FindElement(By.XPath("//td[@aria-colindex='4'and @class='inline_edit_enabled_cell']"));
        IWebElement SelectPF => Driver.FindElement(By.XPath($"//div[text()='{PFName}]"));
        IWebElement SelectPrintF => Driver.FindElement(By.XPath($"//div[text()='{PFName}']"));
        IWebElement SavePF => Driver.FindElement(By.XPath("//span[text()='Save']"));
        IWebElement SaveChanges => Driver.FindElement(By.XPath("//button[@id='submitButton']"));
        IWebElement StoreLocation => Driver.FindElement(By.XPath("//uib-tab-heading[text()='Stores / Locations']"));
        IWebElement LocationName => Driver.FindElement(By.XPath("//div[text()='Location Name']"));
        IWebElement StoreNameSearch => Driver.FindElement(By.XPath("(//input[@role='textbox'])[13]"));
        IWebElement StoreNameSearchMaintenance => Driver.FindElement(By.XPath("(//input[@class='dx-texteditor-input'])[24]"));
        IWebElement ClickStoreName => Driver.FindElement(By.XPath($"(//td[text()='{Store}'])[2]"));
        IWebElement ClickStoreEdit => Driver.FindElement(By.XPath("(//i[@uib-tooltip='Edit'])[3]"));
        IWebElement StoreActive => Driver.FindElement(By.XPath("(//input[@ng-model='ctrl.currentStore.isActive'])[1]"));
        IWebElement SavenClose => Driver.FindElement(By.XPath("(//span[text()='Save & Close'])[1]"));


        public void ButtonSaveClick() => ButtonSave.Click();
        public void CheckProductLife() => CheckProductlife.Click();
        public void ScalConfigurationClick() => TabScaleConfiguration.Click();
        public void ClickLeftMenu()
        {
            Thread.Sleep(4000);
            LeftMenu.Click();
        }

        public void ScaleConfiguration()
        {
            Searchbar.Clear();
            Thread.Sleep(1000);
            Searchbar.SendKeys("Scale Configuration");
        }
        public void StoreMaintenance()
        {
            Searchbar.Clear();
            Thread.Sleep(1000);
            Searchbar.SendKeys("Store Maintenance");
            Thread.Sleep(500);
        }

        public void MenuScaleConfigurationClick() => ScaleConfigurationMenu.Click();
        public void MenuStoreMaintenanceClick() => Searchbar.SendKeys(Keys.Enter);
        public void TabPrintFormatClick() => TabPrintFormat.Click();
        public void TabConfiGrationClick() => TabConfigration.Click();
        public void srPrintFormat() => SRPrintFormat.Click();
        public void srTare() => SRTare.Click();
        public void srContentSymbol() => SRContentSymbol.Click();
        public void srPresetMessage() => SRPresetMsg.Click();

        public void ClickFontNewButton() => FontNewButton.Click();
        public void ClickTareNewButton() => TareNewButton.Click();
        public void ClickPresetNewButton() => PresetNewButton.Click();
        public void ClickContentSymbolNewButton() => ContentNewButton.Click();
        public void FetchValueForNutritionalSection(string text) => NutrionalTemplateDropdown.SelectByText(text);
        public void FetchValueForNutritionalSection1(string text) => NutrionalTemplateDropdown1.SelectByText(text);
        public void ClickNutritionalNewButton()
        {
            Actions actions = new Actions(Driver);
            TabPrintFormatClick();
            TabConfiGrationClick();
            Thread.Sleep(8000);
            actions.MoveToElement((IWebElement)NutritionalPanel);
            actions.Perform();
            NutritionalPanel.Click();
        }

        public void NutrionalPanelNam2(string nutritional)
        {
            Thread.Sleep(5000);
            Actions actions = new Actions(Driver);
            actions.MoveToElement((IWebElement)NutritionalPanelName);
            actions.Perform();
            NutritionalPanelName.Clear();
            NutritionalPanelName.SendKeys(nutritional);
        }
        public void EditNutritionalPanel()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditNutritionalPanel).Perform();
        }

         public void EditNutritionalPanelTwoZeroOne()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditNutritionalPanelTwoZeroOne).Perform();
        }

        public void ClickNewButton() => NewItembutton.Click();
        public void ClickNew() => NewItem.Click();

        public void EnterCodeandName(string code, string name)
        {
            EnterCode.SendKeys(code);
            EnterPrintFormat.SendKeys(name);
            Save.Click();
        }

        public void AddPFToLocation(string LocCode,string PFname)
        {
            PFName = PFname;
            Thread.Sleep(1000);
            StoreLocation.Click();
            Thread.Sleep(3000);
            LocationName.Click();
            StoreEdit.Click();
            Thread.Sleep(2000);
            EnterLocationCode.SendKeys(LocCode);
            Thread.Sleep(2000);
            PFTextBox.Click();
            Thread.Sleep(2000);
            ClickDropdown.Click();
            Thread.Sleep(7000);
            SelectPF.Click();
            LocationName.Click();
            Thread.Sleep(2000);
            SavePF.Click();
            Thread.Sleep(1000);
            SaveChanges.Click();
            Thread.Sleep(1000);
        }
        public void AddPFMultipleLocation(string store1, string store2, string Loc1, string Loc2, string PFname, string code)
        {
            Actions act = new Actions(Driver);
            PFName = PFname;
            string Store;
            Thread.Sleep(1000);
            StoreLocation.Click();
            Thread.Sleep(1000);
            for (int i = 0; i < 2; i++)
            {   if(i==0){ Store = store1; }
                else { Store = store2; }
                Thread.Sleep(2000);
                LocationName.Click();
                StoreEdit.Click();
                Thread.Sleep(2000);
                if(Store== "Crace (1501)")
                {
                    StoreNameSearch.SendKeys("crace");
                    act.SendKeys(Keys.Tab).SendKeys(Loc1).Build().Perform();
                }
                else
                {
                    StoreNameSearch.SendKeys("kingston");
                    act.SendKeys(Keys.Tab).SendKeys(Loc2).Build().Perform();
                }
                
                Thread.Sleep(2000);
                act.DoubleClick(PFTextBox).Build().Perform();
                Thread.Sleep(6000);
                SelectPrintF.Click();
                LocationName.Click();
                Thread.Sleep(2000);
                SavePF.Click();
                Thread.Sleep(1000);
                SaveChanges.Click();
                Thread.Sleep(1000);
            }
        }
        public void EnterFontCodeandName(string code, string name)
        {
            EnterFontCode.SendKeys(code);
            EnterFontPrintFormat.SendKeys(name);
        }
        public void DeactivateStore(string store)
        {
            if(StoreActive.Enabled)
            {
                StoreActive.Click();
            }
            Thread.Sleep(1000);
            SavenClose.Click();
        }
        public void ClickOnStoreEdit(string store)
        {
            if(store.Equals("Kingston(1500)"))
            { 
                Store = "Kingston";
            }
            else if(store.Equals("Crace (1501)"))
            {
                Store = "Crace";
            }
            Thread.Sleep(2000);
            StoreNameSearchMaintenance.Click();
            Thread.Sleep(1000);
            StoreNameSearchMaintenance.SendKeys(Store);
            Thread.Sleep(1000);
            try
            {
                CustomControls.MoveToAElement(ClickStoreName, Driver);
                Thread.Sleep(1000);
                ClickStoreEdit.Click();
            }
            catch(Exception e)
            {
                ClickStoreName.Click();
                Thread.Sleep(1000);
                ClickStoreEdit.Click();
            }
           
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
        public void EnterPresetListValue()
        {
            ClickList.Click();
            PresetOption4.Click();
            PresetOption5.Click();
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
        public void ClickonSave() =>  Save.Click();
        public void ClickonSaveclass() => Savenew.Click();
        public void SaveAndCloseNutriPanelElement() => SaveAndCloseNutriPanel.Click();
        public void EditCode()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEdit).Perform();
        }

        public void EditPF(string pfname)
        {
            PFName = pfname;
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditPF).Perform();
        }
        public void EditCode3()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ElementSelectFromTable).Perform();
        }

        public void ClickCheckboxes()
        {
            Thread.Sleep(2000);
            CheckProductlife.Click();
            CheckTare.Click();
            CheckContent.Click();
            SellBy.Click();
            CheckPresetmessages.Click();
            CookingTime.Click();
        }
        public void ClickCheckboxes_4_0_5_loc3()
        {
            Thread.Sleep(2000);
            CheckProductlife.Click();
            Thread.Sleep(2000);
            CheckTare.Click();
            CheckContent.Click();
            Thread.Sleep(2000);
            CheckPresetmessages.Click();
            CheckPrintdateformat.Click();
            CookingTime.Click();
            Thread.Sleep(2000);
        }
        public void ClickCheckboxes_4_0_5_loc4()
        {
            Thread.Sleep(2000);
            CheckProductlife.Click();
            Thread.Sleep(2000);
            CheckTare.Click();
            CheckContent.Click();
            Thread.Sleep(2000);
            SellBy.Click();
            CheckPresetmessages.Click();
            CheckPrintdateformat.Click();
            CookingTime.Click();
            Thread.Sleep(2000);
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
        public void SaveAndClosePF() => SaveNClose.Click();



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
        public void SearchPFName(string name, string code)
        {
            PFNameSearchbox.Clear();
            PFCodeSearchbox.Clear();
            PFNameSearchbox.SendKeys(name);
            PFCodeSearchbox.SendKeys(code);

        }

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
            Row.Clear();
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

        public void FetchValueForNutritionalSection() => NutrionalTemplateDropdown1.SelectByText("ChocoCream");

        public void ClickSupportBasicMode(string HRows, string TRows)
        {
            Support_Basic_Mode.Click();
            HeaderRows.Clear();

            HeaderRows.SendKeys(HRows);


            TableRows.Clear();
            TableRows.SendKeys(TRows);
        }
        public void SearchPF(string text)
        {
            Thread.Sleep(5000);
            SearchCode.SendKeys(text);
        }
        
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

        public void PFClear() => PrintFormatName.Clear();
        public void EditPrintFormatName(string printFormat)
        {
            PrintFormatName.SendKeys(printFormat);
            SavetheFontwithData();
        }

        public void EnterValueinMaskfield(string maskvalue)
        {
            Thread.Sleep(5000);
            EnterValueinMask.SendKeys(maskvalue);
        }

        public void EditPopCorn1()
        {
            Actions actions = new Actions(Driver);
            actions.DoubleClick(ClickEditPopCorn1).Perform();
        }

        public void ClearSearchBox()
        {
            Searchbox.Clear();
        }

        public void FontName(string nutritional)
        {
            Thread.Sleep(5000);
            Fontname.SendKeys(nutritional);
        }

        public void Verifymessage()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(VerifyFontmessage.Displayed);
            Okbutton.Click();

        }

        public void DeleteFont()
        {
            Actions action = new Actions(Driver);
            action.Click(DeleteFont1);
            action.Perform();
            Thread.Sleep(3000);

        }

        public void CloseSRpage() => CloseSR.Click();



    }
}
