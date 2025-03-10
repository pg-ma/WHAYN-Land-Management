using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WHAYN_Project
{
    public class Applicant
    {
        public string ApplicantFullName { get; set; }
        public DateTime ApplicantBirtDate { get; set; }
        public string ApplicantNationality { get; set; }
        public Sex ApplicantSex { get; set; }
        public string ApplicantAddress { get; set; }
        public string ApplicantEmail { get; set; }
        public float ApplicantNumber { get; set; }
        public string ApplicantTrackerNum { get; set; }

        public Applicant(string applicantFullName, DateTime applicantBirtDate, string applicantNationality, Sex applicantSex, string applicantAddress, string applicantEmail, float applicantNumber, string applicanttracknum)
        {
            ApplicantFullName = applicantFullName;
            ApplicantBirtDate = applicantBirtDate;
            ApplicantNationality = applicantNationality;
            ApplicantSex = applicantSex;
            ApplicantAddress = applicantAddress;
            ApplicantEmail = applicantEmail;
            ApplicantNumber = applicantNumber;
            ApplicantTrackerNum= applicanttracknum;
        }

        public Applicant(string tracknum)
        {
            ApplicantTrackerNum= tracknum;
        }


    }

    public class NewLot
    {
        public ObservableCollection<Applicant> NewLotProperty { get; set; } = new ObservableCollection<Applicant>();

    }

    public enum Sex
    {
        Female,
        Male
    }
}
