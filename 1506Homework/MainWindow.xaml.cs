
using Microsoft.Data.SqlClient;
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

namespace _1506Homework
{
    public partial class MainWindow : Window
    {
        MainContext context = new MainContext();
        public MainWindow() 
        {
            InitializeComponent();
            ComboBox.ItemsSource = new List<string> {"Students", "Teachers"};
        }

        private void GetBtn(object sender, RoutedEventArgs e)
        {
            switch (ComboBox.SelectedItem)
            {
                case "Students":
                    DataGrid.ItemsSource = context.Students.Local.ToObservableCollection();
                    break;
                case "Teachers":
                    DataGrid.ItemsSource = context.Teachers.Local.ToObservableCollection();
                    break;
            }
        }

        private void UpdateBtn(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
        }
    }
}

