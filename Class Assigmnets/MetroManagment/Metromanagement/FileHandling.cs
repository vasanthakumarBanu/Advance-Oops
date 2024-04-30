using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Metromanagement
{
    public class FileHandling
    {
        public static void Create()
        {
    
        if(!Directory.Exists(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\FileHandling"))
        {
            System.Console.WriteLine("Creating folder ...");
            Directory.CreateDirectory(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\FileHandling");
        }
        else
        {
            System.Console.WriteLine("Directory exists");
        }
        if(!File.Exists(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\users.CSV"))
        {
            System.Console.WriteLine("Creating CSV file....");
            File.Create(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\users.CSV").Close();
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }  
        if(!File.Exists(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\travel.CSV"))
        {
            System.Console.WriteLine("Creating CSV file....");
            File.Create(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\travel.CSV").Close();
        }
        else
        {
            System.Console.WriteLine("File already exists");
        } 
        if(!File.Exists(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\ticket.CSV"))
        {
            System.Console.WriteLine("Creating CSV file....");
            File.Create(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\ticket.CSV").Close();
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }   
        }         
       
        public static void WriteToCVS()
        {
            string [] users = new string [Operations.userList.Count];
            for(int i = 0;i<Operations.userList.Count;i++)
            {
                users[i]=Operations.userList[i].CardNumber+","+Operations.userList[i].Name+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;

            }
            File.WriteAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\users.CSV",users);

             string [] travel = new string [Operations.travelList.Count];
            for(int i = 0;i<Operations.travelList.Count;i++)
            {
                travel[i]=Operations.travelList[i].TravelID+","+Operations.travelList[i].CardNumber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date+","+Operations.travelList[i].Travelcost;

            }
            File.WriteAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\travel.CSV",travel);

            string [] ticket = new string [Operations.ticketList.Count];
            for(int i = 0;i<Operations.ticketList.Count;i++)
            {
                ticket[i]=Operations.ticketList[i].TicketID+","+Operations.ticketList[i].FromLocation+","+Operations.ticketList[i].ToLocation+","+Operations.ticketList[i].TicketPrice;

            }
            File.WriteAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\ticket.CSV",ticket);
       
        }

        public static void ReadFromCSV()
        {
            string [] users = File.ReadAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\users.CSV");
            {
                foreach(string user in users)
                {
                    UserDetails user1 = new UserDetails(user);
                    Operations.userList.Add(user1);
                }
                
            }
            string [] travel = File.ReadAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\travel.CSV");
            {
                foreach(string travels in travel)
                {
                    TravelDetails travel1 = new TravelDetails(travels);
                    Operations.travelList.Add(travel1);
                }
                
            }

            string [] ticket = File.ReadAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\MetroManagment\Metromanagement\ticket.CSV");
            {
                foreach(string tickets in ticket)
                {
                    TicketFairDetails ticket1 = new TicketFairDetails(tickets);
                    Operations.ticketList.Add(ticket1);
                }
                
            }

        }


        




    }
}