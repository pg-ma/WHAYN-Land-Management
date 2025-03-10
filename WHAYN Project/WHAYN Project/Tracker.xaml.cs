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
    /// Interaction logic for Tracker.xaml
    /// </summary>
    public partial class Tracker : UserControl
    {
        NewLot Property = (NewLot)Application.Current.Resources["AddedLot"];
        public Tracker()
        {
            InitializeComponent();
            DataContext = Property;
        }

        private void TxtSearch_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            SetBackgroundVisibility();

            //var vm = new BuyLandApplication();
            //DataContext = vm;

            //LstApplicants.Items.Clear();

            //string input = TxtSearch.Text.Trim().ToLower();
            //var list = vm.applicants;
            //var output = list.Where(c => c.ApplicantFullName.ToLower().Contains(input) ||
            //                        c.ApplicantTrackerNum.ToString().Contains(input))

            //    .OrderBy(c => c.ApplicantFullName).ToList();

            //foreach (var item in output)
            //{
            //    LstApplicants.Items.Add(item);
            //}
        }

        private void SetBackgroundVisibility()
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
            {
                TblSearch.Visibility = Visibility.Visible;
                //BtnSearchClear.Visibility = Visibility.Hidden;
            }
            else
            {
                TblSearch.Visibility = Visibility.Hidden;
                //BtnSearchClear.Visibility = Visibility.Visible;
            }
        }

        //private List<Engrs> IDK = new List<Engrs>();


        //private void LoadList()
        //{
        //    var faker = new Faker();
        //    faker.Random = new Randomizer(928);

        //    for (int i = 0; i < 50; i++)
        //    {
        //        string fullname = faker.Name.FullName();
        //        string address = faker.Address.FullAddress();
        //        int phonenum = faker.Random.Number(0, 999999999);
        //        Cat cat = faker.PickRandom<Cat>();

        //        var engrinfo = new Engrs(fullname, address, phonenum, cat);

        //        IDK.Add(engrinfo);
        //    }

        //    foreach (var i in IDK)
        //    {
        //        LstEngrs.Items.Add(i);
        //    }

        //}

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            //LoadList();
            //BuyLandApplication bla = new();
            //DataContext= bla;

            if (DataContext is NewLot newLot)
            {
                foreach (var i in newLot.NewLotProperty)
                {
                   LstApplicants.Items.Add(i);
                }
            }
        }
    }
}
