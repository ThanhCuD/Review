using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            MyIEnumable<int> myList = new MyIEnumable<int>(new int[] { 1, 3, 4, 6, 34, 342 });
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
