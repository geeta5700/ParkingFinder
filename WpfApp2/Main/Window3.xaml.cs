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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Toronto(object sender, RoutedEventArgs e)
        {
            Toronto t = new Toronto();
            this.Visibility = Visibility.Hidden;
            t.Show();

        }

        private void Kingston(object sender1, RoutedEventArgs f)
        {
            Kingston k = new Kingston();
            this.Visibility = Visibility.Hidden;
            k.Show();
        }
    }
}
