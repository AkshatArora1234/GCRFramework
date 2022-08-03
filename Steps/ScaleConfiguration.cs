using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.Steps
{

    [Binding]
    public class ScaleConfiguration
    {
        private readonly DriverHelper _driverHelper;
        NewItemCreation newItemCreation;
        HQLoginPage hQLoginPage;
        Scaleconfig scaleConfigurationPage;
        HomePage homePage;
        ColumnChooser columnChooser;
        NewBatch newBatch;
        ConfigurationPage configurationPage;

        public ScaleConfiguration(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            newItemCreation = new NewItemCreation(_driverHelper.driver);
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            columnChooser = new ColumnChooser(_driverHelper.driver);
            newBatch = new NewBatch(_driverHelper.driver);
            configurationPage = new ConfigurationPage(_driverHelper.driver);
        }



        [When(@"User clicks on the Left Menu")]
        public void WhenUserClicksOnTheLeftMenu()
        {
            Thread.Sleep(4000);
            scaleConfigurationPage.ClickLeftMenu();
        }

        [Then(@"menu should be displayed")]
        public void ThenMenuShouldBeDisplayed()
        {

        }

        [When(@"User enters Scale Configuration in the Search Box")]
        public void WhenUserEntersScaleConfigurationInTheSearchBox()
        {
            scaleConfigurationPage.ScaleConfiguration();
        }

        [Then(@"Scale Configuration Item should be displayed on the Menu")]
        public void ThenScaleConfigurationItemShouldBeDisplayedOnTheMenu()
        {
            scaleConfigurationPage.MenuScaleConfigurationClick();
        }

        [When(@"User Selects the Scale Configuration")]
        public void WhenUserSelectsTheScaleConfiguration()
        {

        }

        [Then(@"Scale Configuration Page should be displayed")]
        public void ThenScaleConfigurationPageShouldBeDisplayed()
        {

        }

        [When(@"User click s on the Add New from Font Section")]
        public void WhenUserClickSOnTheAddNewFromFontSection()
        {

        }

        [Then(@"Create New Font Pop up should appear")]
        public void ThenCreateNewFontPopUpShouldAppear()
        {

        }

        [When(@"User enters the '(.*)', '(.*)'")]
        public void WhenUserEntersThe(string p0, string p1)
        {

        }

        [Then(@"the save button should be enabled")]
        public void ThenTheSaveButtonShouldBeEnabled()
        {

        }

        [When(@"User clicks on button Save")]
        public void WhenUserClicksOnButtonSave()
        {

        }

        [Then(@"Font should get saved and a '(.*)' should be displayed for the same")]
        public void ThenFontShouldGetSavedAndAShouldBeDisplayedForTheSame(string p0)
        {

        }

        [When(@"user Looks Font table")]
        public void WhenUserLooksFontTable()
        {

        }

        [Then(@"the recently created Font should be displayed")]
        public void ThenTheRecentlyCreatedFontShouldBeDisplayed()
        {

        }


        // Step Definitions for Edit Print Format
        [When(@"User clicks on Tab Print Format")]
        public void WhenUserClicksOnTabPrintFormat()
        {
            scaleConfigurationPage.TabPrintFormatClick();
        }

        [Then(@"Print Format Page should be displayed")]
        public void ThenPrintFormatPageShouldBeDisplayed()
        {

        }

        [When(@"user clicks on the Print Format Code")]
        public void WhenUserClicksOnThePrintFormatCode()
        {

        }

        [Then(@"the Selected Print Format Code should be displayed in tab")]
        public void ThenTheSelectedPrintFormatCodeShouldBeDisplayedInTab()
        {

        }

        [Then(@"Click on the New Button")]
        public void ClickonNewButton()
        {
            scaleConfigurationPage.ClickNewButton();
        }

        [When(@"Enter the CodeName and PrintFormat")]
        public void EnterCodeNameandPrintFormat()
        {
            string printCode = homePage.getConfiguration("TestData.json", "PrintCode2.0");
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.0");
            scaleConfigurationPage.EnterCodeandName(printCode, printFormat);
            Thread.Sleep(5000);
        }

        [When(@"Enter the Value of Print Name")]
        public void EnterValueofsearchcode()
        {
            
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.0");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        [When(@"Searches for PrintFormat")]
        public void WhenSearchesForPrintFormat()
        {
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.3");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        [Then(@"Click on Edit Button")]
        public void ClickonEditButton()
        {

            scaleConfigurationPage.EditCode();
            Thread.Sleep(5000);
        }

        [When(@"Check the required text boxes")]
        public void CheckRequiredTextBoxes()
        {
            scaleConfigurationPage.Checkboxes();
        }

        [Then(@"Check the Content Symbol")]
        public void CheckContentSymbol()
        {
            scaleConfigurationPage.VerifyContentSymbol();
        }

        [When(@"Click on Add Section")]
        public void ClickonAddSections()
        {
            scaleConfigurationPage.ClickonAddSection();
        }

        [Then(@"Click on Font Dropdown")]
        public void ClickOnFontDropDowns()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.ClickonFontDropdown(selectfont);
            Thread.Sleep(5000);
        }


        [Then(@"Add Desc to font")]
        public void AddDescription()
        {
            string Adddesc = homePage.getConfiguration("TestData.json", "NonNutritionalDesc");
            scaleConfigurationPage.AddDiscription(Adddesc);
            Thread.Sleep(5000);
        }

        [Then(@"Save the font with data")]
        public void SaveFont()
        {
            scaleConfigurationPage.SavetheFontwithData();
            Thread.Sleep(3000);
        }

        [Then(@"Close the font")]
        public void CloseFont()
        {
            scaleConfigurationPage.ClosePF();
            Thread.Sleep(4000);
        }

        [Then(@"Publish the PF")]
        public void PublishthePF()
        {
            scaleConfigurationPage.PublishPrint();
            Thread.Sleep(5000);
        }

        [Then(@"Select the Store")]
        public void SelectStore()
        {
            scaleConfigurationPage.SelectStoreLatest();
            Thread.Sleep(3000);
        }

        [Then(@"Delete the PF")]
        public void DeletePF()
        {
            //scaleConfigurationPage.DeletePrint();
            Thread.Sleep(5000);
        }


        [When(@"Enter the CodeName and PrintFormat new")]
        public void EnterCodeNameandPrintFormat1()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "PrintCode3.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "PrintFormat3.0");
            scaleConfigurationPage.EnterCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        [When(@"Enter the Value of Print Name OpenSanBiscuit1")]
        public void EnterValueoOfpenSanBiscuit1()
        {
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat3.0");
            scaleConfigurationPage.SeachPFname(printFormat);
            Thread.Sleep(5000);
        }

        [Then(@"Click on Edit Button new PF")]
        public void ClickonEditButtonNEWPF()
        {

            scaleConfigurationPage.EditCode2();
            Thread.Sleep(5000);
        }

        [Then(@"check the Manadatory & Fixed Width check box")]
        public void ThenCheckTheManadatoryFixedWidthCheckBox()
        {
            scaleConfigurationPage.ManadatoryFixedWidthCheckBoxCheckboxes();
        }

        [Then(@"configure the row & Characters values")]
        public void ThenConfigureTheRowCharactersValues()
        {
            scaleConfigurationPage.ConfigureTheRowCharactersValues();
        }


        [Then(@"check the Manadatory & Fixed Width check box font2")]
        public void ThenCheckTheManadatoryFixedWidthCheckBoxFont2()
        {
            scaleConfigurationPage.ManadatoryFixedWidthCheckBoxCheckboxes2();
        }


        [Then(@"Add Desc to font2")]
        public void AddDescription2()
        {
            string Adddesc1 = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc1);
            Thread.Sleep(5000);
        }

        [Then(@"configure the row & Characters values Font2")]
        public void ThenConfigureTheRowCharactersValuesFont()
        {
            scaleConfigurationPage.ConfigureTheRowCharactersValuesFont();
        }

        [Then(@"check a new nutritional Panel can be added to another section")]
        public void ThenCheckANewNutritionalPanelCanBeAddedToAnotherSection()
        {
            scaleConfigurationPage.ClickonAddSection();
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.1");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            Thread.Sleep(5000);
            scaleConfigurationPage.FetchValueForNutritionalSection();
        }


        [Then(@"Click Support Basic Mode Header and Table")]
        public void ClickSupportBasicModeHeaderandTable()
        {
            scaleConfigurationPage.ClickSupportBasicMode();
            Thread.Sleep(3000);
        }


        //Step Definition for Publish a PF, Exist with same name as in store.

        [When(@"user enter new PF code and name and Publish PF")]
        public void WhenUserEnterNewPFCodeAndNameAndPublishPF()
        {
            string pfCode = homePage.getConfiguration("TestData.json", "PrintCode2.0.2");
            string pfName = homePage.getConfiguration("TestData.json", "ChangedPFName");
            scaleConfigurationPage.EnterCodeandName(pfCode, pfName);
            Thread.Sleep(8000);
            scaleConfigurationPage.SearchPF(pfCode);
            Thread.Sleep(3000);
            scaleConfigurationPage.EditCode3();
            Thread.Sleep(8000);
            scaleConfigurationPage.UpdatePF();
            scaleConfigurationPage.ClickonAddSection();
            ClickOnFontDropDowns();
            AddDescription();
            SaveFont();
            CloseFont();
            Thread.Sleep(5000);
            PublishthePF();
            Thread.Sleep(3000);
            SelectStore();
        }

        [When(@"user search and select the printformat code")]
        public void WhenUserSearchAndSelectThePrintformatCode()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.EditCode3();
            Thread.Sleep(3000);
        }

        [Then(@"user change the PF code and update the checkboxes")]
        public void ThenUserChangeThePFCodeAndUpdateTheCheckboxes()
        {
            string NewPFCode = homePage.getConfiguration("TestData.json", "ChangedPFCOde");
            scaleConfigurationPage.ChangePFCode(NewPFCode);
        }

        [Then(@"verify Content Symbol is automatically checked on checking Content")]
        public void ThenVerifyContentSymbolIsAutomaticallyCheckedOnCheckingContent()
        {
            scaleConfigurationPage.VerifyContentSymbol();
        }

        [Then(@"verify user can Change non nutritional section to the nutritional by adding a nutritional font and description")]
        public void ThenVerifyUserCanChangeNonNutritionalSectionToTheNutritionalByAddingANutritionalFontAndDescription()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription(Adddesc);
            Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "NutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection1(NutriTemplate);
        }

        [Then(@"Change Nutritional to Non Nutritional")]
        public void ChangeNutritionaltononnutritional()
        {

            string selectfont = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            Thread.Sleep(5000);

        }

        [When(@"Clear the PrintformatName")]
        public void ClearThePrintFormatName()
        {


            scaleConfigurationPage.ClearSearchBox();
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"Add another new nutritional Panel to another section")]
        public void ThenAddAnotherNewNutritionalPanelToAnotherSection()
        {
            ClickonAddSections();
            string selectfont = homePage.getConfiguration("TestData.json", "SecondFontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
          //  Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
           // Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection(NutriTemplate);
        }

        [Then(@"Add another new nutritional Panel to another section latest")]
        public void ThenAddAnotherNewNutritionalPanelToAnotherSectionLatest()
        {
            ClickonAddSections();
            string selectfont = homePage.getConfiguration("TestData.json", "SecondFontname2.0.2");
            scaleConfigurationPage.ClickonFontDropdown2(selectfont);
            //  Thread.Sleep(5000);
            string Adddesc = homePage.getConfiguration("TestData.json", "NutritionalDesc");
            scaleConfigurationPage.AddDiscription2(Adddesc);
            // Thread.Sleep(5000);
            string NutriTemplate = homePage.getConfiguration("TestData.json", "SecondNutritionalName2.0.2");
            scaleConfigurationPage.FetchValueForNutritionalSection1(NutriTemplate);
        }

        [Then(@"Save and close the PF")]
        public void ThenSaveAndCloseThePF()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.SavetheFontwithData();
            Thread.Sleep(5000);
            scaleConfigurationPage.ClosePF();
        }

        [Then(@"select a scale item")]
        public void ThenSelectAScaleItem()
        {
            newItemCreation.SearchForKeyword();
            Thread.Sleep(8000);
            columnChooser.ChooseAColumn();
            columnChooser.SelectScaleValue();
            Thread.Sleep(5000);
            columnChooser.SelectFirstScaleRecord();
            Thread.Sleep(10000);
            columnChooser.ClickScaleTabInItems();
        }

        [Then(@"add the PF and ContentSymbol")]
        public void ThenAddThePFAndContentSymbol()
        {
            columnChooser.SelectPFForItem();
            columnChooser.AddContentSymbol("KG");
            columnChooser.NutritionalData("10", "15");
        }

        [Then(@"Save item")]
        public void ThenSaveItem() => columnChooser.SaveItemPF();

        [Then(@"navigate to the configuration page to edit the content symbol assigned to item")]
        public void ThenNavigateToTheConfigurationPageToEditTheContentSymbolAssignedToItem()
        {
            Thread.Sleep(4000);
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            configurationPage.SearchContentSymbol("18");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "NewContentSymbol2.0.2");
            configurationPage.EditContent(ContentSymbol);
        }

        [Then(@"Verify that the change is reflected in Item's scale tab")]
        public void ThenVerifyThatTheChangeIsReflectedInItemSScaleTab()
        {
            columnChooser.NavigateToItemDetailPage();
            _driverHelper.driver.Navigate().Refresh();
            Thread.Sleep(8000);
            columnChooser.ClickScaleTabInItems();
            columnChooser.AssertContentsymbol();
        }

        [Then(@"Delete the second panel added from the configuration page")]
        public void ThenDeleteTheSecondPanelAddedFromTheConfigurationPage()
        {
            Thread.Sleep(5000);
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            Thread.Sleep(3000);
            configurationPage.NutriPanelSearch("Coco cola");
            configurationPage.PageNavigationToScaleConfigPage();
            configurationPage.PageNavigationToConfigPage();
            Thread.Sleep(3000);
            configurationPage.DeleteNutrionalPanel();
        }

       
        [Then(@"Publish the PF to a second store where PF exists with same name")]
        public void ThenPublishThePFToASecondStoreWherePFExistsWithSameName()
        {
            Thread.Sleep(3000);
            configurationPage.PageNavigationToScaleConfigPage();
            scaleConfigurationPage.TabPrintFormatClick();
            Thread.Sleep(5000);
            scaleConfigurationPage.SearchPF("21");
            Thread.Sleep(3000);
            PublishthePF();
            Thread.Sleep(3000);
            SelectStore();
        }

        [Then(@"navigate back to configuration page to change the contentSymbol back")]
        public void ThenNavigateBackToConfigurationPageToChangeTheContentSymbolBack()
        {
            Thread.Sleep(3000);
            configurationPage.PageNavigationToConfigPage();
            configurationPage.SearchContentSymbol("18");
            string ContentSymbol = homePage.getConfiguration("TestData.json", "ContentSymbol2.0.2");
            Thread.Sleep(5000);
            configurationPage.EditContent(ContentSymbol);
        }
        [Then(@"Navigate to PF tab")]
        public void ThenNavigateToPFTab()
        {
            Thread.Sleep(3000);
            scaleConfigurationPage.TabPrintFormatClick();
        }


        //Step Definitions TC2
        [When(@"User Enters the Code and PrintFormat")]
        public void WhenUserEntersTheCodeAndPrintFormat()
        {
            string printCode = homePage.getConfiguration("TestData.json", "PrintCode2.2");
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.2");
            scaleConfigurationPage.EnterCodeandName(printCode, printFormat);
            System.Threading.Thread.Sleep(5000);


        }

        [When(@"Enter the Value of Print Name Nicebiscits")]
        public void EnterValueofPrintNameNiceBiscuits()
        {

            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.2");
            scaleConfigurationPage.SeachPFname(printFormat);
            System.Threading.Thread.Sleep(5000);
        }

        [When(@"Click on Edit Button")]
        public void WhenClickOnEditButton()
        {
            scaleConfigurationPage.EditRow();
            System.Threading.Thread.Sleep(5000);

        }

        [When(@"Change the PF name to Popcorn, also uncheck '(.*)' only\.Take any nutritional font and uncheck '(.*)' and check '(.*)'\.")]
        public void WhenChangeThePFNameToPopcornAlsoUncheckOnly_TakeAnyNutritionalFontAndUncheckAndCheck_(string p0, string p1, string p2)
        {

            System.Threading.Thread.Sleep(15000);
            scaleConfigurationPage.PFClear();
            string printFormat = homePage.getConfiguration("TestData.json", "PrintFormat2.3");

            scaleConfigurationPage.EditPrintFormatName(printFormat);

            System.Threading.Thread.Sleep(2000);

            // Uncheck the Product Life
            scaleConfigurationPage.CheckProductLife();



           


        }

        [When(@"User Enters the Code and PrintFormat(.*)")]
        public void WhenUserEntersTheCodeAndPrintFormat(int p0)
        {
            
        }

        [When(@"User Deletes the font added to PF")]
        public void WhenUserDeletesTheFontAddedToPF()
        {
            scaleConfigurationPage.DeleteFont();
        }

        [Then(@"Verifies the Toast is displayed")]
        public void ThenVerifiesTheToastIsDisplayed()
        {
            
        }

        [Then(@"a message'(.*)' should be displayed")]
        public void ThenAMessageShouldBeDisplayed(string p0)
        {
            
        }

        [When(@"User Pubilsh the PF to a Second Store where PF exists with the same Code")]
        public void WhenUserPubilshThePFToASecondStoreWherePFExistsWithTheSameCode()
        {
            
        }

        [When(@"Verify that at store, all the Tares, Content Symbols and Preset messages of HQ are published and the PF at store with same code is updated with values from HQ in Configuration\.")]
        public void WhenVerifyThatAtStoreAllTheTaresContentSymbolsAndPresetMessagesOfHQArePublishedAndThePFAtStoreWithSameCodeIsUpdatedWithValuesFromHQInConfiguration_()
        {
            
        }

        [When(@"Click on Edit")]
        public void WhenClickOnEdit()
        {
            scaleConfigurationPage.EditPopCorn1();
        }

        [When(@"click on buttonSave")]
        public void WhenClickOnButtonSave()
        {
            scaleConfigurationPage.ButtonSaveClick();
        }

        [When(@"i search the Font by name")]
        public void WhenISearchFontByName()
        {
            string NutritionalPanelName = homePage.getConfiguration("TestData.json", "Fontname2.1");
            scaleConfigurationPage.FontName(NutritionalPanelName);
            Thread.Sleep(3000);
        }

        [When(@"User Verify the font message")]
        public void UserVerifythefontmessage()
        {
            scaleConfigurationPage.Verifymessage();
        }






    }
}
