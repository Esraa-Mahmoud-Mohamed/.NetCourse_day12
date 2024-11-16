using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class BankAjent
    {
        public string AjentName { get; set; }
        public int AjentId { get; set; }

        public BankAjent()
        {
            AjentId = 123;
            AjentName = "Khattab";
        }

        //callback method
        public void WarnBankAccount(object sender, UnderBalancedEventArgs e)
        {
            if (sender is BankAccount ba && e.Delta>100)
            {
                Console.WriteLine($"Ajent {AjentName} warns {ba.Name} from under balanced!!!");
            }
        }
    }
}
