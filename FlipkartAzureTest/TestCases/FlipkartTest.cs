namespace FlipkartAzureTest.TestCases
{
    using FlipkartAzureTest.BaseClass;
    using NUnit.Framework;
    using FlipkartAzureTest.Pages;
    class FlipkartTest:BaseClass
    {
        [Test,Order(0)]
        public void LoginTest()
        {
            Login login = new Login(driver);
            login.LoginPage();
        }

        [Test, Order(1)]
        public void SearchProductTest()
        {
            SearchProduct search = new SearchProduct(driver);
            search.SearchProductPage();
        }
    }
}
