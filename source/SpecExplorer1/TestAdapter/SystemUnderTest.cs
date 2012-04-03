using System;

namespace TestAdapter
{
    public class SystemUnderTest
    {
        static ShopClient.Model.ShopBackend shop;
        static SystemUnderTest()
        {
            shop = new ShopClient.Model.ShopBackend();
            shop.SimulatedDelay = 100;
        }

        public static event Action<string> LoginSuccessful;
        public static event Action<string> UnknownUser;
        public static event Action<string, string> PurchaseSuccessful;
        public static event Action<string, string, string> PurchaseFailed;

        public static void Login(string user, string pass)
        {
            var login = shop.Login(user, pass);
            login.ContinueWith(t =>
            {
                if (t.Result.Successful) LoginSuccessful(t.Result.Username);
                else UnknownUser(t.Result.Username);
            });
        }

        public static void Logout(string user)
        {
            var logout = shop.Logout(user);
            logout.Wait();
        }

        public static void Purchase(string user, string item)
        {
            var purchase = shop.Purchase(user, item);
            purchase.ContinueWith(t =>
            {
                if (string.IsNullOrEmpty(t.Result.Error)) PurchaseSuccessful(t.Result.Username, t.Result.Item);
                else PurchaseFailed(t.Result.Username, t.Result.Item, t.Result.Error);
            });
        }
    }
}
