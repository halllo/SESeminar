using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecExplorer1
{
    public static class ModelData
    {
        public static IEnumerable<string> UserNames()
        {
            yield return "admin";
            yield return "manuel";
            yield return "guest";
        }

        public static IEnumerable<string> Passwords()
        {
            yield return "geheim";
        }

        public static IEnumerable<string> Items()
        {
            yield return "pc";
        }

        public static IEnumerable<string> PurchaseFails()
        {
            yield return "no rights";
        }
    }
}
