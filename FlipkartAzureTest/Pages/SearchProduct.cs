namespace FlipkartAzureTest.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    class SearchProduct
    {
        public IWebDriver driver;

        public SearchProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        IWebElement searchBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//body/div/div/div/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")]
        IWebElement product { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Sort By')]")]
        IWebElement sortBy { get; set; }

        public void SearchProductPage()
        {
            searchBox.SendKeys("Iphone"+ Keys.Enter);
            Thread.Sleep(3000);
            product.Click();
            Thread.Sleep(3000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            Thread.Sleep(2000);
        }

        public string validatePage()
        {
            return sortBy.Text;
        }
    }
}