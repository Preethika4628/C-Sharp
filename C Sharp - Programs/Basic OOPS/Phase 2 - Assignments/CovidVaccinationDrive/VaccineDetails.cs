using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationDrive
{
    public enum VaccineType
    {
        Covishield, Covaccine
    }
    public class VaccineDetails
    {
        private static int s_vaccineID = 2000;
        public string VaccineID { get; }
        public VaccineType VaccineName { get; set; }
        public int NoOfDoseAvaiable {get; set;}

        public VaccineDetails(VaccineType vaccineName, int noOfDoseAvaiable)
        {
            s_vaccineID++;
            VaccineID = "CID" + s_vaccineID;
            VaccineName = vaccineName;
            NoOfDoseAvaiable = noOfDoseAvaiable;
        }
        public VaccineDetails()
        {
            VaccineName = VaccineType.Covishield;
        }

    }
}