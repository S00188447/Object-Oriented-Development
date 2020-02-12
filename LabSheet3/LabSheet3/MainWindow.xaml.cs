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

namespace LabSheet3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
          
        }

        private void BtnqueryEx1_Click(object sender, RoutedEventArgs e)
        {
            //excercise 1 - retrieves customers names
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = from c in db.Customers
                        select c.CompanyName;

          //  lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx2_Click(object sender, RoutedEventArgs e)
        {
            //excercise 2 - retrieves customer objects
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = from c in db.Customers
                        select c;

            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx3_Click(object sender, RoutedEventArgs e)
        {
            //excercise 3 - retrieves order information
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = from o in db.Orders
                        where o.Customer.City.Equals("London")
                        || o.Customer.City.Equals("Paris")
                         || o.Customer.Country.Equals("Usa")
                        orderby o.Customer.CompanyName
                        select new
                        {
                            CustomerName = o.Customer.CompanyName,
                            City = o.Customer.City,
                            Address = o.ShipAddress
                        };

            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx4_Click(object sender, RoutedEventArgs e)
        {
            //excercise 4 - retrieves product information
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = from p in db.Products
                        where p.Category.CategoryName.Equals("Beverage")
                        orderby p.ProductID descending
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.Category.CategoryName,
                            p.UnitPrice
                   

                        };

            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx5Click(object sender, RoutedEventArgs e)
        {
            //excercise 5 - inserts a product
            NORTHWNDEntities db = new NORTHWNDEntities();

            Product p = new Product()
            {
                ProductName = "Kickapoo",
                UnitPrice = 12.49m,
                CategoryID = 1
            };

            db.Products.Add(p);
            db.SaveChanges();
            //ShowProducts();
            //lbxQuery.ItemSourced = query.ToList();
        }

        private void ShowProducts(DataGrid currentGrid)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = from p in db.Products
                        where p.Category.CategoryName.Equals("Beverage")
                        orderby p.ProductID descending
                        select new
                        {
                            p.ProductID,
                            p.ProductName,
                            p.Category.CategoryName,
                            p.UnitPrice
                        };

            currentGrid.ItemsSource = query.ToList();
        }

        private void BtnqueryEx6Click(object sender, RoutedEventArgs e)
        {
            //excercise 6 - Updates product info
            NORTHWNDEntities db = new NORTHWNDEntities();

            Product p1 = (db.Products
                .Where(p => p.ProductName.StartsWith("Kick"))
                .Select(p => p)).First();

            p1.UnitPrice = 100m;  
            db.SaveChanges();
            //ShowProducts(dgCustomerEx6);
            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx7Click(object sender, RoutedEventArgs e)
        {
            //excercise 7 - Multiple update
            NORTHWNDEntities db = new NORTHWNDEntities();

            var products = from p in db.Products
                           where p.ProductName.StartsWith("Kick")
                           select p;

            foreach(var item in products)
            {
                item.UnitPrice = 100m;
            }

            db.SaveChanges();
            //ShowProducts(dgCustomerEx6);
            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx8Click(object sender, RoutedEventArgs e)
        {
            //excercise 8 - Deletes data
            NORTHWNDEntities db = new NORTHWNDEntities();

            var products = from p in db.Products
                           where p.ProductName.StartsWith("Kick")
                           select p;

            db.Products.RemoveRange(products);
            db.SaveChanges();
            //ShowProducts(dgCustomerEx6);
            //lbxQuery.ItemSourced = query.ToList();
        }

        private void BtnqueryEx9Click(object sender, RoutedEventArgs e)
        {
            //excercise 9 - Using A stored procedure
            NORTHWNDEntities db = new NORTHWNDEntities();

            var query = db.Customers_By_City("London");
            dgCustomerEx4.ItemsSource = query.ToList();

        }
    }
}
