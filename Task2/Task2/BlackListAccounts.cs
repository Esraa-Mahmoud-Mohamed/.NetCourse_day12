using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    //subscriber
    public static class BlackListAccounts
    {
        public static List<string> BlackListNames { get; }
        = new List<string>();

        public static void AddToBlackList(object sender, UnderBalancedEventArgs e)
        {
            var ba = sender as BankAccount;
            if (e.Delta > 100)
            {
                Console.WriteLine($"Proceed to add {ba.Name} into black list");
                BlackListNames.Add(ba.Name);
            }
        }
        public static string ReviewBlackListNames()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in BlackListNames) 
            {
                sb.Append(s);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }
    }
}
