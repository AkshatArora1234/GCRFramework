﻿using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_MSTestFrameWork.Features
{
    [Binding]
    public class Store_LocationSteps
    {

        private readonly DriverHelper _driverHelper;
        Store_Location store_Location;
        HomePage homePage;
        ColumnChooser columnChooser;

        public Store_LocationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            store_Location = new Store_Location(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            columnChooser = new ColumnChooser(_driverHelper.driver);
        }
        /// <summary>
        /// navigate to store location tab
        /// </summary>
        [When(@"user click the StoreLocation tab")]
        public void WhenUserClickTheStoreLocationTab()
        {
            store_Location.TabStore_LocationClick();
        }
        /// <summary>
        /// Add new location button click
        /// </summary>
        [When(@"Add new location")]
        public void WhenAddNewLocation()
        {
            store_Location.AddNewStoreLocation();
        }
        [When(@"Create New Scale Location '(.*)' and '(.*)'")]
        public void WhenCreateNewScaleLocationAnd(string locCode, string locName)
        {
            store_Location.CreateLocation(locCode, locName);
        }
        /// <summary>
        /// Add new location with test data 4.0.0
        /// </summary>
        [When(@"Add new location for FourZeroZero '(.*)','(.*)'")]
        public void WhenAddNewLocationForFourZeroZero(string locationcode, string locationname)
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.0");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.0");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 1
        /// </summary>
        [When(@"Add new location for FourZeroFiveA")]
        public void WhenAddNewLocationForFourZeroFiveA()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.1");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.1");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 2
        /// </summary>
        [When(@"Add new location for FourZeroFiveB")]
        public void WhenAddNewLocationForFourZeroFiveB()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.2");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.2");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 3
        /// </summary>
        [When(@"Add new location for FourZeroFiveC")]
        public void WhenAddNewLocationForFourZeroFiveC()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.3");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.3");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 4
        /// </summary>
        [When(@"Add new location for FourZeroFiveD")]
        public void WhenAddNewLocationForFourZeroFiveD()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.4");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.4");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);            
        }
        /// <summary>
        /// method to drag and drop column from column chooser
        /// </summary>
        [Then(@"select column chooser for column name '(.*)'")]
        public void ThenSelectColumChooserForColumName(string column)
        {
            store_Location.ChooseAColumn(column);
        }



    }
}
