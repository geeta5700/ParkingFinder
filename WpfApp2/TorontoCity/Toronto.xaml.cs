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
    /// Interaction logic for Toronto.xaml
    /// </summary>
    public partial class Toronto1 : Window
    {
        
        private void Portunion(object sender, RoutedEventArgs e)
        {
            PortUnion pu = new PortUnion();
            this.Visibility = Visibility.Hidden;
            pu.Show();
        }

        private void rouge(object sender, RoutedEventArgs e)
        {
            Rouge r = new Rouge();
            this.Visibility = Visibility.Hidden;
            r.Show();
        }

        private void citycenter(object sender, RoutedEventArgs e)
        {
            CityCenter cc = new CityCenter();
            this.Visibility = Visibility.Hidden;
            cc.Show();
        }

        private void westhill(object sender, RoutedEventArgs e)
        {
            WestWill ww = new WestWill();
            this.Visibility = Visibility.Hidden;
            ww.Show();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Window3 f3 = new Window3();
            this.Visibility = Visibility.Hidden;
            f3.Show();
        }
    }
}
