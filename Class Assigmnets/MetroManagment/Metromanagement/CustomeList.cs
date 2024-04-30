using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metromanagement
{
      public class CustomeList
      {
        // public static void Travel()
        // {
        //     System.Console.WriteLine(line);

        //     System.Console.WriteLine("|TicketID|From Location|To Location|Fair");
        //     foreach (TicketFairDetails ticket in ticketList)
        //     {
        //         System.Console.WriteLine($"|{ticket.TicketID}|{ticket.FromLocation}|{ticket.ToLocation}|{ticket.TicketPrice}");
        //     }

        //     System.Console.WriteLine("please enter the TicketID");
        //     string ans = "yes";
        //     do
        //     {
        //         string newticketID = Console.ReadLine().ToUpper();
        //         foreach (TicketFairDetails ticket in ticketList)
        //         {
        //             if (ticket.TicketID.Equals(newticketID))
        //             {
        //                  TravelDetails history = new TravelDetails(currentLoggedIn.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Now,ticket.TicketPrice);
        //                  travelList.Add(history);                
        //                 ans = "yes";
        //                 break;
                        
        //             }
        //             else
        //             {
                        
        //                 ans = "no";
        //                 System.Console.WriteLine("Please Enter the validID");
        //             }
        //         }
                 
        //     } while (ans == "no");
        //     if (ans == "yes")
        //     {
                
        //         bool flag1 = false;
               
        //         foreach (TicketFairDetails price in ticketList)
        //         {
        //             if (price.TicketPrice <= currentLoggedIn.WalletBalance)

        //             {
        //                 flag1 = true;
        //             }
        //             else
        //             {
        //                 System.Console.WriteLine("You Dont have sufficient Balance to travel,Please recahrge");
        //             }
        //             if (flag1)
        //             {
        //                 double amount = price.TicketPrice;
        //                 currentLoggedIn.deductbalance(amount);
        //                 flag1 = false;
        //                 foreach (TicketFairDetails ticket1 in ticketList)
        //                 {flag1 =false;
        //                 if(price.TicketID.Equals(ticket1.TicketID))
        //                 {
        //                    flag1 = true;
        //                 }
        //                 }
        //                 if (flag1)
        //                 {
        //                     System.Console.WriteLine(line);
        //                     System.Console.WriteLine(line);
        //                     System.Console.WriteLine("Your ticket is booked");
        //                     System.Console.WriteLine(line);
                            
        //                 }

        //             }
        //         }
                
                          
                                
                                
                            
        //         System.Console.WriteLine(line);
        //     }



        // }
        // //travel methods ends
    }
}