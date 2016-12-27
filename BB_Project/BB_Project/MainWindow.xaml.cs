using BB_DAL_EF;
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

namespace BB_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            City city = new City();
            city.City_Name = txtbName.Text;
            CityValidation cv = new CityValidation();
            if (cv.InsertCity(city))
            {
                MessageBox.Show("Inserted");
                txtbName.Clear();
            }
            else
                MessageBox.Show("Not Inserted");
            txtbName.Focus();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtbName.Focus();
        }


    }
}
