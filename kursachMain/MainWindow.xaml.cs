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

namespace kursachMain
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // this.DataContext = new WindowViewModel(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e) //check praktic
        {
            //this.Hide();
            //Window w1 = new Window();
            //w1.Show();
            Windows.Practice pract = new Windows.Practice();
            pract.Show();
    
        }
        private void EscButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windows.Prepods prepWindow = new Windows.Prepods();
            prepWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Windows.Enterprises enterprice = new Windows.Enterprises();
            enterprice.Show();
        }
    }
}
