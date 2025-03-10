using Bogus;
using System;
using System.Collections;
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
    /// Interaction logic for LstEngr.xaml
    /// </summary>
    public partial class LstEngr : UserControl
    {
        public LstEngr()
        {
            InitializeComponent();
        }

        private List<Engrs> _engr = new List<Engrs>();


        private void LoadList()
        {
            var faker = new Faker();
            faker.Random = new Randomizer(928);

            for (int i = 0; i < 50; i++)
            {
                string fullname = faker.Name.FullName();
                string address = faker.Address.FullAddress();
                int phonenum = faker.Random.Number(0,999999999);
                Cat cat = faker.PickRandom<Cat>();

                var engrinfo = new Engrs(fullname, address, phonenum, cat);

                _engr.Add(engrinfo);
            }

            foreach (var i in _engr)
            {
                LstEngrs.Items.Add(i);
            }

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            LoadList();
        }

        private void GE_Click(object sender, RoutedEventArgs e)
        {
            var sortedlist = _engr
                .Where(c => c.Engr == Cat.Geodetic_Engineer)
                .OrderBy(c => c.FullName)
                .ToList();

            LstEngrs.Items.Clear();

            foreach (var i in sortedlist)
            {
                LstEngrs.Items.Add(i);
            }
        }

        private void SE_Click(object sender, RoutedEventArgs e)
        {
            var sortedlist = _engr
                .Where(c => c.Engr == Cat.Structural_Engineer)
                .OrderBy(c => c.FullName)
                .ToList();

            LstEngrs.Items.Clear();

            foreach (var i in sortedlist)
            {
                LstEngrs.Items.Add(i);
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            var sortedlist = _engr
                .Where(c => c.Engr == Cat.Civil_Engineer)
                .OrderBy(c => c.FullName)
                .ToList();

            LstEngrs.Items.Clear();

            foreach (var i in sortedlist)
            {
                LstEngrs.Items.Add(i);
            }
        }

        private void EE_Click(object sender, RoutedEventArgs e)
        {
            var sortedlist = _engr
                .Where(c => c.Engr == Cat.Electrical_Engineer)
                .OrderBy(c => c.FullName)
                .ToList();

            LstEngrs.Items.Clear();

            foreach (var i in sortedlist)
            {
                LstEngrs.Items.Add(i);
            }
        }

        private void AllList_Click(object sender, RoutedEventArgs e)
        {
            var sortedlist = _engr
                .OrderBy(c => c.FullName)
                .ToList();

            LstEngrs.Items.Clear();

            foreach (var i in sortedlist)
            {
                LstEngrs.Items.Add(i);
            }
        }
    }
}
