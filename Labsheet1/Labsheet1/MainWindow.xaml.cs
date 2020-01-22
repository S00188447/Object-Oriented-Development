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
        List<Band> bandNames = new List<Band>();
        List<Albums> albumNames = new List<Albums>();
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
            bandNames.Add(B1);
            bandNames.Add(B2);
            bandNames.Add(B3);
            bandNames.Add(B4);
            bandNames.Add(B5);
            bandNames.Add(B6);


            //display in listbox
            lbxBandNames.ItemsSource = bandNames; //tell listbox that the source of items is the list activitie



            Albums A1 = new Albums("Abbey Road", "1969", " 20 mil");
            Albums A2 = new Albums("Revolver", "1966", " 25 mil");
            Albums A3 = new Albums("Face to Face", "2001", " 3 mil");
            Albums A4 = new Albums("Back Home", "2006", " 5 mil");
            Albums A5 = new Albums("No line on the horizon", "2000", " 9 mil");
            Albums A6 = new Albums("The million dollar hotel", "2007", " 11 mil");
            Albums A7 = new Albums("Progress", "2001", " 6 mil ");
            Albums A8 = new Albums("Wonderland", "2006", " 4 mil");
            Albums A9 = new Albums("Up all night", "2015", " 21 mil");
            Albums A10 = new Albums("Take me home", "2016", " 18 mil");
            Albums A11 = new Albums("Arrival", "1977", " 15 mil");
            Albums A12 = new Albums("The Visitors", "1995", " 19 mil");

            B1.Albums.Add(A1);
            B1.Albums.Add(A2);
            B2.Albums.Add(A3);
            B2.Albums.Add(A4);
            B3.Albums.Add(A5);
            B3.Albums.Add(A6);
            B4.Albums.Add(A7);
            B4.Albums.Add(A8);
            B5.Albums.Add(A9);
            B5.Albums.Add(A10);
            B6.Albums.Add(A11);
            B6.Albums.Add(A12);


            //display in listbox
            lbxAlbumNames.ItemsSource = albumNames; //tell listbox that the source of items is the list activitie







        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboGenre_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
