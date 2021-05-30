using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //Delegates are type safe pointer to functions.
    public delegate void DynamicGreetingDel(string message);
    public class Delegates
    {
        public void DynamicGreeting(string message)
        {
            Console.WriteLine(message);
        }

        public static void StaticGreeting(string message)
        {
            Console.WriteLine(message);
        }
        public static void Del()
        {
            //By creating obj the class and then call the method with object.
            Delegates obj = new Delegates();
            //Delegates.StaticGreeting("Hello Static World");
            //obj.DynamicGreeting("Hello World");

            //Lets call the Dynamic Method with our Delegate

            DynamicGreetingDel dell = new DynamicGreetingDel(obj.DynamicGreeting);

            dell("Hello World from Basic Delegate Call");

            dell.Invoke("Hello World from Invoked way");

            DynamicGreetingDel dell2 = new DynamicGreetingDel(StaticGreeting);

            dell2("Hello from Static Delegate");
            dell2.Invoke("Hello static from Invoked way");


            DynamicGreetingDel dell3 = StaticGreeting;

            dell3.Invoke("From optimizated way");
            Console.ReadKey();


            //Create a delegate
            //Create instance of delgate and pass method name as a perameter
            //Invoke your method with delegate

        }
    }
}
