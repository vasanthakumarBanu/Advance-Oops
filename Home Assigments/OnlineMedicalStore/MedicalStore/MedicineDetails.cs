using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{
    public class MedicineDetails
    {
//         a.	Medicine ID (MD100)
// b.	Medicine Name
// c.	Available Count
// d.	Price
// e.	Date Of Expiry
        private static int s_medicineID = 100;
        public string MedicineID { get; set; }

        public string MedicineName { get; set; }
        public int AvailableCount { get; set; }
        public double Price { get; set; }
        public DateTime DateOfExpiry { get; set; }

        public MedicineDetails(string medicineName,int availableCount,double price,DateTime dateOfExpiry)
        {
            ++s_medicineID;
            MedicineID = "ID"+s_medicineID;
            MedicineName = medicineName;
            AvailableCount = availableCount;
            Price = price;
            DateOfExpiry = dateOfExpiry;
        }

    }
}