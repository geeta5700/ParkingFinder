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
    /// Interaction logic for Reciept.xaml
    /// </summary>
    public partial class Reciept : Window
    {
        public Reciept()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Window3 f3 = new Window3();
            this.Visibility = Visibility.Hidden;
            f3.Show();
        }

        private void Submit(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Reciept Saved!!!");
        }
    }
}
