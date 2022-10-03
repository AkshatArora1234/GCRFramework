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

        public Store_LocationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            store_Location = new Store_Location(_driverHelper.driver);
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
        
       
    }
}
