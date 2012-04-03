using System.Collections.Generic;
using Microsoft.Modeling;

namespace SpecExplorer1
{
    /// <summary>
    /// An example model program.
    /// </summary>
    static class ModelProgram
    {
        #region model settings
        static readonly List<string> KnownUsers = new List<string>() { "admin", "guest" };
        static readonly List<string> ReadOnlyUsers = new List<string>() { "guest" }; 
        #endregion

        #region state
        private static SequenceContainer<string> loggedIn = new SequenceContainer<string>();
        private static SequenceContainer<string> loginRequests = new SequenceContainer<string>();
        private static MapContainer<string, string> purchaseRequests = new MapContainer<string, string>(); 
        #endregion

        #region login/logout
        [Rule(Action = "Login(user, pass)")]
        static void Login(string user, string pass)
        {
            Condition.IsFalse(loggedIn.Contains(user));
            Condition.IsFalse(loginRequests.Contains(user));
            loginRequests.Add(user);
        }

        [Rule(Action = "LoginSuccessful(user)")]
        static void LoginSuccessful(string user)
        {
            Condition.IsTrue(KnownUsers.Contains(user));
            Condition.IsTrue(loginRequests.Contains(user));
            loginRequests.Remove(user);
            loggedIn.Add(user);
        }

        [Rule(Action = "UnknownUser(user)")]
        static void UnknownUser(string user)
        {
            Condition.IsFalse(KnownUsers.Contains(user));
            Condition.IsTrue(loginRequests.Contains(user));
            loginRequests.Remove(user);
        }

        [Rule(Action = "Logout(user)")]
        static void Logout(string user)
        {
            Condition.IsTrue(loggedIn.Contains(user));
            Condition.IsFalse(loginRequests.Contains(user));
            loggedIn.Remove(user);
        } 
        #endregion

        #region purchase
        [Rule(Action = "Purchase(user, item)")]
        static void Purchase(string user, string item)
        {
            purchaseRequests.Add(user, item);
        }

        [Rule(Action = "PurchaseSuccessful(user, item)")]
        static void PurchaseSuccessful(string user, string item)
        {
            Condition.IsFalse(ReadOnlyUsers.Contains(user));
            Condition.IsTrue(loggedIn.Contains(user));
            Condition.IsTrue(purchaseRequests.ContainsKey(user));
            purchaseRequests.Remove(user);
        }

        [Rule(Action = "PurchaseFailed(user, item, \"user is not logged in\")")]
        static void PurchaseFailed_NotLoggedIn(string user, string item)
        {
            Condition.IsFalse(loggedIn.Contains(user));
            Condition.IsTrue(purchaseRequests.ContainsKey(user));
            purchaseRequests.Remove(user);
        }

        [Rule(Action = "PurchaseFailed(user, item, \"read only users have no rights\")")]
        static void PurchaseFailed_ReadOnlyUser(string user, string item)
        {
            Condition.IsTrue(loggedIn.Contains(user));
            Condition.IsTrue(ReadOnlyUsers.Contains(user));
            Condition.IsTrue(purchaseRequests.ContainsKey(user));
            purchaseRequests.Remove(user);
        } 
        #endregion
    }
}
