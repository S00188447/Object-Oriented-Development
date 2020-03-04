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

namespace LabSheet4_Excercise2
{

    public partial class MainWindow : Window
    {
        
        AdventureLiteEntities db = new AdventureLiteEntities();
        public MainWindow()
        {
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from o in db.SalesOrderHeaders
                        orderby o.Customer.CompanyName
                        select o.Customer.CompanyName;

            //lbxCustomers.ItemsSource = query.ToList().Distinct();         
        }

        private void lbxCustomers_SelectionChanged(object sender, RoutedEventArgs e)
        {

            //string customer = lbxCustomers_SelectionChanged.SelectedItem as string;
            string customer = "";

            if(customer != null)
            {
                //var query = from o in db.SalesOrderHeaders
                //            where o.Customer.CompanyName.Equals(customer)
                //            select new OrderSummary
                //            {
                //                SalesOrderID = o.SalesOrderID,
                //                OrderDate = o.OrderDate,
                //                TotalDue = o.TotalDue
                //            };

                //var query from o in db.SalesOrderHeaders
                //          where o.Customer.CompanyName.Equals(customer)
                //          select o;

                //lbxOrders.ItemSource = query.ToList();
            }


    
        }

        private void lbxOrders_SelectionChanged(object sender, RoutedEventArgs e)
        {

            //int orderID = Convert.ToInt32(lbxOrder.SelectedValue);
            int orderID = 1;

            if (orderID > 0)
            {
                var query = from od in db.SalesOrderDetails
                            where od.SalesOrderID == orderID
                            select new
                            {
                                ProductName = od.Product.Name,
                                od.UnitPrice,
                                od.UnitPriceDiscount,
                                od.OrderQty,
                                od.LineTotal
                            };

                //dgOrderDetails.ItemsSource = query.ToList();
            }
     
        }


    }
}
