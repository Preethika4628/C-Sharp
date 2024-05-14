using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationDrive
{
    public class VaccinationDetails
    {
        private static int s_vaccinationID = 3000;
        public string VaccinationID {get;}
        public string RegistrationID {get; set;}
        public string VaccineID {get; set;}
        public int DoseNumber {get; set;}
        public DateTime VaccinatedDate {get; set;}
        public VaccinationDetails(string registrationID, string vaccineID, int doseNumber, DateTime vaccinatedDate)
        {
            s_vaccinationID++;
            VaccinationID = "VID" + s_vaccinationID;
            RegistrationID = registrationID;
            VaccineID = vaccineID;
            DoseNumber = doseNumber;
            VaccinatedDate = vaccinatedDate;
        }
    }
}