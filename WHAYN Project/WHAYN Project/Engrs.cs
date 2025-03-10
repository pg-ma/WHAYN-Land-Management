using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAYN_Project
{
    public class Engrs
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public Cat Engr { get; set; }

        public Engrs(string fullName, string address, int phoneNum, Cat engr)
        {
            FullName = fullName;
            Address = address;
            PhoneNumber = phoneNum;
            Engr = engr;
        }
    }

    public enum Cat
    {
        Electrical_Engineer,
        Civil_Engineer,
        Geodetic_Engineer,
        Structural_Engineer,
    }
}
