using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static WHAYN_Project.Lots;

namespace WHAYN_Project
{
    /// <summary>
    /// Interaction logic for Sell.xaml
    /// </summary>
    public partial class Sell : Window
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void LoadSex()
        {
            var _enum = Enum.GetNames<Sex>();

            foreach (var i in _enum)
            {
                SexCmb.Items.Add(i);
            }

        }

        private void LoadLotType()
        {
            var _enumtwo = Enum.GetNames<LandType>();

            foreach (var i in _enumtwo)
            {
                TypeCmb.Items.Add(i);
            }

        }

        //public ObservableCollection<Lots> addedlot { get; set; } = new();

        //private void AddToList()
        //{
        //    ViewModel vm = new();
        //    DataContext= vm;

        //    var faker = new Faker();

        //    for (int i = 0; i < 1; i++)
        //    {
        //        string title = Title.Text;
        //        float price = float.Parse(Price.Text);
        //        string image = faker.Image.PicsumUrl();
        //        LandType spacetype = Enum.Parse<LandType>(TypeCmb.SelectedItem.ToString());
        //        string name = FullName.Text;
        //        string loc = Location.Text;
        //        float phonenum = float.Parse(NumTxt.Text);
        //        string email = EmailTxt.Text;
        //        float area = float.Parse(Size.Text);

        //        Lots browsedetails = new Lots(title, image, price, spacetype, name, loc, phonenum, email, area);

        //        addedlot.Add(browsedetails);
        //    }
            

        //}


        private void SellButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            SellConfirmationPage scp = new(this);
            scp.Owner = Application.Current.MainWindow;
            scp.ShowDialog();
            //AddToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSex();
            LoadLotType();
            

        }
    }
}
