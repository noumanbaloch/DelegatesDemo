using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    public delegate void WishDelegate(string message);
    public class AnonymousMethods
    {
        public static void AnonymouseDel()
        {

            AnonymousMethods obj = new AnonymousMethods();
            //obj.WishBirthDay("May you live long");

            WishDelegate wish = delegate (string myWish)
            {
                Console.WriteLine(myWish);
            };

            wish("May you live long");
            Console.ReadKey();
        }
    }
}
