using System;
using System.Collections.Generic;
using System.Text;

namespace AteqaBM_A1
{
    // regular account class inhireted from the customer class
    class Bank_Account : Customer
    {
        // regular account number attribute
        public int accountNumber { get; set; }

        //Positive Balance 
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { if (value >= 0) balance = value; }
        }

        // owner derived from customer class
        public Customer Owner { get; set; }

        // Positive Deposit property 
        private double deposit;
        public double Deposit
        {
            get { return deposit; }
            set { if (value >= 0) deposit = value; else Console.WriteLine("Deposited amount can't be negative"); }
        }

        // total balance method after depsting 
        public virtual double AccountBalance()
        {
            return Balance + Deposit;
        }

        // Positive Withdraw property
        private double withdraw;
        public double Withdraw
        {
            get { return withdraw; }
            set { if (value >= 0) withdraw = value; else Console.WriteLine("Withdrawn amount can't be negative"); }
        }

        // total balance method after withdrawing
        public double AccountBalance2()
        {

            return AccountBalance() - Withdraw;
        }

        // transfer method 
        
    }
}
