﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using FlipkartAzureTest;

namespace FlipkartAzureTest.BaseClass
{
    class BaseClass
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Initialization()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito", "--start-maximized", "--disable-notifications", "--ignore-certificate-errors");
            driver = new ChromeDriver(options);
            driver.Url = "https://www.flipkart.com/";
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
