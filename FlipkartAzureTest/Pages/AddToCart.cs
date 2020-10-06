namespace FlipkartAzureTest.Pages
{
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;
    using System.Threading;

    class AddToCart
    {
        public IWebDriver driver;

        public AddToCart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/button[1]")]
        IWebElement addToCart { get; set; }

        public void AddToCartPage()
        {
           /* addToCart.Click();
            Thread.Sleep(3000);*/
        }

        public string validatePage()
        {
            //
            return addToCart.Text;
        }
    }
}
