using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Metromanagement
{
    public class TravelDetails
    {   //Field
        private static int s_travelID = 2000;

        public string TravelID { get; }
        public string CardNumber { get; set; }

        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double Travelcost { get; set; }

        ////Parametrized constructor
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelcost)
        {
            ++s_travelID;
            TravelID = "TID" + s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            Travelcost = travelcost;
        }
        public TravelDetails(string travel)
        {
            string []values =travel.Split(",");
            TravelID = values[0];
            s_travelID = int.Parse(values[0].Remove(0,3));
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.ParseExact(values[4],"dd/MM,yyyy",null);
            Travelcost =double.Parse(values[5]);
        }
    }
}