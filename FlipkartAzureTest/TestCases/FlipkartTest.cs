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

        [Test, Order(2)]
        public void AddToCartTest()
        {
            AddToCart cart = new AddToCart(driver);
            cart.AddToCartPage();
        }

        [Test, Order(3)]
        public void PlaceOrderTest()
        {
            PlaceOrder order = new PlaceOrder(driver);
            order.PlaceOrderPage();
        }

        [Test, Order(4)]
        public void AddressTest()
        {
            Address address = new Address(driver);
            address.AddressPage();
        }
    }
}
