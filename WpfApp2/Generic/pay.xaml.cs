﻿using System;
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
    /// Interaction logic for pay.xaml
    /// </summary>
    public partial class pay : Window
    {
        public pay()
        {
            InitializeComponent();
        }

        private void back(object sender, RoutedEventArgs e)
        {
            Booking b = new Booking();
            this.Visibility = Visibility.Hidden;
            b.Show();
        }

        private void genreciept(object sender, RoutedEventArgs e)
        {
            Reciept re = new Reciept();
            this.Visibility = Visibility.Hidden;
            re.Show();
        }
    }
}
