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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for PortUnion.xaml
    /// </summary>
    public partial class PortUnion : Window
    {
        public PortUnion()
        {
            InitializeComponent();
        }

        private void slot1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Its Occupied");
        }

        private void slot2(object sender, RoutedEventArgs e)
        {
            Booking b = new Booking();
            this.Visibility = Visibility.Hidden;
            b.Show();
        }

        private void slot3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Its Occupied");
        }

        private void slot4(object sender, RoutedEventArgs e)
        {
            Booking b = new Booking();
            this.Visibility = Visibility.Hidden;
            b.Show();
        }

        private void slot5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Its Occupied");
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Toronto t = new Toronto();
            this.Visibility = Visibility.Hidden;
            t.Show();
        }
    }
}
