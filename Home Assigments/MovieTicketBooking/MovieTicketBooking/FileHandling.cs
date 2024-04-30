using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
namespace MovieTicketBooking
{
    public class FileHandling
    {
        public static void Create()
        {
            if (!Directory.Exists("FileHandling"))
            {
                System.Console.WriteLine("Creating Directory...");
                Directory.CreateDirectory("FileHandling");
            }
            else
            {
                System.Console.WriteLine("Directory already Exists");
            }


            if (!File.Exists(@"FileHandling\userDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create(@"FileHandling\userDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("File already Exists");
            }
            if (!File.Exists(@"FileHandling\BookingDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create(@"FileHandling\BookingDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("File already Exists");
            }
            if (!File.Exists(@"FileHandling\MovieDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create(@"FileHandling\MovieDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("File already Exists");
            }
            if (!File.Exists(@"FileHandling\ScreenDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create(@"FileHandling\ScreenDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("File already Exists");
            }
            if (!File.Exists(@"FileHandling\TheaterDetails.csv"))
            {
                System.Console.WriteLine("Creating File");
                File.Create(@"FileHandling\TheaterDetails.csv").Close();
            }
            else
            {
                System.Console.WriteLine("File already Exists");
            }

        }

        public static void WriteToCsv()
        {
            string[] users = new string[Program.userDetailsList.Count];
            for (int i = 0; i < Program.userDetailsList.Count; ++i)
            {
                users[i] = Program.userDetailsList[i].Name + "," + Program.userDetailsList[i].Age + "," + Program.userDetailsList[i].PhoneNumber + "," + Program.userDetailsList[i].WalletBalance;
            }
            File.WriteAllLines(@"FileHandling\userDetails.csv", users);


             string[] movies = new string[Program.movieDetailsList.Count];
            for (int i = 0; i < Program.movieDetailsList.Count; ++i)
            {
                movies[i] = Program.movieDetailsList[i].MovieID+","+Program.movieDetailsList[i].MovieName+","+Program.movieDetailsList[i].Language;
            }
            File.WriteAllLines(@"FileHandling\userDetails.csv", movies);
            string[] theater = new string[Program.movieDetailsList.Count];
            // for (int i = 0; i < Program.theatreDetailsList.Count; ++i)
            // {
            //     theater[i] = Program.theatreDetailsList[i].+","+
            // }
            // File.WriteAllLines(@"FileHandling\userDetails.csv", movieticket);

            // for (int i = 0; i < Program..Count; ++i)
            // {
            //     movieticket[i] = Program.movieDetailsList[i].MovieID+","+Program.movieDetailsList[i].MovieName+","+Program.movieDetailsList[i].Language;
            // }
            // File.WriteAllLines(@"FileHandling\userDetails.csv", movieticket);

        }

    }
}