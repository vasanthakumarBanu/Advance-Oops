using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class CSEdepartment : Library
    {
        List<CSEdepartment> cseLibrary = new List<CSEdepartment>();
        public override string Author { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override DateTime Year { get; set; }
        public CSEdepartment(string author, string bookName, string publisherName, DateTime year)
        {
            Author = author;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }

        //Abstract Methods
        public override void SetBookInfo()
        {
            
        }
        public override void DisplayInfo()
        {

        }
    }
}