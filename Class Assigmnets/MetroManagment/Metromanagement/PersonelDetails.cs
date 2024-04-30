using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metromanagement
{
    public class PersonelDetails
    {
        public string Name {get;set;}
        public string PhoneNumber { get; set; }


        public PersonelDetails(string name,string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
         public PersonelDetails()
        {
            
        }

    }
}