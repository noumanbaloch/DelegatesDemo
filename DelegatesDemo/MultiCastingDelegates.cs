using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void Dell(int x, int y);
    public class MultiCastingDelegates
    {
        public void Sum(int i, int j)
        {
            int result = i + j;
            Console.WriteLine("Addition Performed = " + result);
        }

        public void Sub(int i, int j)
        {
            int result = i - j;
            Console.WriteLine("Subtraction Performed = "  + result);
        }
        public static void MultiCaastingDel()
        {

            MultiCastingDelegates obj = new MultiCastingDelegates();
            //obj.Sum(3, 4); // 7
            //obj.Sub(5, 2); // 3

            Dell dell = new Dell(obj.Sum);
            dell += obj.Sub;

            dell(5, 7);
            Console.ReadKey();
        }
    }
}
