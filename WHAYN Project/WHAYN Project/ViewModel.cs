using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Bogus;
using static WHAYN_Project.Lots;

namespace WHAYN_Project
{
    public class ViewModel
    {
        public ViewModel()
        {
            LoadAreas();
        }

        public ObservableCollection<Lots> Lot { get; set; } = new();

        //public ObservableCollection<Lots> AddLot
        //{
        //    set
        //    {
        //        foreach (var lot in value)
        //        {
        //            Lot.Add(lot);
        //        }
        //    }
        //}

        //public ICommand AddLotCommand => new ButtonCommand(AddLot);
        //private List<Lots> _storage = new();
        //private string _searchText;

        //public string SearchText { get => _searchText; set { _searchText = value; SearchLot(); } }

        //private NewLotProperty _newLot;
        //private SellConfirmationPage _cp;
        //public void AddLot()
        //{

        //    Sell sp = new();

        //    _newLot = new NewLotProperty(SaveLot);
        //    sp.DataContext = _newLot;

        //}

        //public void SaveLot()
        //{
        //    _storage.Add(_newLot.NewLot);
        //    _cp.Close();
        //    SearchLot();
        //}

        //private void SearchLot()
        //{
        //    Lot.Clear();

        //    string input = SearchText.Trim().ToLower();
        //    var output = _storage.Where(c => c.Name.ToLower().Contains(input) ||
        //                            c.SpaceType.ToString().Contains(input))

        //        .OrderBy(c => c.Name).ToList();

        //    foreach (var item in output)
        //    {
        //        Lot.Add(item);
        //    }

        //}
        public Lots SelectedLot { get; set; }

        private void LoadAreas()
        {
            var faker = new Faker();
            faker.Random = new Randomizer(9283);

            for (int i = 0; i < 50; i++)
            {
                string title = faker.Address.StreetAddress();
                float price = faker.Random.Float(100_000, 50_000_000);
                string image = faker.Image.PicsumUrl();
                LandType spacetype = faker.PickRandom<LandType>();
                string name = faker.Name.FullName();
                string loc = faker.Address.FullAddress();
                float phonenum = faker.Random.Number(0, 999999999);
                string email = faker.Internet.Email(name);
                float area = faker.Random.Number(1_000, 20_000);

                var browsedetails = new Lots(title, image, price, spacetype, name, loc, phonenum, email, area);

                Lot.Add(browsedetails);
            }

            //foreach (var i in _list)
            //{
            //    ListViewProducts.Items.Add(i);
            //}

        }

       
    }
}
