using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CafeteriaManagment
{
    public static partial class Operations
    {
        static UserDetails currentLoggedIn;

        public static void SubMenu()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("--------Welcome to SyncFusion SubMenu Page---------");
            System.Console.WriteLine("Plsease Select an Option\n1.Show My Profile\n2.Food Oder\n3.Modify Oder\n4.CanncelOder\n5.OderHistory\n6.WalletRecharge\n7.Show Wallet Balance\n8.Exit.");
            int option = int.Parse(Console.ReadLine());
            bool flag = true;
            do
            {
                switch (option)
                {
                    case 1:
                        {
                            ShowMyProfile();
                            flag = false;
                            break;
                        }
                    case 2:
                        {
                            //FoodOder();
                            break;
                        }
                    case 3:
                        {
                            // ModifyOder();
                            break;
                        }
                    case 4:
                        {
                            // CancelOder;
                            break;
                        }
                    case 5:
                        {
                            OderHistory();
                            flag = false;
                            break;
                        }
                    case 6:
                        {
                            Recharge();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBallance();
                            break;
                        }
                    case 8:
                        {
                            System.Console.WriteLine("-------Taking to main menu-------");
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }
        public static void ShowMyProfile()
        {
            System.Console.WriteLine("Your Details are:");
            System.Console.WriteLine("|Name|Father Name|Gender|MobileNumber|MailID");
            System.Console.WriteLine($"|{currentLoggedIn.Name}|{currentLoggedIn.FatherName}|{currentLoggedIn.Gender}|{currentLoggedIn.MobileNumber}|{currentLoggedIn.MailID}|");
        }
        public static void OderHistory()
        {
            bool flag = true;
            foreach (OrderDetails history in oderList)
            {

                if (currentLoggedIn.UserID.Equals(history.UserID))
                {
                    System.Console.WriteLine("The oder history are");
                    System.Console.WriteLine("|UserID|OderID|Oder Date|Total Price|Oder Status");
                    System.Console.WriteLine($"|{currentLoggedIn.UserID}|{history.OderID}|{history.OderDate.ToShortDateString()}|{history.TotalPrice}|{history.OderStatus}|");
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                System.Console.WriteLine("Sorry No Oder History");

            }

        }

        public static void Recharge()
        {
            Console.WriteLine("Please Enter the Amount to Recharge");
            double amount = double.Parse(Console.ReadLine());
            currentLoggedIn.WalletRecharge(amount);
            Console.WriteLine("Your wallet is recharged");

        }

            public static void ShowWalletBallance()   
            {
               System.Console.WriteLine(currentLoggedIn.WalletBalance); 
            }     
    }
}
