using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   public class Account
    {
        private float balance;

        public void setBalance(float balance)   
                {
                    this.balance = balance;  //SETTER
                      if (balance >0)
                        this.balance = balance;
                }

                public float getBalance ()
                {

                    return balance;

                }

    }
}
