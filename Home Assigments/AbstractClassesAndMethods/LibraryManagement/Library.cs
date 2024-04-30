using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public abstract class Library
    {
        //Field
        private static int s_serialNumber = 1000;
        //Property
        public static string SerialNumber {get;set;}
        public abstract string Author {get;set;}
        public abstract string BookName {get;set;}
        public abstract string PublisherName {get;set;}
        public abstract DateTime Year {get;set;}
        //Abstract Methods
        public abstract void SetBookInfo();
        public abstract void DisplayInfo();   
          
        
    }
}