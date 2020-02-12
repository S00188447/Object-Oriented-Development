using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            NumbersLambda();
            NumbersQuery();
        }

        private static void NumbersLambda()
        {

            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers = numbers.Where(n => n > 5).OrderByDescending(n => n);

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            Console.ReadLine();

        }

        private static void NumbersQuery()
        {

            int[] numbers = { 1, 5, 3, 6, 11, 2, 15, 21, 13, 12, 10 };

            var outputNumbers =
                from number in numbers
                where number > 5
                orderby number
                select number;

            foreach (int number in outputNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            Console.ReadLine();

        }
    }
}
