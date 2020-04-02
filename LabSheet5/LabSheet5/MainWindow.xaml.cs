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

namespace LabSheet5
{

    public partial class MainWindow : Window
    {

        Model1Container db = new Model1Container();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from b in db.Bands
                        select b;

            lbxBands.ItemsSource = query.ToList();
        }

        private void lbxBands_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //determine which band was selected
            Bands selectedBand = lbxBands.SelectedItem as Bands;


            //check for null
            if(selectedBand != null)
            {

                //display band info
                string bandText = $"Years Formed: {selectedBand.YearFormed} \nMembers: {selectedBand.Members}";

                tblkBandInfo.Text = bandText;

                //display band image
                imgBand.Source = new BitmapImage(new Uri($"/Images{selectedBand.BandImage}", UriKind.Relative));



                //display albums
                lbxAlbums.ItemsSource = selectedBand.Albums;

            }

     

        }
    }
}
