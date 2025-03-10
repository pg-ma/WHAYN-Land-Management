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
using System.Windows.Shapes;

namespace WHAYN_Project
{
    /// <summary>
    /// Interaction logic for AreaDetails.xaml
    /// </summary>
    public partial class AreaDetails : Window
    {
        Browse b1;
        public AreaDetails(Browse bp)
        {
            InitializeComponent();
            this.b1= bp;
            DataContext = b1.DataContext;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadInfo();
            AddString();

        }

        private void AddString()
        {
            string suffix = " sq. meters";
            AreaSize.Text += suffix;
        }


        //public List<LotInfo> details = new List<LotInfo>();

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            BuyLandApplication apply = new BuyLandApplication();
            apply.Owner = Application.Current.MainWindow;
            apply.ShowDialog();
            

        }

        private void LotDocuments_Click(object sender, RoutedEventArgs e)
        {
            DocumentViewer tanwa= new DocumentViewer();
            tanwa.Owner = Application.Current.MainWindow;
            tanwa.ShowDialog();
        }

        private void Survey_Click(object sender, RoutedEventArgs e)
        {
            Survey tanwa = new();
            tanwa.Owner = Application.Current.MainWindow;
            tanwa.ShowDialog();
        }

        //private void LoadInfo()
        //{
        //    var faker = new Faker();
        //    faker.Random = new Randomizer(928);

        //    for (int i = 0; i < 30; i++)
        //    {
        //        string name = faker.Person.FullName;
        //        string loc = faker.Address.Locale;
        //        float phonenum = faker.Random.Number(0, 999999999);
        //        string email = faker.Internet.Email(name);
        //        float area = faker.Random.Number(1_000, 20_000);

        //        var info = new LotInfo(name, loc, phonenum, email, area);

        //        details.Add(info);
        //    }
        //}
    }
}
