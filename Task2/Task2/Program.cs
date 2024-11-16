namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region EventExample V01
            BankAccount account1 = 
                new BankAccount { AccountNo = 123, Name = "Marwan", Balance = 5000 }; 
            
            BankAjent ajent1=new BankAjent(); //khattab

            //subcribe to event
            account1.underBalanced += ajent1.WarnBankAccount;
            account1.underBalanced += BlackListAccounts.AddToBlackList;
            //
            account1.Credit(5020);
            //

            BankAccount account2 =
                new BankAccount { AccountNo = 456, Name = "Sara", Balance = 10_000 };

            EnterpriseBankAccount enterpriseBank =
                new EnterpriseBankAccount 
                { AccountNo = 556677,
                    Name = "Abc Company",
                    Balance = 10_000
                };
            enterpriseBank.underBalanced += ajent1.WarnBankAccount;
            enterpriseBank.underBalanced += BlackListAccounts.AddToBlackList;

            enterpriseBank.Transfer(account2, 15_000);


            Console.WriteLine("-----------------------------------");


            Console.WriteLine(BlackListAccounts.ReviewBlackListNames());

            #endregion
        }
    }
}

