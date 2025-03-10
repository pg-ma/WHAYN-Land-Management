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

namespace WHAYN_Project
{
    /// <summary>
    /// Interaction logic for TrackerNum.xaml
    /// </summary>
    public partial class TrackerNum : Window
    {
        ConfirmationPage cp;
        public TrackerNum(ConfirmationPage cp1)
        {
            InitializeComponent();
            this.cp = cp1;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TrackNumTxt.Text = cp.TN.Text;
            
        }
    }
}
