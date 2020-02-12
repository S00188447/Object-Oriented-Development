using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //exercise 7, sort alphabeticallym john should be first 

            var query1 = names.OrderByDescending(n => n).OrderBy(n => Alphabetize(n));

            //String.Concat(names.OrderBy(c => c))

            //ex 7
            var query = from name in names
                        orderby name
                        select name;

            //ex 8

            var query = from name in names
                        where name.StartsWith("W")
                        orderby name
                        select name

                        //ex 9

            list<Customer> customers = GetCustomers();
            var query = from cust in customers
                        where cust.city == "Dublin"
                        select cust.Name;

            //ex 10
            List<Customer> customers = GetCustiners();
            var query = from cust in customers
                        where (cust.city = "Dublin" || cust.city == "Galway")
                        orderby cust.name
                        select cust.name'


                var query = customers
                .where(customers => c.city == "Dublin")
                .select(customers => customers.Name);

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static string Alphabetize(string s)
        {
            // 1.
            // Convert to char array.
            char[] a = s.ToCharArray();

            // 2.
            // Sort letters.
            Array.Sort(a);

            // 3.
            // Return modified string.
            return new string(a);
        }

        private static List<Customers>GetCostumers()
        {

            List<Customers> customers = new List<Customers>;


        }
    }
}
