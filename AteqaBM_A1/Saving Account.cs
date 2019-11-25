using System;
using System.Collections.Generic;
using System.Text;

namespace AteqaBM_A1
{
    // saving account class inherited from bank account class
    class Saving_Account : Bank_Account
    {
        // rate property; interest rate for saving account range between 0 and 100
        private double rate;
        public double Rate
        {
            get { return rate; }
            set { if (value >= 0 && value <= 100) rate = value; }
        }

        // total balance method after depsting and overriding from bank account to add bonus
        //0.02% to the account of the deposting amount 
        public override double AccountBalance()
        {
            return Balance + Deposit + (Deposit * 0.0002);
        }


    }
}
