using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 1, 5, 3, 6, 10, 12, 8 };

            var query1 = numbers.OrderByDescending(n => n);

            var query2 = query1.Where(n => n < 8);

            var query3 = query2.Select(n => Doubleit(n));

            var query4 = query3.OrderByDescending(n => n).Where(n => n < 8).Select(n => Doubleit(n));

            foreach (var item in query3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static int Doubleit(int value)
        {
            //Console.WriteLine("About to double the number" + value.ToString());
            return value * 2;
        }   
    }
}
