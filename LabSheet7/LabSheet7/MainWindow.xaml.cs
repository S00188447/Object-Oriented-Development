using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LabSheet7
{

    public partial class MainWindow : Window
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public MainWindow()
        {
            
        }

        //Ex1: Display number of customers per country, 
        //sorted descending by the number. Hint: You need group.
        private void Ex1Button_Click(object sender, RoutedEventArgs e)
        {

            var query = from c in db.Customers
                        group c by c.Country into g
                        orderby g.Count() descending
                        select new
                        {
                            Country = g.Key,
                            Count = g.Count()
                        };

            Ex1dgDisplay.ItemsSource = query.ToList();

        }


        //Ex2: Show customers from Italy.
        private void Ex2Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        where c.Country == "Italy"
                        orderby c.CompanyName
                        //select c;

                        select new
                        {
                            c.CompanyName,
                            c.Phone
                        };

            Ex2DgDisplay.ItemsSource = query.ToList().Distinct();

        }


        //Ex3: For each product,
        //display information if the product is available.  
        //Hint: Use Units in Stock – Units on Order > 0
        private void Ex3Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        where (p.UnitsInStock - p.UnitsOnOrder > 0)
                        select new
                        {
                            Product = p.ProductName,
                            Available = p.UnitsInStock - p.UnitsOnOrder
                        };

            Ex3DgDisplay.ItemsSource = query.ToList();
        }

        //Ex4: List all discounted products from all orders.
        private void Ex4Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from od in db.Order_Details
                        orderby od.Product.ProductName
                        where od.Discount > 0
                        select new
                        {
                            ProductName = od.Product.ProductName,
                            DiscountGiven = od.Discount,
                            OrderID = od.OrderID
                        };

            Ex4DgDisplay.ItemsSource = query.ToList();
        }
        //Ex5: Calculate the total freight over all orders.  
        //Use a textblock to show the results.
        private void Ex5Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        select o.Freight;

            //var query2 = db.Orders.Sum(o => o.Freight); //could use this too

            Ex5tblkResult.Text = string.Format("The total value of freight for all order is {0:C}", query.Sum());
        }

        //Ex6: Products and Categories in order of category name,
        //with the highest priced product,
        //in each category at the top of the list
        private void Ex6Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from p in db.Products
                        orderby p.Category.CategoryName, p.UnitPrice descending
                        select new
                        {
                            p.CategoryID,
                            p.Category.CategoryName,
                            p.ProductName,
                            p.UnitPrice
                        };

            var results = query.ToList();

           Ex6DgDisplay.ItemsSource = results;
        }

        //Ex7: Top 10 customers grouped by number of orders
        private void Ex7Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        group o by o.CustomerID into g
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID = g.Key,
                            NumberOfOrders = g.Count()
                        };

            //var combined = from c in db.Customers
            //               join p in query on c.CustomerID equals p.CustomerID
            //               orderby p.NumberOfOrders descending
            //               select new
            //               {
            //                   p.CustomerID,
            //                   c.CompanyName,
            //                   p.NumberOfOrders

            //               };
            //Ex7DgDisplay.ItemsSource = combined.ToList().Take(10);

            Ex7DgDisplay.ItemsSource = query.ToList().Take(10);
        }

        //Ex8: List numbers of orders grouped by customers.  
        //This is an amendment of above with a join added in.
        private void Ex8Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from o in db.Orders
                        group o by o.CustomerID into g
                        join c in db.Customers on g.Key equals c.CustomerID
                        orderby g.Count() descending
                        select new
                        {
                            CustomerID = c.CustomerID,
                            CompanyName = c.CompanyName,
                            NumberofOrders = c.Orders.Count
                        };
            Ex8DgDisplay.ItemsSource = query.ToList().Take(10);
        }

        //Ex9: List customer without orders.
        private void Ex9Button_Click(object sender, RoutedEventArgs e)
        {
            var query = from c in db.Customers
                        where c.Orders.Count == 0
                        orderby c.Orders.Count
                        select new
                        {
                            CompanyID = c.CustomerID,
                            CompanyName = c.CompanyName,
                            NumberOfOrders = c.Orders.Count
                        };

            //var query1 = from o in db.Orders
            //            select o.CustomerID;

            //var query2 = from c in db.Customers
            //            where !query1.Contains(c.CustomerID)
            //            select new
            //            {
            //                c.CustomerID,
            //                c.CompanyName,
            //                Count = c.Orders.Count()
            //            };

            Ex9DgDisplay.ItemsSource = query.ToList();
        }
    }
}
