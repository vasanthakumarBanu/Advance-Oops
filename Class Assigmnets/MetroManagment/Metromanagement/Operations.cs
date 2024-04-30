using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Metromanagement
{

    public static class Operations

    {
        public static string line = "-----------------------------------------------------------------";

        public static UserDetails currentLoggedIn;
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<TravelDetails> travelList = new List<TravelDetails>();
        public static List<TicketFairDetails> ticketList = new List<TicketFairDetails>();

        public static void MainMenu()
        {
            System.Console.WriteLine(line);

            string main = "yes";
            do
            {

                System.Console.WriteLine("select the option\n1.New user Registration\n2.Login User\n3.Exit");
                System.Console.WriteLine(line);
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            // Registration
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            // login
                            Login();
                            break;
                        }
                    case 3:
                        {
                            //exit
                            main = "no";
                            break;
                        }
                }
            } while (main == "yes");
            System.Console.WriteLine(line);
        }
        //Adding default datas
        public static void AddingData()
        {
            //User list
            UserDetails user1 = new UserDetails("Ravi", "9848812345", 1000);
            UserDetails user2 = new UserDetails("Baskaran", "9848812345", 1000);
            userList.AddRange(new List<UserDetails> { user1, user2 });
            // travel history
            TravelDetails travel1 = new TravelDetails("CMRL1001", "Airport", "Egmore", new DateTime(2023, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL1001", "Egmore", "Koyembedu", new DateTime(2023, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL1002", "Alandur", "Koyembedu", new DateTime(2023, 10, 11), 25);
            TravelDetails travel4 = new TravelDetails("CMRL1002", "Egmore", "Thirumangalam", new DateTime(2023, 10, 11), 25);
            travelList.AddRange(new List<TravelDetails> { travel1, travel2, travel3, travel4 });
            //Ticke fair list
            TicketFairDetails ticket1 = new TicketFairDetails("Aiport", "Egmore", 55);
            TicketFairDetails ticket2 = new TicketFairDetails("Aiport", "Koyembedu", 25);
            TicketFairDetails ticket3 = new TicketFairDetails("Alandur", "Koyembedu", 25);
            TicketFairDetails ticket4 = new TicketFairDetails("Koyembedu", "Egmore", 32);
            TicketFairDetails ticket5 = new TicketFairDetails("Vadapalani", "Egmore", 45);
            TicketFairDetails ticket6 = new TicketFairDetails("Arumbakkam", "Egmore", 25);
            TicketFairDetails ticket7 = new TicketFairDetails("Vadapalani", "Koyembedu", 25);
            TicketFairDetails ticket8 = new TicketFairDetails("Arumbakkam", "Koyembedu", 16);
            ticketList.AddRange(new List<TicketFairDetails> { ticket1, ticket2, ticket3, ticket4, ticket5, ticket6, ticket7, ticket8 });
        }
        //Registration methods starts
        public static void Registration()

        {
            System.Console.WriteLine(line);
            //Select option
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            //name
            //phone number
            System.Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine();
            //balance
            System.Console.WriteLine("Enter the amount recharge your wallet");
            double amount = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, phoneNumber, amount);
            userList.Add(user);
            System.Console.WriteLine("Registered Succesfully your CardNumber is" + user.CardNumber);
            System.Console.WriteLine(line);
        }
        //Registration methods starts

        //Login methods starts
        public static void Login()
        {
            System.Console.WriteLine(line);
            bool flag = true;
            //Login id get
            do
            {
                System.Console.WriteLine("Enter your Login ID(EX:CMRL1001)");
                string newCard = Console.ReadLine().ToUpper();
                foreach (UserDetails user in userList)
                {  //check login id
                    if (newCard == user.CardNumber)
                    {
                        currentLoggedIn = user;
                        //submenu
                        SubMenu();
                        flag = false;
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Please enter a valid ID");
                }
            } while (flag);
            System.Console.WriteLine(line);
        }
        //Login methods ends

        //Submenu methods starts
        public static void SubMenu()
        {//select option
            System.Console.WriteLine(line);
            bool flag = true;
            do
            {

                System.Console.WriteLine("Select the option\n1.Balance Check\n2.Recharge\n3.View Travel History\n4.Travel\n5.Exit");
                //select option
                int option = int.Parse(Console.ReadLine());
                flag = true;
                switch (option)
                {
                    case 1:
                        {
                            WalletBalance();
                            break;
                        }
                    case 2:
                        {//recharge
                            System.Console.WriteLine("Enter the amount to recharge:");
                            double amount = double.Parse(Console.ReadLine());
                            currentLoggedIn.WalletRecharge(amount);
                            System.Console.WriteLine("Your wallet is recharged");
                            break;
                        }
                    case 3:
                        {//view tavel history
                            TravelHistory();
                            break;
                        }
                    case 4:
                        { //travel
                            Travel();
                            break;
                        }
                    case 5:
                        {//exit
                            flag = false;
                            break;
                        }
                }

            } while (flag);
            System.Console.WriteLine(line);
        }
        //Submenu methods ends
        //Travel History methods starts
        public static void TravelHistory()
        {
            System.Console.WriteLine(line);
            System.Console.WriteLine("|TravelID|Card Number|From Location|To Location|Fair|");
            foreach (TravelDetails travel in travelList)
            {

                //checking travel card number
                if (currentLoggedIn.CardNumber.Equals(travel.CardNumber))
                {
                    System.Console.WriteLine($"|{travel.TravelID}|{travel.CardNumber}|{travel.FromLocation}|{travel.ToLocation}|{travel.Travelcost}|");
                }
            }
            System.Console.WriteLine(line);
        }
        //Travel History methods ends      

        //travel methods starts
        public static void Travel()
        {
            //show the ticket details
            System.Console.WriteLine("|TicketID|From Location|To Location|Fair");
            foreach (TicketFairDetails ticket in ticketList)
            {
                System.Console.WriteLine($"|{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}");
            }
            System.Console.WriteLine("Enter the ticket ID");
            string newticketID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (TicketFairDetails ticket in ticketList)
            {
                //check the ticket is valid or not
                if (newticketID.Equals(ticket.TicketID))
                {
                    flag = false;
                    //if ticket is valid then check the balance to travel.
                    if (ticket.TicketPrice < currentLoggedIn.WalletBalance)
                    {
                        //deduct the amount of ticket
                        currentLoggedIn.deductbalance(ticket.TicketPrice);
                        //add the details of travel history
                        TravelDetails travel = new TravelDetails(currentLoggedIn.CardNumber, ticket.FromLocation, ticket.ToLocation, DateTime.Now, ticket.TicketPrice);
                        travelList.Add(travel);
                        System.Console.WriteLine($"Ticket Booked Happy journey {ticket.FromLocation} to{ticket.ToLocation} in {DateTime.Now}");
                    }
                    else
                    {
                        //no means go to existing
                        System.Console.WriteLine(" insufficent balance please recharge");
                    }
                }
            }
            if (flag)
            {
                 System.Console.WriteLine("Invalid ID Please renter again");
            }
        }


            //wallet Balance methods starts
            public static void WalletBalance()
            {
                foreach (UserDetails user in userList)
                {
                    if (currentLoggedIn.CardNumber.Equals(user.CardNumber))
                    {
                        System.Console.WriteLine(user.WalletBalance);
                    }
                }

            }
            //wallet Balance methods ends
    }
}
