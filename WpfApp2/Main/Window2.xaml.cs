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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            Window3 f3 = new Window3();
            this.Visibility = Visibility.Hidden;
            f3.Show();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            Window1 f1 = new Window1();
            this.Visibility = Visibility.Hidden;
            f1.Show();
        }
    }
}
