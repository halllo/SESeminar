using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopClient.Model
{
    #region Backend Events
    public class ShopBackendLogin
    {
        public string Username { get; internal set; }
        public bool Successful { get; internal set; }
    }
    public class ShopBackendPurchase
    {
        public string Username { get; internal set; }
        public string Item { get; internal set; }
        public string Error { get; internal set; }
    }
    #endregion

    public class ShopBackend
    {
        #region simulation
        public List<string> LoggedInUsers { get; set; }
        public int SimulatedDelay { get; set; }

        public ShopBackend()
        {
            LoggedInUsers = new List<string>();
            SimulatedDelay = 3000;
        } 
        #endregion

        #region login
        public Task<ShopBackendLogin> Login(string username, string password)
        {
            bool loginSuccess = username != "manuel";
            if (loginSuccess) LoggedInUsers.Add(username);
            return Task.Delay(SimulatedDelay).ContinueWith(t =>
                new ShopBackendLogin
                {
                    Username = username,
                    Successful = loginSuccess,
                });
        } 
        #endregion

        #region purchase
        public Task<ShopBackendPurchase> Purchase(string username, string item)
        {
            return Task.Delay(SimulatedDelay).ContinueWith(t =>
                new ShopBackendPurchase
                {
                    Username = username,
                    Item = item,
                    Error = CheckForUserValidity(username)
                });
        }

        private string CheckForUserValidity(string username)
        {
            if (LoggedInUsers.Contains(username))
            return UserIsLoggedIn(username);
            else 
                return UserIsNotLoggedIn();
        }

        private string UserIsLoggedIn(string username)
        {
            return username != "guest" ? null : "read only users have no rights";
        }

        private string UserIsNotLoggedIn()
        {
            return "user is not logged in";
        } 
        #endregion

        #region logout
        public Task Logout(string username)
        {
            if (LoggedInUsers.Contains(username)) LoggedInUsers.Remove(username);
            return Task.Delay(SimulatedDelay);
        } 
        #endregion
    }
}
