using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalStore
{ public enum OderStatus {Select,Purchased,Cancelled}
    public class OderDetails
    {
        private static int s_oderID = 2000;
        public string OderID { get; set; }
         public string UserID { get; set; }
        public string MedicineID { get;set; }
        public int MedicineCount { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OderDate {get;set;}
        public OderStatus OderStatus {get;set;}

        public OderDetails(string userID,string medicineID,int medicineCount,double totalPrice,DateTime oderDate,OderStatus oderStatus)
        {  
            ++s_oderID;         
             OderID = "OID"+s_oderID;
            UserID = userID;
            MedicineID = medicineID;
            MedicineCount = medicineCount;
            TotalPrice = totalPrice;
            OderDate = oderDate;
            OderStatus = oderStatus;
        }
    }
}