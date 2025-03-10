using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
    /// Interaction logic for Browse.xaml
    /// </summary>
    public partial class Browse : UserControl
    {
        NewLot Property = (NewLot)Application.Current.Resources["AddedLot"];
        public Browse()
        {
            InitializeComponent();
            DataContext = Property;
        }

        private void TxtSearch_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            SetBackgroundVisibility();

            var vm = new ViewModel();
            DataContext = vm;

            ListViewProducts.ItemsSource = null;
            ListViewProducts.Items.Clear();

            string input = TxtSearch.Text.Trim().ToLower();
            var list = vm.Lot;
            var output = list.Where(c => c.Name.ToLower().Contains(input) ||
                                    c.SpaceType.ToString().Contains(input))

                .OrderBy(c => c.Name).ToList();

            foreach (var item in output)
            {
                ListViewProducts.Items.Add(item);
            }
        }

        private void SetBackgroundVisibility()
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
            {
                TblSearch.Visibility = Visibility.Visible;
            }
            else
            {
                TblSearch.Visibility = Visibility.Hidden;
            }
        }

        //private void LoadList()
        //{
        //    var list = GetProducts();

        //    foreach (var item in list)
        //    {
        //        ListViewProducts.Items.Add(item);
        //    }
        //}

        //private List<Lots> GetProducts()
        //{
        //    var list = new List<Lots>();

        //    list.Add(new Lots("Product 1", "/Image/1.jpg",10_000));
        //    list.Add(new Lots("Product 1", "/Image/2.jpg", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/3.jpg", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/4.jpg", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/5.jfif", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/6.png", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/7.jpg", 10_000));
        //    list.Add(new Lots("Product 1", "/Image/8.jpg", 10_000));

        //    //return new List<Lots>()
        //    //  {
        //    //    new Lots("Product 1", "/Image/cutie panda.png"),
        //    //    new Lots("Product 1", "/Image/mint.png"),
        //    //  };

        //    return list;
        //}

        //public List<Lots> _list = new List<Lots>();

        //private void LoadAreas()
        //{
        //    var faker = new Faker();
        //    faker.Random = new Randomizer(928);

        //    for (int i = 0; i < 50; i++)
        //    {
        //        string title = faker.Address.StreetAddress();
        //        float price = faker.Random.Float(100_000, 50_000_000);
        //        string image = faker.Image.PicsumUrl();

        //        var browsedetails = new Lots(title, image, price);

        //        _list.Add(browsedetails);
        //    }

        //    foreach (var i in _list)
        //    {
        //        ListViewProducts.Items.Add(i);
        //    }
        //}


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var vm = new ViewModel();
            DataContext = vm;

            if(DataContext is NewLot newLot)
            {
                foreach (var i in newLot.NewLotProperty)
                {
                    ListViewProducts.Items.Add(i);
                }
            }
        }

        private void ListViewProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            AreaDetails areainfo = new AreaDetails(this);
            areainfo.Owner = Application.Current.MainWindow;
            areainfo.ShowDialog();
        }

        private void SellLot_Click(object sender, RoutedEventArgs e)
        {
            Sell sell = new Sell();
            sell.Owner = Application.Current.MainWindow;
            sell.ShowDialog();
        }

    }
}
