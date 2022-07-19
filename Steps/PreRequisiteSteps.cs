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
    public class PreRequisite
    {
        private readonly DriverHelper _driverHelper;
        NewItemCreation newItemCreation;
        HQLoginPage hQLoginPage;
        Scaleconfig scaleConfigurationPage;
        HomePage homePage;
        ColumnChooser columnChooser;
        NewBatch newBatch;

        public PreRequisite(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            newItemCreation = new NewItemCreation(_driverHelper.driver);
            hQLoginPage = new HQLoginPage(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            columnChooser = new ColumnChooser(_driverHelper.driver);
            newBatch = new NewBatch(_driverHelper.driver);
        }

        [When(@"User clicks on Tab Config page")]
        public void WhenUserClicksOnTabConfigration()
        {
            scaleConfigurationPage.TabConfiGrationClick();
        }

        [When(@"User clicks on Font New Button")]
        public void UserClickonFontNewButton()
        {
            scaleConfigurationPage.ClickFontNewButton();
        }

        [When(@"User clicks on Tare New Button")]
        public void WhenUserClicksOnTareNewButton()
        {
            scaleConfigurationPage.ClickTareNewButton();
        }


        [When(@"User clicks on Nutritional Panel New Button")]
        public void UserClickonNutritionalPanelNewButton()
        {
            scaleConfigurationPage.ClickNutritionalNewButton();
        }

        [When(@"Enter CodeName and Nutritional Panel")]
        public void WhenEnterCodeNameAndNutritionalPanel()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "NutritionalCode2.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "NutritionalName2.0");
            scaleConfigurationPage.EnterNutritionalCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        [When(@"i search the Nutrional Panel by Name")]
        public void WhenISearchTheNutrionalPanelByName()
        {
            string NutritionalPanelName = homePage.getConfiguration("TestData.json", "NutritionalPanelName2.0");

            scaleConfigurationPage.NutrionalPanelNam2(NutritionalPanelName);
            Thread.Sleep(3000);
        }

        [Then(@"Click on Edit Button NutritionalPanel")]
        public void ThenClickOnEditButtonNutritionalPanel()
        {
                 scaleConfigurationPage.EditNutritionalPanel();
                Thread.Sleep(5000);
            
        }

        [Then(@"Click on Nutritional Element dropdown")]
        public void ThenClickOnNutritionalElementDropdown()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "NonNutritionalValueDropdwon2.0");
            scaleConfigurationPage.ClickonNutritionalElementtDropdown(selectfont);
            Thread.Sleep(5000);
        }

        [When(@"Enter the value in MeasurementsUnit")]
        public void SelectValueMeasurementsUnit()
        {
            string selectfont = homePage.getConfiguration("TestData.json", "Measureunit2.0");
            scaleConfigurationPage.SelectMeasurementDropdown(selectfont);
            Thread.Sleep(5000);
        }






        [When(@"Enter CodeName and Font Name")]
        public void WhenEnterCodeNameAndFontName()
        {
            string printCode1 = homePage.getConfiguration("TestData.json", "FontCode2.0");
            string printFormat1 = homePage.getConfiguration("TestData.json", "Fontname2.0");
            scaleConfigurationPage.EnterFontCodeandName(printCode1, printFormat1);
            Thread.Sleep(5000);
        }

        [When(@"Enter TareCode and Name")]
        public void WhenEnterTareCodeAndName()
        {
            string TareCode = homePage.getConfiguration("TestData.json", "TareCode2.0");
            string TareName = homePage.getConfiguration("TestData.json", "TareName2.0");
            string TareValue = homePage.getConfiguration("TestData.json", "TareValue2.0");

            scaleConfigurationPage.EnterTaretCodeNameValue(TareCode, TareName, TareValue);
            Thread.Sleep(5000);
        }


        [Then(@"click on save button")]
        public void ThenClickOnSaveButton()
        {
            scaleConfigurationPage.ClickonSave();
        }

        [Then(@"click on new save button")]
        public void ThenClickOnnewSaveButton()
        {
            scaleConfigurationPage.ClickonSaveclass();
        }

        [Then(@"Search Nutritional Panel by Name")]
        public void SearchNutritionalPanelbyName()
        {
            scaleConfigurationPage.ClickonSave();
        }

        [Then(@"Enter Value in Mask Field")]
        public void EnterValueinMaskField()
        {
            string valueinmask = homePage.getConfiguration("TestData.json", "MaskFieldValue2.0");
            scaleConfigurationPage.EnterValueinMaskfield(valueinmask);
            Thread.Sleep(5000);

        }


    }
}
