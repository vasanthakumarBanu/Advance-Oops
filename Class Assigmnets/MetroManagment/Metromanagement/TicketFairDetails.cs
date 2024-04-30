using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Metromanagement
{
    public class TicketFairDetails
    {
        //Field
        private static int s_ticketID = 3000;
        public string TicketID { get; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }
        ////Parametrized constructor
        public TicketFairDetails(string fromLocation,string toLocation,double ticketPrice)
        {
            ++s_ticketID;
            TicketID = "MR"+s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;

        }
        public TicketFairDetails(string ticket)
         {
            string [] values = ticket.Split(",");
            TicketID = values[0];
            s_ticketID = int.Parse(values[0].Remove(0,2));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice =double.Parse(values[3]);

        }
    }
}