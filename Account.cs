using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   public class Account
    {
        private float balance;

        public void deposit(float amount)
                {
         //same as below   this.balance = this.balance + amount;
                if (amount >0 )
                 this.balance += amount;


                }


        public void withdraw(float amount)
                 {
            
                if (amount > 0) 
                  
                    this.balance -= amount;
                  }


                public float getBalance ()
                {

                    return balance;

                }

    }
}
