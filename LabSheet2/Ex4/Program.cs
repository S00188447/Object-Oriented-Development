using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {       
            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query = numbers.Select(n => Doubleit(n));

            Console.WriteLine("Before the foreach loop");

                foreach (var item in query)
                {
                Console.WriteLine(item);
                }
                Console.ReadLine();          
        }

        private static int Doubleit(int value)
        {

            Console.WriteLine("About to double the number" + value.ToString());
            return value * 2;
        }
    }
}
