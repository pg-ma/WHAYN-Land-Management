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
using Bogus;
using System.Collections.ObjectModel;
using static WHAYN_Project.Lots;
using System.Diagnostics;

namespace WHAYN_Project
{
    /// <summary>
    /// Interaction logic for SellConfirmationPage.xaml
    /// </summary>
    public partial class SellConfirmationPage : Window
    {
        Sell sa;
        Browse br;
        public SellConfirmationPage(Sell sa1)
        {
            InitializeComponent();
            this.sa = sa1;
        }

        public SellConfirmationPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OPI1.Text = sa.FullName.Text;
            OPI2.Text = sa.BirthDate.Text;
            OPI3.Text = sa.Nationality.Text;
            OPI4.Text = sa.SexCmb.Text;
            OCD1.Text = sa.AddressTxt.Text;
            OCD2.Text = sa.EmailTxt.Text;
            OCD3.Text = sa.NumTxt.Text;
            LA1.Text = sa.Title.Text;
            LA2.Text = sa.Location.Text;
            LA3.Text = sa.TypeCmb.Text;
            LA4.Text = sa.Size.Text;
            LA5.Text = sa.Price.Text;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            AddToList();
            this.Close();

        }
        public ObservableCollection<Lots> addedlot { get; set; } = new();

        private void AddToList()
        {
            Browse br = new();
            var faker = new Faker();
            var vm = new ViewModel();

            for (int i = 0; i < 1; i++)
            {
                string title = sa.Title.Text;
                float price = float.Parse(sa.Price.Text);
                string image = faker.Image.PicsumUrl();
                LandType spacetype = Enum.Parse<LandType>(sa.TypeCmb.SelectedItem.ToString());
                string name = sa.FullName.Text;
                string loc = sa.Location.Text;
                float phonenum = float.Parse(sa.NumTxt.Text);
                string email = sa.EmailTxt.Text;
                float area = float.Parse(sa.Size.Text);

                Lots browsedetails = new Lots(title, image, price, spacetype, name, loc, phonenum, email, area);

                addedlot.Add(browsedetails);

                vm.Lot.Add(browsedetails);

       

            }

        }

        //public ObservableCollection<Applicant> addedlot { get; set; } = new();

        //private void AddToList()
        //{
        //    var faker = new Faker();

        //    string title = LA1.Text;
        //    float price = float.Parse(LA5.Text);
        //    string image = faker.Image.PicsumUrl();
        //    LandType spacetype = Enum.Parse<LandType>LA3.Text;
        //    string name = OPI1.Text;
        //    string loc = LA2.Text;
        //    float phonenum = float.Parse(OCD3.Text);
        //    string email = OCD2.Text;
        //    float area = float.Parse(LA4.Text);

        //    var browsedetails = new Lots(title, image, price, spacetype, name, loc, phonenum, email, area);

        //    addedlot.Add(browsedetails);




        //}
    }
}
