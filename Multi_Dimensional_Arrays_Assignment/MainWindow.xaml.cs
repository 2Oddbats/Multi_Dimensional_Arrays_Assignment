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

namespace Multi_Dimensional_Arrays_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double[,] priceGrid;

        public MainWindow()
        {
            InitializeComponent();

            //double[,] priceGrid = new double[3, 3];

            priceGrid = new double[3, 3];

            priceGrid[0, 1] = 350.00;
            priceGrid[0, 2] = 700.00;
            priceGrid[1, 0] = 400.00;
            priceGrid[1, 2] = 550.00;
            priceGrid[2, 0] = 375.00;
            priceGrid[2, 1] = 500.00;

            //labelResult.Content = priceGrid[1, 2].ToString();
        }

        private void buttonPrice_Click(object sender, RoutedEventArgs e)
        {

            int fromCity;

            if (checkBoxChicago.IsChecked == true) fromCity = 0;
            else if (checkBoxNewYork.IsChecked == true) fromCity = 1;
            else fromCity = 2;

            int toCity;

            if (checkBoxChicagoTo.IsChecked == true) toCity = 0;
            else if (checkBoxNewYorkTo.IsChecked == true) toCity = 1;
            else toCity = 2;


            if (fromCity == toCity)
            {
                return;
                labelResult.Content = " ";
            }
            else labelResult.Content = priceGrid[fromCity, toCity].ToString();
            
            


        }
    }
}
