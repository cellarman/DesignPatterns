using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
   public class User
    {
        //Fields (attributes)

        public String name;

        public User(String name, int age)
        {
         
            
                this.name = name;   
 
        }

        //methods

        public void sayHello()
        {

            Console.WriteLine("Hi, my name is " + name);

        }
    }
}
