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

namespace LINQ_Questions
{

    public partial class MainWindow : Window
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TabItem_KeyDown(object sender, KeyEventArgs e)
        {

        }


        //exercise 1 - joining

        private void Ex1Button_Click(object sender, KeyEventArgs e)
        {
            var query = from c in db.Categories
                        join p in db.Products on c.CategoryName equals p.Category.CategoryName
                        orderby c.CategoryName
                        select new
                        {
                            Category = c.CategoryName,
                            Product = p.ProductName
                        };

            var results = query.ToList();

            Ex1DgDisplay.ItemsSource = results;

            Ex1tblkCount.Text = results.Count.ToString();

            

        }


        //excercise 2 - simplier version, same result
        private void Ex2Button_Click(object sender, KeyEventArgs e)
        {
            var query = from p in db.Products
                        orderby p.Category.CategoryName, p.ProductName
                        select new { Category = p.Category.CategoryName,
                            Product = p.ProductName };
            var results = query.ToList();

            Ex2DgDisplay.ItemsSource = results;

            Ex2tblkCount.Text = results.Count.ToString();



        }


        //excercise 3 - count, sum, average
        private void Ex3Button_Click(object sender, KeyEventArgs e)
        {
            //return the total number of orders for product 7
            var query1 = (from detail in db.Order_Details
                          where detail.ProductID == 7
                          select detail);

            //return the total value of orders for product 7
            var query2 = (from detail in db.Order_Details
                          where detail.ProductID == 7
                          select detail.UnitPrice * detail.Quantity);

            int numberOfOrders = query1.Count();
            decimal totalValue = query2.Sum();
            decimal averageValue = query2.Average();

            Ex3tblkDetails.Text = string.Format(
                "Total number of order {0} \n Value of Orders {1:C}" +
                "\n Average Order Value  {2:C}",
                numberOfOrders, totalValue, averageValue);
        }

        //excercise 4 - Retrieves customers with order >=20
        private void Ex4Button_Click(object sender, KeyEventArgs e)
        {


            var query = from customer in db.Customers
                        where customer.Orders.Count >= 20
                        select new
                        { Name = customer.CompanyName,
                             OrderCount = customer.Orders.Count };
            Ex4DgDisplay.ItemsSource = query.ToList();


        }
        //excercise 5 - Customers with less than 3 orders
        private void Ex5Button_Click(object sender, KeyEventArgs e)
        {


            var query = from customer in db.Customers
                        where customer.Orders.Count <3
                        select new
                        {
                            Company = customer.CompanyName,
                            City = customer.City,
                            Region = customer.Region,
                            OrderCount = customer.Orders.Count
                            
                        };
            Ex5DgDisplay.ItemsSource = query.ToList();


        }

        //excercise 6 part 1 - All customers displayed in the list box. Selecting a new customer retrieves the total amount of
        //orders from that customer displayed in a textblock to the right
        private void Ex6Button_Click(object sender, KeyEventArgs e)
        {


            var query = from customer in db.Customers
                        orderby customer.CompanyName
                        select customer.CompanyName;

            Ex6LbxEx6Customers.ItemsSource = query.ToList();


        }

        //excercise 6 part 2
        private void lbxEx6Customers_SelectionChanged(object sender, KeyEventArgs e)
        {
            string company = (string)Ex6LbxEx6Customers.SelectedItem;

            if(company != null)
            {
                var query = (from detail in db.Order_Details
                             where detail.Order.Customer.CompanyName == company
                             select detail.UnitPrice * detail.Quantity).Sum();
                Ex6TblkEx6OrderSummary.Text = string.Format("Total for supplier {0}" +
                    "\n\n {1:C}", company, query);
            }

        }

        //excercise 7 - Here we are grouping info
        //we want the products grouped by category name
        //we are displaye the category name and the number of 
        //products in each category and sorting in desc
        private void Ex7Button_Click(object sender, KeyEventArgs e)
        {

            var query = from p in db.Products
                        group p by p.Category.CategoryName into g
                        orderby g.Count() descending
                        select new
                        {
                        Category = g.Key,
                        Count = g.Count()
                        };

            Ex7DgDisplay.ItemsSource = query.ToList();





        }


    }
}
