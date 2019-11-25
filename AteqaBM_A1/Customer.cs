using System;
using System.Collections.Generic;
using System.Text;

namespace AteqaBM_A1
{
    // Intilaize a class called customer
    class Customer
    {
        //create necessary attributes for the customer class 

        //create const customer national id attribute because it will never change
        public const int nationalId = 2144522436;

        //create customer name attribute
        public string name;

        //create customer email attribute
        public string email;


        //create necessary behaviors for the customer class

        //create a method to print the national id
        public void NationalId()
        {
            Console.WriteLine($"Custome National Id: {nationalId}");
        }

        //create name method to call it againg in the main
        public string Name()
        {
            return name;
        }

        //create email method to call it againg in the main
        public string Email()
        {
            return email;
        }

        //CUSTOMER BANK ACOOUNTS 


    }
}
