using System;

namespace DesignPatterns
{
     class Program
    {
         static void Main(string[] args)
        {
            var account = new Account();  //create object
            account.deposit(amount: 10);
            account.withdraw(amount: 5);

            Console.WriteLine(account.getBalance());



            // Pushed to Remote Repo



            //  TaxCalculator calculator = getCalculator();   //dependency and ior coupling
        }
        /*  public static TaxCalculator getCalculator ()

          {
              return new TaxCalculator2019();
          }

          //    User user = new User(name:"Mosh", age: 30) ;
          //    user.sayHello();



              Console.WriteLine(user.name);  */
    }
}

