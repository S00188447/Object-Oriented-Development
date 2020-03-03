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

namespace LabSheet4
{

    public partial class MainWindow : Window
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            //lbxStock.ItemsSource = Enum.GetNames(typeof(StockLevel));

            var query1 = from s in db.Suppliers
                         orderby s.CompanyName
                         select new
                         {
                             SupplierName = s.CompanyName,
                             SupplierID = s.SupplierID,
                             Country = s.Country
                         };

            

            lbxSuppliers.ItemsSource = query1.ToList();

            var query2 = query1
            .OrderBy(s => s.Country)
            .Select

        }

        private void lbxStock_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
