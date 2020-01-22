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

namespace Labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int number = 0;
        //Creating lists
        List<Band> bandnames = new List<Band>();
        List<Band> selectedband = new List<Band>();
        List<Band> filteredband = new List<Band>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Band B1 = new Band("The Beatles", "1957", " John Lennon, Paul McCartney, Ringo Starr");
            Band B2 = new Band("Westlife", "1998", " Brian McFadden, Shane Filan, Markus Feehily, Nicky Byrne, Kian Egan");
            Band B3 = new Band("U2", "1976", " Bono, The Edge, Adam Clayton, Larry Mullen Jr., Ivan McCormick, Peter Martin, Dick Evans");
            Band B4 = new Band("TakeThat", "1990", "Robbie Williams, Gary Barlow, Mark Owen, Jason Orange");
            Band B5 = new Band("OneDirection", "2015", " Harry Styles, Zayn Malik, Louis Tomlinson, Niall Horan, Liam Payne");
            Band B6 = new Band("Abba", "1972", "Agnetha FältskogBjörn UlvaeusBenny AnderssonAnni - Frid Lyngstad");




            //add to list
            bandnames.Add(B1);
            bandnames.Add(B2);
            bandnames.Add(B3);
            bandnames.Add(B4);
            bandnames.Add(B5);
            bandnames.Add(B6);


            //display in listbox
            lbxBandNames.ItemsSource = bandnames; //tell listbox that the source of items is the list activitie







        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboGenre_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
