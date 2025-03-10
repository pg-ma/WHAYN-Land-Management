using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAYN_Project
{
    public class Lots
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public LandType SpaceType { get; set; }
        public string OwnerFullName { get; set; }
        public string LotLocation { get; set; }
        public float OwnerContactNum { get; set; }
        public string OwnerEmail { get; set; }
        public float LandSize { get; set; }


        public Lots(string name, string image, float price, LandType spacetype, string ownerfullname, string lotlocation, float ownernum, string owneremail, float landsize)
        {
            Name = name;
            Image = image;
            Price = price;
            SpaceType = spacetype;
            OwnerFullName = ownerfullname;
            LotLocation = lotlocation;
            OwnerContactNum = ownernum;
            OwnerEmail = owneremail;
            LandSize = landsize;
        }

        public Lots() { }

        
    }

   
    public enum LandType
        {
            Industrial,
            Commercial,
            Land,
            Residential

        }


}
