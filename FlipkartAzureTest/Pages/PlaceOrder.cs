// <copyright file="PlaceOrder.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipkartAzureTest.Pages
{
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    class PlaceOrder
    {
        public IWebDriver driver;

        public PlaceOrder(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div/div/ul/li/button[1]")]
        IWebElement placeOrder { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Order Summary')]")]
        IWebElement orderSummary { get; set; }

        public void PlaceOrderPage()
        {
           /* Thread.Sleep(3000);
            placeOrder.Click();*/
        }

        public string validatePage()
        {
            return orderSummary.Text;
        }
    }
}
