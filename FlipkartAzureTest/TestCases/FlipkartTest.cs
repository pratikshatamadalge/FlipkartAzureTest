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
    }
}
