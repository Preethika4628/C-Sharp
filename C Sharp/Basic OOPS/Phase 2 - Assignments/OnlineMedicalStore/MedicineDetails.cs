using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class MedicineDetails
    {
        public static int s_medicineID = 2000;
        public string MedicineID { get; set; }
        public string MedicineName { get; set; }
        public int AvaiableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName, int avaiableCount, double price, DateTime dateOfExpiry)
        {
            s_medicineID++;
            MedicineID = "MID" + s_medicineID;
            MedicineName = medicineName;
            AvaiableCount = avaiableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }
    }
}