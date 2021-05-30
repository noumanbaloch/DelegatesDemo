using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public class GenericDelegates
    {
        public double MultipleMethod(int i, int j)
        {
            return i * j;
        }

        public void SubtractionMethod(int i, int j)
        {
            int result = i - j;
            Console.WriteLine("Result of Subtraction = " + result);
        }

        public bool isAdult(int age)
        {
            return age >= 18;
        }
        public static void GenericDel()
        {
            //Func<> -- when you want to return something
            //Action<> -- when you do not want to return any thing
            //Predicate<> -- When you want to return bool
            GenericDelegates obj = new GenericDelegates();
            Func<int, int, double> func = obj.MultipleMethod;
            double result = func.Invoke(4, 5);
            Console.WriteLine("Output from Func = " + result);

            Action<int, int> action = obj.SubtractionMethod;
            action.Invoke(5, 3);

            Predicate<int> predicate = obj.isAdult;
            bool status = predicate.Invoke(19);

            Console.WriteLine("Predicate result = " + status);
            Console.ReadKey();
        }
    }
}
