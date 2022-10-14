using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using SpecFlow_MSTestFrameWork.PageObjects;
using System;
using System.Linq;
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
        Store_Location_SR store_Location_SR;
        Scaleconfig scaleConfigurationPage;
        QueueManager queueManager;

        public Store_LocationSteps(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
            store_Location = new Store_Location(_driverHelper.driver);
            homePage = new HomePage(_driverHelper.driver);
            columnChooser = new ColumnChooser(_driverHelper.driver);
            store_Location_SR = new Store_Location_SR(_driverHelper.driver);
            scaleConfigurationPage = new Scaleconfig(_driverHelper.driver);
            queueManager = new QueueManager(_driverHelper.driver);
        }
        //Sheet 1 scenarios steps

        /// <summary>
        /// navigate to store location tab in SR
        /// </summary>

        [When(@"User navigate to Location tab")]
        public void WhenUserNavigateToLocationTab()
        {
            store_Location_SR.NavigateToLocationTab();
        }

        /// <summary>
        ///click on new location button in SR
        /// </summary>
        [When(@"Click new location button")]
        public void WhenClickNewLocationButton()
        {
            store_Location_SR.AddNewSRLocation();
        }
        /// <summary>
        /// Create New Scale Location using enter key in SR
        /// </summary>
        /// /// <param name="locCode"></param>
        /// <param name="locName"></param>

        [Then(@"Add new location in SR application '(.*)' and '(.*)'")]
        public void ThenAddNewLocationInSRApplicationAnd(string locCode, string locName)
        {
            store_Location_SR.SRLocationCreation(locCode, locName);
        }
        /// <summary>
        /// Go to PF tab in SR
        /// </summary>
        [Then(@"Click on PF tab in SR")]
        public void ThenClickOnPFTabInSR()
        {
            scaleConfigurationPage.srPrintFormat();
        }
        /// <summary>
        /// Click new PF button in SR
        /// </summary>
        [Then(@"Click on add new PF button in SR")]
        public void ThenClickOnAddNewPFButtonInSR()
        {
            store_Location_SR.NewSRPFbuttonClick();
        }
        /// <summary>
        /// Create new PF using enter key in SR
        /// </summary>
        /// <param name="SRcode"></param>
        /// <param name="SRPFname"></param>
        [Then(@"Enter the new PF in SR '(.*)' and '(.*)'")]
        public void ThenEnterTheNewPFInSRAnd(string SRcode, string SRPFname)
        {
            store_Location_SR.SRPFCreation(SRcode, SRPFname);
        }
        /// <summary>
        /// Create new PF using enter key in SR
        /// </summary>
        /// <param name="SRcode"></param>
        [When(@"user search for the PF in SR'(.*)'")]
        public void WhenUserSearchForThePFInSR(string SRcode)
        {
            store_Location_SR.SearchPFInSR(SRcode);
        }
        /// <summary>
        /// Open the PF edit page
        /// </summary>
        [When(@"Open PF in edit page as per TD FourZeroZero")]
        public void WhenOpenPFInEditPageAsPerTDFourZeroZero()
        {
            store_Location_SR.EditPFinSR();
            store_Location.CheckProductlifeSR();
            store_Location.CheckTareSR();
            store_Location.CheckPresetmessagesSR();
            store_Location.CheckCookingTimeSR();
            store_Location.CheckContentSR();
        }
        /// <summary>
        /// Open the PF edit page for FourZeroFiveC
        /// </summary>
        [When(@"Open PF in edit page as per TD FourZeroFiveC")]
        public void WhenOpenPFInEditPageAsPerTDFourZeroFiveC()
        {
            store_Location_SR.EditPFinSR();
            store_Location.CheckProductlifeSR();
            store_Location.CheckSellBySR();
            store_Location.CheckPrintdateformatSR();
            store_Location.CheckTareSR();
            store_Location.CheckPresetmessagesSR();
            store_Location.CheckCookingTimeSR();
            store_Location.CheckContentSR();
        }
        /// <summary>
        /// Open the PF edit page for FourZeroFiveD
        /// </summary>
        [When(@"Open PF in edit page as per TD FourZeroFiveD")]
        public void WhenOpenPFInEditPageAsPerTDFourZeroFiveD()
        {
            store_Location_SR.EditPFinSR();
            store_Location.CheckProductlifeSR();
            store_Location.CheckTareSR();
            store_Location.CheckPresetmessagesSR();
            store_Location.CheckCookingTimeSR();
            store_Location.CheckContentSR();
        }
        /// <summary>
        /// Verify that the deleted location in HQ is not found in SR
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        [Then(@"User navigates to Location")]
        public void ThenUserNavigatesToLocation()
        {
            store_Location_SR.NavigateToLocationTab();
        }

        [Then(@"Verify that deleted location in HQ is not published and other item locations are published '(.*)' and '(.*)'")]
        public void ThenVerifyThatDeletedLocationInHQIsNotPublishedAndOtherItemLocationsArePublishedAnd(string LocName, string LocCode)
        {
            store_Location_SR.SearchDeletedLocationInSR(LocCode);
        }

        
        /// <summary>
        /// Save the PF in SR and close
        /// </summary>
        [When(@"Save and close PF in SR")]
        public void WhenSaveAndClosePFInSR()
        {
            store_Location_SR.SaveandClosePFinSR();
        }
        /// <summary>
        /// search for the location
        /// </summary>
        /// <param name="locCode"></param>
        [Then(@"search for a location '(.*)'")]
        public void ThenSearchForALocation(string locCode)
        {
            store_Location_SR.SearchLocationInSR(locCode);
        }
        /// <summary>
        /// Open the location to edit and update
        /// </summary>
        [Then(@"Open location in edit page")]
        public void ThenOpenLocationInEditPage()
        {
            store_Location_SR.EditLocationinSR();
        }
        /// <summary>
        /// Adding vendor to location
        /// </summary>
        [Then(@"add Vendor to location")]
        public void ThenAddVendorToLocation()
        {
            store_Location_SR.AddVendorinLoc();
        }

        /// <summary>
        /// Updating Pf to location
        /// </summary>
        /// <param name="SRPFname"></param>
        [Then(@"Link PF to Lcation (.*)'")]
        public void ThenLinkPFToLcation(string SRPFname)
        {
            store_Location_SR.LinkPFinLoc(SRPFname);
        }

        /// <summary>
        /// Save the changes and close location
        /// </summary>
        [Then(@"Save and close location in SR")]
        public void ThenSaveAndCloseLocationInSR()
        {
            store_Location_SR.SaveandCloseLocinSR();
        }


        /// <summary>
        /// Opens next chrome tab
        /// </summary>
        [Then(@"user navigates to next tab")]
        public void ThenUserNavigatesToNextTab()
        {
            ((IJavaScriptExecutor)_driverHelper.driver).ExecuteScript("window.open();");
            _driverHelper.driver.SwitchTo().Window(_driverHelper.driver.WindowHandles.Last());
        }

        [When(@"user navigates to HQ application")]
        public void WhenUserNavigatesToHQApplication()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsetting.json").Build();
            var initialurl = config["hqappUrl"];
            _driverHelper.driver.Navigate().GoToUrl(initialurl);
        }

        /// <summary>
        /// search the new PF created
        /// </summary>
        /// <param name="code"></param>
        [Then(@"User search for the PF '(.*)'")]
        public void ThenUserSearchForThePF(string code)
        {
            scaleConfigurationPage.SearchPF(code);
        }

        /// <summary>
        /// Update the PF
        /// </summary>
        [When(@"Open PF and update as per TD FourZeroZero")]
        public void WhenOpenPFAndUpdateAsPerTDFourZeroZero()
        {
            store_Location.CheckProductlife();
            store_Location.CheckTare();
            store_Location.CheckContent();
            store_Location.CheckSellBy();
            store_Location.CheckPresetmessages();
            store_Location.CheckPrintdateformat();
            store_Location.CheckCookingTime();

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

        /// <summary>
        /// Create multiple locations
        /// </summary>
        /// <param name="p0"></param>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <param name="p3"></param>
        /// <param name="p4"></param>
        /// <param name="p5"></param>
        [Then(@"Create multiple locations '(.*)','(.*)','(.*)','(.*)','(.*)','(.*)'")]
        public void ThenCreateMultipleLocations(string Store1, string Store2, string LocCode1, string LocCode2, string LocName1, string LocName2)
        {
            store_Location.CreateMultipleLocation(Store1,Store2, LocCode1, LocName1);
        }

        [Then(@"Publish the locations")]
        public void ThenPublishTheLocations()
        {
            store_Location.PublishLocationToSelectedStores();
        }

        /// <summary>
        /// Create New Scale Location using enter key
        /// </summary>
        /// <param name="locCode"></param>
        /// <param name="locName"></param>
        [When(@"Create New Scale Location '(.*)' and '(.*)'")]
        public void WhenCreateNewScaleLocationAnd(string locCode, string locName)
        {
            store_Location.CreateLocation(locCode, locName);
        }

        
        /// <summary>
        /// search for a location code in store/location tab
        /// </summary>
        /// <param name="locCode"></param>
        [Then(@"search for location code '(.*)'")]
        public void ThenSearchForLocationCode(string locCode)
        {
            store_Location.searchLocation(locCode);
        }

        /// <summary>
        /// Edit Scale Location 
        /// </summary>
        [Then(@"click to edit location")]
        public void ThenClickToEditLocation()
        {
            store_Location.EditStoreLocationClick();
        }

        /// <summary>
        /// Publishing the location
        /// </summary>
        [Then(@"publish the location to store '(.*)'")]
        public void ThenPublishTheLocationToStore(string locCode)
        {
            store_Location.PublishLocation(locCode);
        }


        /// <summary>
        /// Edit PF as per TD FourZeroOne
        /// </summary>
        [When(@"Open PF in edit page as per TD FourZeroOne")]
        public void WhenOpenPFInEditPageAsPerTDFourZeroOne()
        {
            store_Location_SR.EditPFinSR();
            store_Location.CheckProductlifeSR();
            store_Location.CheckTareSR();
            store_Location.CheckPresetmessagesSR();
            store_Location.CheckPrintdateformatSR();
            store_Location.CheckCookingTimeSR();
            store_Location.CheckContentSR();
        }


        /// <summary>
        /// Add new location with test data 4.0.0
        /// </summary>
        /// <param name="locationcode"></param>
        /// <param name="locationname"></param>
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
        [Then(@"Add new location for FourZeroFiveA")]
        public void ThenAddNewLocationForFourZeroFiveA()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.1");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.1");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 2
        /// </summary>
        [Then(@"Add new location for FourZeroFiveB")]
        public void ThenAddNewLocationForFourZeroFiveB()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.2");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.2");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 3
        /// </summary>
        [Then(@"Add new location for FourZeroFiveC")]
        public void ThenAddNewLocationForFourZeroFiveC()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.3");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.3");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);
        }
        /// <summary>
        /// Add new location with test data 4.0.5 location 4
        /// </summary>
        [Then(@"Add new location for FourZeroFiveD")]
        public void ThenAddNewLocationForFourZeroFiveD()
        {
            string locationCode = homePage.getConfiguration("TestData.json", "LocationCode.4.0.5.4");
            string locationName = homePage.getConfiguration("TestData.json", "LocationName.4.0.5.4");
            store_Location.AddNewStoreLocation();
            store_Location.CreateNewLocation(locationCode, locationName);            
        }
        

        /// <summary>
        /// method to drag and drop column from column chooser
        /// </summary>
        /// <param name="column"></param>
        [Then(@"select column chooser for column name '(.*)'")]
        public void ThenSelectColumChooserForColumName(string column)
        {
            store_Location.ChooseAColumn(column);
        }
        /// <summary>
        /// Edit column value to yes
        /// </summary>
        /// <param name="column"></param>
        [Then(@"Edit '(.*)' to Yes")]
        public void ThenEditToYes(string column)
        {
            store_Location.EditStoreLocationClick();
            if (column== "Send Department/Commodity")
                store_Location.EditCommodityFlagToYes();
        }
        /// <summary>
        /// Remve column from store locations table
        /// </summary>
        /// <param name="column"></param>
        [Then(@"remove '(.*)' from table")]
        public void ThenRemoveFromTable(string column)
        {
            store_Location.RemoveChoosedColumn(column);
        }
        /// <summary>
        /// set the column to yes
        /// </summary>
        /// <param name="column"></param>
        [Then(@"choose '(.*)' to yes")]
        public void ThenChooseToYes(string column)
        {
            store_Location_SR.setFlagToTrue(column);
        }
        /// <summary>
        /// User click on Queue Manager Item should be displayed on the Menu
        /// </summary>
        [Then(@"User click on Queue Manager Item should be displayed on the Menu")]
        public void ThenUserClickOnQueueManagerItemShouldBeDisplayedOnTheMenu()
        {
            queueManager.QueueManagerMenuClick();
        }
        /// <summary>
        /// User click on scale queue
        /// </summary>
        [When(@"user click the Scale queue")]
        public void WhenUserClickTheScaleQueue()
        {
            queueManager.scaleQueueDoubleClick();
        }
        /// <summary>
        /// User navigate to History tab
        /// </summary>
        [When(@"navigate to history tab")]
        public void WhenNavigateToHistoryTab()
        {
            queueManager.HistoryTabClick();
        }
        /// <summary>
        /// View summary link click
        /// </summary>
        [Then(@"click on view summary of the entry")]
        public void ThenClickOnViewSummaryOfTheEntry()
        {
            queueManager.viewSummaryLinkClick();
        }
        /// <summary>
        /// Validate queue message for location A
        /// </summary>
        [Then(@"Validate queue message for location A")]
        public void ThenValidateQueueMessageForLocationA()
        {
            queueManager.validateQueueMessageA();
        }
        /// <summary>
        /// Validate queue message for location B
        /// </summary>
        [Then(@"Validate queue message for location B")]
        public void ThenValidateQueueMessageForLocationB()
        {
            queueManager.validateQueueMessageB();
        }
        /// <summary>
        /// Validate queue message for location C
        /// </summary>
        [Then(@"Validate queue message for location C")]
        public void ThenValidateQueueMessageForLocationC()
        {
            queueManager.validateQueueMessageC();
        }
        /// <summary>
        /// Validate queue message for location D
        /// </summary>
        [Then(@"Validate queue message for location D")]
        public void ThenValidateQueueMessageForLocationD()
        {
            queueManager.validateQueueMessageD();
        }
        /// <summary>
        /// close the view summary popup
        /// </summary>
        [Then(@"close the view summary popup")]
        public void ThenCloseTheViewSummaryPopup()
        {
            queueManager.refreshPage();
        }

    }
}
