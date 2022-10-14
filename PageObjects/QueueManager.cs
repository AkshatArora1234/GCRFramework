using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace SpecFlow_MSTestFrameWork.PageObjects
{
    public class QueueManager
    {

        private IWebDriver Driver;
        public QueueManager(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement Searchbar => Driver.FindElement(By.XPath("//input[@id='search-text']"));
        IWebElement LeftMenu => Driver.FindElement(By.XPath("//*[@class='SideMenuWrapper SideMenuWrapperSmall']//*[@class='fa fa-bars N_P_A']"));
        IWebElement QueueManagerMenu => Driver.FindElement(By.XPath("//span/strong[text()='Queue Manager']"));
        IWebElement scaleQueue => Driver.FindElement(By.XPath("(//td[text()='Scale'])[1]"));
        IWebElement HistoryTab => Driver.FindElement(By.XPath("//uib-tab-heading[text()='HISTORY']"));
        IWebElement viewSummaryLink => Driver.FindElement(By.XPath("(//span[text()='View Summary'])[1]"));
        IWebElement QueueMessage => Driver.FindElement(By.XPath("//span[text()='Details']/ancestor::div//textarea"));
        IWebElement QueueMessage1 => Driver.FindElement(By.XPath("//textarea/ancestor::div[@class='panel-body']"));
        IWebElement QueueMessage2 => Driver.FindElement(By.XPath("//textarea/ancestor::div[@role='tabpanel']"));
        IWebElement QueueMessage3 => Driver.FindElement(By.XPath("//textarea[@ng-model='ctrl.detailedStacktrace']"));

        public void ClickLeftMenu()
        {
            Thread.Sleep(4000);
            LeftMenu.Click();
        }

        public void QueueManagerText()
        {
            Searchbar.Clear();
            Thread.Sleep(1000);
            Searchbar.SendKeys("Queue Manager");
        }
        public void QueueManagerMenuClick() => QueueManagerMenu.Click();
        public void HistoryTabClick() => HistoryTab.Click();
        public void viewSummaryLinkClick()
        {
            Thread.Sleep(1000);
            viewSummaryLink.Click();
        }
        public void scaleQueueDoubleClick()
        {
            Thread.Sleep(2000);
            Actions actions = new Actions(Driver);
            actions.DoubleClick(scaleQueue).Perform();
            Thread.Sleep(1000);
        }
        public string getQueueMessage()
        {
            Thread.Sleep(2000);
            string msg = QueueMessage.GetAttribute("value").ToString();
            return msg;            
        }
        public void validateQueueMessageA()
        {
            Thread.Sleep(2000);
            var msg = getQueueMessage();
            Assert.AreEqual(msg, "Scale location 'Plum Cakes' (59) not published for store 'Kingston' (1500). No print formats to publish.");
        }
        public void validateQueueMessageB()
        {
            Thread.Sleep(2000);
            var msg = getQueueMessage();
            Assert.AreEqual(msg, "Scale location 'Lays' (93) published for store 'Kingston' (1500). No print formats to publish.");
        }
        public void validateQueueMessageC()
        {
            Thread.Sleep(2000);
            var msg = getQueueMessage();
            Assert.AreEqual(msg, "Scale location 'Burgers' (51) published for store 'Kingston' (1500).");
        }
        public void validateQueueMessageD()
        {
            Thread.Sleep(2000);
            var msg = getQueueMessage();
            Assert.AreEqual(msg, "Scale location 'Rainbow cake' (66) published for store 'Kingston' (1500).");
        }
        public void refreshPage()
        {
            var url = Driver.Url;
            Driver.Navigate().GoToUrl(url);
        }
    }
}
