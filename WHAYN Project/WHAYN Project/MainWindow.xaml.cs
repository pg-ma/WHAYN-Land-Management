using Bogus;
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

namespace WHAYN_Project
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

        private void HOME_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Home();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void LstOfEngrBtn_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new LstEngr();
        }

        private void BROWSE_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Browse();
        }

        private void TRACKER_Click(object sender, RoutedEventArgs e)
        {
            CC.Content = new Tracker();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CC.Content = new Home();
        }
    }
}
