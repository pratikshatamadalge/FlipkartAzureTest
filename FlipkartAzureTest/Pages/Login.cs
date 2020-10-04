// <copyright file="Login.cs" company="Bridgelabz">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FlipkartAzureTest.Pages
{
    using System.Configuration;
    using System.Threading;
    using OpenQA.Selenium;
    using SeleniumExtras.PageObjects;

    public class Login
    {
        readonly string MobileNo = ConfigurationManager.AppSettings["mobileNo"];
        readonly string Password = ConfigurationManager.AppSettings["password"];
        public IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div//form//div[1]//input[1]")]
        IWebElement mobileNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//div//div//div//div//div//div//div[2]//input[1]")]
        IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//div//div//form//div//button//span[contains(text(),'Login')]")]
        IWebElement loginBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'My Account')]")]
        IWebElement myAccount { get; set; }

        public void LoginPage()
        {
            mobileNo.SendKeys(MobileNo);
            password.SendKeys(Password);
            loginBtn.Click();
            Thread.Sleep(4000);
        }

        public string validatePage()
        {
            Thread.Sleep(4000);
            return myAccount.Text;
        }
    }
}
