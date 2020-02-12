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

            //Please uncomment the excercise you want to test

            string[] names = { "Mary", "Joseph", "Michael", "Sarah", "Margaret", "John" };

            //ex 6 - display names
            var query = names.OrderBy(n => n);

            /////////////////////

            ////ex 7 - display names alphabetically
            //var query = from name in names
            //                     orderby name
            //                     select name;

            /////////////////////

            //ex 8 - include only names with M
            //var query = from name in names
            //            where name.StartsWith("M")
            //            orderby name
            //            select name;

            /////////////////////

            //ex 9 - Create a LINQ query which extracts customer names where the City is Dublin
            //List<Customers> customers = Getcustomers();
            //var query = from cust in customers
            //where cust.City == "Dublin"
            //select cust.Name;

            /////////////////////

            ////ex 10 - include Dublin or Galway names and order by name
            //List<Customers> customers = Getcustomers();
            //var query = from cust in customers
            //            where cust.City == "Dublin" || cust.City == "Galway"
            //            select cust.Name;



            //Will run everytime depending on what excecise that isn't commented out
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        private static List<Customers> Getcustomers()
        {
   
            //Creating values for the list
            Customers cust1 = new Customers("John", "Dublin");
            Customers cust2 = new Customers("Mary", "Galway");
            Customers cust3 = new Customers("Jason", "Cork");
            Customers cust4 = new Customers("Michael", "Galway");
            Customers cust5 = new Customers("Tomas", "Dublin");

            List<Customers> customers = new List<Customers>();

            //add to list
            customers.Add(cust1);
            customers.Add(cust2);
            customers.Add(cust3);
            customers.Add(cust4);
            customers.Add(cust5);

            return customers;
        }
    }
}
