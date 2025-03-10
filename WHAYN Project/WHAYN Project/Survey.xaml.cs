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
using System.Windows.Xps.Packaging;

namespace WHAYN_Project
{
    /// <summary>
    /// Interaction logic for Survey.xaml
    /// </summary>
    public partial class Survey : Window
    {
        public Survey()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XpsDocument xpsdocs = new XpsDocument(@"C:\Users\USER\Downloads\SurveyLot.xps", System.IO.FileAccess.Read);
            View.Document = xpsdocs.GetFixedDocumentSequence();
        }
    }
}
