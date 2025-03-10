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
    /// Interaction logic for ConfirmationPage.xaml
    /// </summary>
    public partial class ConfirmationPage : Window
    {
        BuyLandApplication blp;
        public ConfirmationPage(BuyLandApplication lp)
        {
            InitializeComponent();
            this.blp = lp;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            PI1.Text = blp.FullName.Text;
            PI2.Text = blp.BirthDate.Text;
            PI3.Text = blp.Nationality.Text;
            PI4.Text = blp.SexCmb.Text;
            CD1.Text = blp.AddressTxt.Text;
            CD2.Text = blp.EmailTxt.Text;
            CD3.Text = blp.NumTxt.Text;
            NTC.Text = blp.NoteTxt.Text;
            TN.Text = blp.TrackNum.Text;
            TN.Visibility = Visibility.Collapsed;

        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            TrackerNum _tracker = new(this);
            _tracker.Owner = Application.Current.MainWindow;
            _tracker.ShowDialog();
            this.Close();
        }
    }
}
