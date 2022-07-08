using Microsoft.Extensions.Configuration;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
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

        public ScaleConfiguration(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            newItemCreation = new NewItemCreation(_driverHelper.driver);
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
        }



        // ScaleConfigurationPage ScaleConfigurationPageMethods = new ScaleConfigurationPage();
        [When(@"User clicks on the Left Menu")]
        public void WhenUserClicksOnTheLeftMenu()
        {
            //Cilck on the Left Menu
            //
            scaleConfigurationPage.ClickLeftMenu();
        }

        [Then(@"menu should be displayed")]
        public void ThenMenuShouldBeDisplayed()
        {

        }

        [When(@"User enters Scale Configuration in the Search Box")]
        public void WhenUserEntersScaleConfigurationInTheSearchBox()
        {
            //Enter Text Scale Configuration
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
            System.Threading.Thread.Sleep(5000);
        }


        [Then(@"Click on Edit Button")]
        public void ClickonEditButton()
        {

            scaleConfigurationPage.EditCode();
            System.Threading.Thread.Sleep(5000);
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
            string selectfont = homePage.getConfiguration("TestData.json", "NonNutritionalValue");
            scaleConfigurationPage.ClickonFontDropdown(selectfont);
            System.Threading.Thread.Sleep(5000);
        }


        [Then(@"Add Desc to font")]
        public void AddDescription()
        {
            string Adddesc = homePage.getConfiguration("TestData.json", "NonNutritionalDesc");
            scaleConfigurationPage.AddDiscription(Adddesc);
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"Save the font with data")]
        public void SaveFont()
        {
            scaleConfigurationPage.SavetheFontwithData();

           
        }

        [Then(@"Close the font")]
        public void ClsoeFont()
        {
            scaleConfigurationPage.ClosePF();
            System.Threading.Thread.Sleep(4000);
           
        }

        [Then(@"Publish the PF")]
        public void PublishthePFM()
        {
            scaleConfigurationPage.PublishPrint();
            System.Threading.Thread.Sleep(5000);
        }

        [Then(@"Select the Store")]
        public void SelectStore()
        {
            scaleConfigurationPage.SelectStoreLatest();
            System.Threading.Thread.Sleep(3000);

        }








    }
}
