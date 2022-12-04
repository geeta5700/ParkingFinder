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
    /// Interaction logic for Booking.xaml
    /// </summary>
    public partial class Booking : Window
    {
        public Booking()
        {
            InitializeComponent();
        }

        private void genreciept(object sender, RoutedEventArgs e)
        {
            pay p= new pay();
            this.Visibility = Visibility.Hidden;
            p.Show();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            PortUnion pu = new PortUnion();
            this.Visibility = Visibility.Hidden;
            pu.Show();
        }
    }
}
