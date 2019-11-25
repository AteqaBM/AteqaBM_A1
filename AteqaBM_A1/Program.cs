using System;

namespace AteqaBM_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test Customer Class
            Customer customer = new Customer();
            customer.name = "Customer Name: Ateqa";
            customer.email = "Customer Email: aateqabm@gmail.com";
            Console.WriteLine(customer.Name());
            customer.NationalId();
            Console.WriteLine(customer.Email());


            // Test Bank Account Class
            Bank_Account rAcount = new Bank_Account();
            rAcount.accountNumber = 192001535;
            Console.WriteLine("Customer regular account number:" + rAcount.accountNumber);
            rAcount.Balance = 1500.0;
            Console.WriteLine("The balance in the regular account is:" + rAcount.Balance);
            rAcount.Deposit = 30.0;
            Console.WriteLine("The balance after depositing " + rAcount.Deposit + " is :" + rAcount.AccountBalance());
            rAcount.Withdraw = 70.0;
            Console.WriteLine("The balance after withdrawing " + rAcount.Withdraw + " is :" + rAcount.AccountBalance2());

            // Test Saving Account Class
            Saving_Account sAccount = new Saving_Account();
            sAccount.accountNumber = 191001535;
            Console.WriteLine("Customer saving account number:" + sAccount.accountNumber);
            sAccount.Balance = 1000.0;
            Console.WriteLine("The balance in the saving account is:" + sAccount.Balance);
            sAccount.Deposit = 100.0;
            Console.WriteLine("The balance after depositing " + sAccount.Deposit + " is :" + sAccount.AccountBalance());
            sAccount.Withdraw = 5.0;
            Console.WriteLine("The balance after withdrawing " + sAccount.Withdraw + " is :" + sAccount.AccountBalance2());
            sAccount.Rate = 103.0;
            double irate = sAccount.Rate;

            // transfer method from regular account to saving account
            //private static double Transfer(Bank_Account rAcount, Saving_Account sAccount)
            //{
            //    return rAcount.Withdraw + sAccount.Balance;
                
            //}
            // transfer method from saving account to regular account
            //private static double Transfer(Bank_Account rAcount, Saving_Account sAccount)
            //{
            //    return sAccount.Withdraw + rAcount.Balance;

            //}



        }
    }
}
