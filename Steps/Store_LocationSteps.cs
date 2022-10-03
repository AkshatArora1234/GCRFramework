using SpecFlow_MSTestFrameWork.PageObjects;
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

        public Store_LocationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            store_Location = new Store_Location(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
        }

    [When(@"user click the StoreLocation tab")]
        public void WhenUserClickTheStoreLocationTab()
        {
            store_Location.TabStore_LocationClick();
        }
        
        [When(@"Add new location")]
        public void WhenAddNewLocation()
        {
            store_Location.AddNewStoreLocation();
        }

        [When(@"Add new location for FourZeroZero '(.*)','(.*)'")]
        public void WhenAddNewLocationForFourZeroZero(string locationcode, string locationname)
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.0");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.0");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }

    }
}
