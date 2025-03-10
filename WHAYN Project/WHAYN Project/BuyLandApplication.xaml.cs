using Bogus;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Interaction logic for BuyLandApplication.xaml
    /// </summary>
    public partial class BuyLandApplication : Window
    {
        public BuyLandApplication()
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

        private void GenerateTrackNumber()
        {
            var faker = new Faker();
            string tracknumwe = faker.Finance.CreditCardNumber();

            TrackNum.Text = tracknumwe;

            TrackNum.Visibility = Visibility.Collapsed;
        }

        public ObservableCollection<Applicant> applicants { get; set; } = new();
        NewLot Property = (NewLot)Application.Current.Resources["AddedLot"];

        private void SaveInfo()
        {

            var faker = new Faker();

            for (int i = 0; i < 1; i++)
            {
                string name = FullName.Text;
                DateTime bday = DateTime.ParseExact(BirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string nationality = Nationality.Text;
                Sex sex = Enum.Parse<Sex>(SexCmb.SelectedItem.ToString());
                string address = AddressTxt.Text;
                string email = EmailTxt.Text;
                float num = float.Parse(NumTxt.Text);
                string tracknum = faker.Finance.CreditCardNumber();

                Applicant applicant = new(name, bday, nationality, sex, address, email, num, tracknum);

                applicants.Add(applicant);

                Property.NewLotProperty.Add(applicant);
            }

            

        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            SaveInfo();
            this.Close();
            ConfirmationPage cp = new(this);
            cp.Owner = Application.Current.MainWindow;
            cp.ShowDialog();
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadSex();
            GenerateTrackNumber();
        }
    }
}
