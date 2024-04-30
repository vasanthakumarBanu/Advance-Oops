using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public enum BookingStatus {Select,Initiated,Booked,Cancelled}
    public class BookingDetails
    {
        private static int s_bookingID=3000;

        public string BookingID { get; set; }
        public string CustomerID {get;set;}
        public int TotalPrice { get; set; }
        public DateTime DateOfBooking {get;set;}
        public BookingStatus BookingStatus {get;set;}

        public BookingDetails(string customerID,int totalPrice,DateTime dateOfBooking,BookingStatus bookingStatus)
        {
            ++s_bookingID;
            BookingID = "BID"+ s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateOfBooking;
            BookingStatus = bookingStatus;
        }
        
        public static void ShowBookingDetails()
        {
            System.Console.WriteLine("|CustomerID|Total Price|Date of Booking|BookingStatus");
            foreach(BookingDetails booking1 in Operations.bookingList)
            {
                if(Operations.currentLoggedIn.CustomerID.Equals(booking1.CustomerID))
                {
                    System.Console.WriteLine($"|{Operations.currentLoggedIn.CustomerID}|{booking1.TotalPrice}|{booking1.DateOfBooking}|{booking1.BookingStatus}");
                }
            }
            
        }
    }
}