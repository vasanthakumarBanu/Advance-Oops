using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class EEEdepartment : Library
    {
        public override string Author { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override DateTime Year { get; set; }

        public EEEdepartment(string author, string bookName, string publisherName, DateTime year)
        {
            Author = author;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }

        public override void SetBookInfo()
        {
            
        }
        public override void DisplayInfo()
        {

        }

    }
}