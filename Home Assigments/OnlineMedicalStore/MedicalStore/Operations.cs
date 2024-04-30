using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MedicalStore
{
    public class Operations
    {
        public static UserDetails currentLoggedIn;
        public static List<UserDetails> userList = new List<UserDetails>();
        public static List<MedicineDetails> medicineList = new List<MedicineDetails>();
        public static List<OderDetails> oderList = new List<OderDetails>();

        public static void AddingData()
        {
            //userList
            UserDetails user1 = new UserDetails("Ravi", 33, "Theni", "9877774440", 400);
            UserDetails user2 = new UserDetails("Baskaran", 33, "Chennai", "88477574740", 500);
            userList.AddRange(new List<UserDetails> { user1, user2 });

            // System.Console.WriteLine("|Name|Age|City|PhoneNumber|Balance");
            // foreach (UserDetails user in userList)
            // {
            //     if (currentLoggedIn.UserID == user.UserID)
            //     {
            //         System.Console.WriteLine($"|{user.UserID}|{user.Name}|{user.Age}|{user.City}|{user.Phone}|{user.WalletBalance}");
            //     }

            // }

            //MedicineList
            MedicineDetails medicine1 = new MedicineDetails("Paracitomal", 40, 5, new DateTime(2024, 06, 30));
            MedicineDetails medicine2 = new MedicineDetails("Capol", 10, 5, new DateTime(2024, 05, 30));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil", 3, 40, new DateTime(2024, 04, 30));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel", 5, 50, new DateTime(2024, 12, 30));
            MedicineDetails medicine5 = new MedicineDetails("Povidin", 10, 50, new DateTime(2024, 10, 30));
            medicineList.AddRange(new List<MedicineDetails> { medicine1, medicine2, medicine3, medicine4, medicine5 });

            // System.Console.WriteLine("|Medicine Name|Avialable Quantity|Price|Date of Expiry");

            // foreach (MedicineDetails medicine in medicineList)
            // {
            //     // if (medicine.MedicineID == newMedicineID.MedicineID)
            //     // {
            //     System.Console.WriteLine($"|{medicine.MedicineID}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry}");
            //     // }

            // }

            //oderDetails
            OderDetails oder1 = new OderDetails(user1.UserID, medicine1.MedicineID, 3, 15, new DateTime(2022, 11, 13), OderStatus.Purchased);
            OderDetails oder2 = new OderDetails(user1.UserID, medicine2.MedicineID, 2, 10, new DateTime(2022, 11, 13), OderStatus.Cancelled);
            OderDetails oder3 = new OderDetails(user1.UserID, medicine4.MedicineID, 2, 100, new DateTime(2022, 11, 13), OderStatus.Purchased);
            OderDetails oder4 = new OderDetails(user2.UserID, medicine3.MedicineID, 3, 120, new DateTime(2022, 11, 15), OderStatus.Cancelled);
            OderDetails oder5 = new OderDetails(user2.UserID, medicine5.MedicineID, 5, 250, new DateTime(2022, 11, 15), OderStatus.Purchased);
            OderDetails oder6 = new OderDetails(user2.UserID, medicine2.MedicineID, 3, 15, new DateTime(2022, 11, 15), OderStatus.Purchased);
            oderList.AddRange(new List<OderDetails> { oder1, oder2, oder3, oder4, oder5, oder6 });

            // foreach (OderDetails oder in oderList)
            // {
            //     if (oder.UserID == currentLoggedIn.UserID)
            //     {
            //         System.Console.WriteLine($"|{oder.UserID}|{oder.MedicineID}|{oder.MedicineCount}|{oder.TotalPrice}|{oder.OderDate}|{oder.OderStatus}");
            //     }
            // }
        }

        public static void Mainmenu()
        {
            bool Mainflag = true;
            do
            {
                System.Console.WriteLine("Select the option\n1.Registartion\n2.Login\n3.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Login();
                            break;
                        }
                    case 3:
                        {
                            Mainflag = false;
                            break;
                        }
                }
            } while (Mainflag);
        }
        public static void Registration()
        {
            System.Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter the age");
            int age = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the city");
            string city = Console.ReadLine();
            System.Console.WriteLine("Enter the PhoneNumber");
            string phone = Console.ReadLine();
            System.Console.WriteLine("Enter your balance");
            double walletBalance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(name, age, city, phone, walletBalance);
            userList.Add(user);

            System.Console.WriteLine("Regsitration is successfull and your ID is" + user.UserID);

        }

        public static void Login()
        {
            bool loginflag = true;
            System.Console.WriteLine("Enter your Login ID");
            string newLoginID = Console.ReadLine().ToUpper();
            foreach (UserDetails user in userList)
            {
                if (newLoginID.Equals(user.UserID))
                {
                    currentLoggedIn = user;
                    SubMenu();
                    loginflag = false;
                }
            }
            if (loginflag)
            {
                System.Console.WriteLine("Invalid ID try again");
            }
        }
        public static void SubMenu()
        {
            bool subflag = true;
            do
            {
                System.Console.WriteLine("Select the option\n1.Show medicine list\n2.Purchase medicine\n3.Modify purchase\n4.Cancel purchase\n5.Show purchase history\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            // a.	Show medicine list.
                            ShowMedicineList();

                            break;
                        }
                    case 2:
                        {
                            // b.	Purchase medicine.
                            PurchaseMedicine();
                            break;
                        }
                    case 3:
                        {
                            // c.	Modify purchase.
                            ModifyPurchase();
                            break;
                        }
                    case 4:
                        {
                            // d.	Cancel purchase.
                            CancelPurchase();
                            break;
                        }
                    case 5:
                        {
                            // e.	Show purchase history.
                            PurchaseHistory();
                            break;
                        }
                    case 6:
                        {
                            // f.	Recharge Wallet.
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            // g.	Show Wallet Balance
                            WalletBalance();
                            break;
                        }
                    case 8:
                        {
                            // h.	Exit
                            subflag = false;
                            break;
                        }

                }
            } while (subflag);
        }
        public static void ShowMedicineList()
        {
            foreach (MedicineDetails medicine in medicineList)
            {

                System.Console.WriteLine($"|{medicine.MedicineID}|{medicine.MedicineName}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");

            }

        }
        public static void PurchaseHistory()
        {
            foreach (OderDetails oder in oderList)
            {
                if (oder.UserID == currentLoggedIn.UserID)
                {
                    System.Console.WriteLine($"|{oder.OderID}|{oder.UserID}|{oder.MedicineID}|{oder.MedicineCount}|{oder.TotalPrice}|{oder.OderDate.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                }
            }

        }
        public static void RechargeWallet()
        {
            System.Console.WriteLine("Enter the amount to recharge");
            double amount = double.Parse(Console.ReadLine());
            currentLoggedIn.WalletRecharge(amount);
        }

        public static void WalletBalance()
        {
            System.Console.WriteLine("Your balance is" + currentLoggedIn.WalletBalance);
        }

        public static void CancelPurchase()
        {
            foreach (OderDetails oder in oderList)
            {
                // Show the order details of the currently logged in user whose order status is “Purchased”.
                if (oder.UserID == currentLoggedIn.UserID && oder.OderStatus == OderStatus.Purchased)
                {
                    System.Console.WriteLine($"|{oder.OderID}|{oder.UserID}|{oder.MedicineID}|{oder.MedicineCount}|{oder.TotalPrice}|{oder.OderDate.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                }
            }
            // Get the Order ID information from the user
            System.Console.WriteLine("Enter your OderID");
            string newoderID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (OderDetails oder1 in oderList)
            { //check the Order ID present in the list 
                if (oder1.OderID.Equals(newoderID))
                {//check its Order Status is Purchased.
                    if (oder1.OderStatus.Equals(OderStatus.Purchased))
                    {
                        //increase the count of that Medicine in the medicine details
                        foreach (MedicineDetails medince in medicineList)
                        {
                            if (medince.MedicineID.Equals(oder1.MedicineID))
                            {
                                flag = false;
                                medince.AvailableCount += oder1.MedicineCount;
                                //  Return the amount to the user
                                double amount = oder1.TotalPrice;
                                currentLoggedIn.WalletRecharge(amount);
                                //  Change the Status of the order to “Cancelled”.
                                oder1.OderStatus = OderStatus.Cancelled;
                                // Show the user that the “Order ID XXX was cancelled successfully”.
                                System.Console.WriteLine($"Oder ID {oder1.OderID} is Cancelled");
                            }
                        }
                    }

                }

            }
            if (flag)
            {
                System.Console.WriteLine("Invalid ID or no Purchase oder");
            }
        }

        public static void ModifyPurchase()
        {
            bool flag = true;
            do
            {
                // Show the order details of current logged in user to pick a order detail by using Order ID and whose status is “Purchased”.
                foreach (OderDetails oder in oderList)
                {
                    if (currentLoggedIn.UserID.Equals(oder.UserID) && oder.OderStatus.Equals(OderStatus.Purchased))
                    {
                        flag = false;

                        System.Console.WriteLine($"|{oder.OderID}|{oder.UserID}|{oder.MedicineID}|{oder.MedicineCount}|{oder.TotalPrice}|{oder.OderDate.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                    }
                }
                //Ensure the order ID is available
                System.Console.WriteLine("Enter the oderID to Modify");
                string modifyoderID = Console.ReadLine().ToUpper();
                foreach (OderDetails oder1 in oderList)
                {
                    flag = false;
                    if (oder1.OderID.Equals(modifyoderID))
                    {//ask the user to enter the new quantity of the medicine
                        System.Console.WriteLine("Enter the new quantity of medicine");
                        int newcount = int.Parse(Console.ReadLine());
                        // Calculate the order price and update in the order price.
                        double eachprice = oder1.TotalPrice / oder1.MedicineCount;
                        oder1.MedicineCount += newcount;
                        // Calculate the total price of order and update in purchase details entry. 
                        oder1.TotalPrice += newcount * eachprice;
                        // Show order modified successfully.
                        System.Console.WriteLine("Oder Modifies succesfully");

                    }
                    if (flag)
                    {
                        System.Console.WriteLine("Invalid ID");
                    }
                }
            } while (flag);








        }
        public static void PurchaseMedicine()
        {
            System.Console.WriteLine("|Medicine Name|Avialable Quantity|Price|Date of Expiry");
            foreach (MedicineDetails medicine in medicineList)
            {
                System.Console.WriteLine($"|{medicine.MedicineID}|{medicine.AvailableCount}|{medicine.Price}|{medicine.DateOfExpiry.ToString("dd/MM/yyyy")}");
            }
            System.Console.WriteLine("Enter the MedicineID to purchase");
            string newID = (Console.ReadLine()).ToUpper();
            System.Console.WriteLine("Enter the count of medicine need to buy");
            int newcount = int.Parse(Console.ReadLine());
            bool flag = true;
            foreach(MedicineDetails newmedicine in medicineList)
            {
                flag = true;
                if(newmedicine.MedicineID.Equals(newID))
                {
                    if(newmedicine.AvailableCount>newcount)
                    {
                        if(newmedicine.DateOfExpiry > DateTime.Now)
                        {
                            
                            if(currentLoggedIn.WalletBalance > (newcount*newmedicine.Price))
                            { 
                                currentLoggedIn.DeductBalance(newcount*newmedicine.Price);
                                newmedicine.AvailableCount -= newcount;
                                OderDetails oder = new OderDetails(currentLoggedIn.UserID,newmedicine.MedicineID,newcount,newcount*newmedicine.Price,DateTime.Now,OderStatus.Purchased);
                                oderList.Add(oder);
                                flag = false;

                            }
                            else
                            {
                                
                            }

                        }
                        else
                        {

                        }
                    }
                    else
                    {

                    }

                }
            }
            if(flag == true)
            {
                System.Console.WriteLine("Medicine Not Avialable");
            }

        }
    }
}