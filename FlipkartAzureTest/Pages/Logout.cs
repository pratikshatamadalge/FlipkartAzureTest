namespace FlipkartAzureTest.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Logout
    {
        public IWebDriver driver;

        public Logout(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        IWebElement myAccount { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div[3]/div[1]/div[1]/div[1]")]
        IWebElement MyAccountDropdown { get; set; }

        [FindsBy(How = How.XPath, Using = "//body//div[@id='container']//div//div//div//div//div//li[10]//a[1]")]
        IWebElement logoutBtn { get; set; }
        
        public void LogoutPage()
        {
            Thread.Sleep(3000);
            myAccount.Click();
            Thread.Sleep(4000);
            MyAccountDropdown.Click();
            Thread.Sleep(5000);
            //logoutBtn.Click();
            //Thread.Sleep(5000);
        }
    }
}