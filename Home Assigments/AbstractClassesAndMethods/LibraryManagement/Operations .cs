using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Operations 
    {
        List<EEEdepartment> eeeLibrary = new List<EEEdepartment>();

        public void SetBookInfo()
        {
            
            System.Console.WriteLine("Welcome to EEE Department Library");
            System.Console.WriteLine("Enter Author Name");
            string author = Console.ReadLine();
            System.Console.WriteLine("Enter BookName Name");
            string bookName = Console.ReadLine();
            System.Console.WriteLine("Enter PublisherName Name");
            string publisherName = Console.ReadLine();
            System.Console.WriteLine("Enter the Year Format:(yyyy)");
            DateTime year = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);

            EEEdepartment book = new EEEdepartment(author, bookName, publisherName, year);
            eeeLibrary.Add(book);
            System.Console.WriteLine("Book Details Saved Successfully, BookID is" + Library.SerialNumber);


        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Welcome to DisplayInfo");
            System.Console.WriteLine("Enter the SerialNumber of the book");
            string newserialnumber = Console.ReadLine();
            if (newserialnumber == Library.SerialNumber)
            {
                foreach (EEEdepartment book in eeeLibrary)
                {
                    System.Console.WriteLine(book.eeeLibrary);
                }
            }
        }

        public void SetBookInfo()
        {
            System.Console.WriteLine("Welcome to CSE Department Library");
            System.Console.WriteLine("Enter Author Name");
            string author = Console.ReadLine();
            System.Console.WriteLine("Enter BookName Name");
            string bookName = Console.ReadLine();
            System.Console.WriteLine("Enter PublisherName Name");
            string publisherName = Console.ReadLine();
            System.Console.WriteLine("Enter the Year Format:(yyyy)");
            DateTime year = DateTime.ParseExact(Console.ReadLine(), "yyyy", null);

            CSEdepartment book = new CSEdepartment(author, bookName, publisherName, Year);
            cseLibrary.Add(book);
            System.Console.WriteLine("Book Details Saved Successfully, BookID is" + SerialNumber);


        }

        public void DisplayInfo()
        {
            System.Console.WriteLine("Welcome to DisplayInfo");
            System.Console.WriteLine("Enter the SerialNumber of the book");
            string newserialnumber = Console.ReadLine();
            if (newserialnumber == Library.SerialNumber)
            {
                foreach (CSEdepartment book in cseLibrary)
                {
                    System.Console.WriteLine(book.cseLibrary);
                }
            }



        }

    }
}