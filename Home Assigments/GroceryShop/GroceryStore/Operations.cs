using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace GroceryStore
{

    public static partial class Operations
    {

        public static CustomerRegistration currentLoggedIn;
        public static List<CustomerRegistration> customerList = new List<CustomerRegistration>();
        public static List<ProductDetails> productList = new List<ProductDetails>();
        public static List<BookingDetails> bookingList = new List<BookingDetails>();
        public static List<OderDetails> oderList = new List<OderDetails>();
        public static List<OderDetails> tempoderList = new List<OderDetails>();

        public static void Mainmenu()
        {


            bool flag = true;
            do
            {
                System.Console.WriteLine("Select the option\n1.CustomerRegistration\n2.CustomerLogin\n3.Exit");
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

                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }

        public static void Registration()
        {
            System.Console.WriteLine("Enter your the amount to recahrge your wallet");
            double _balance = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter Father name:");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter Your Gender(Male,Female,Transgender):");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter Your MobileNumber:");
            string mobile = Console.ReadLine();
            System.Console.WriteLine("Enter Your Date Of Birth(dd/MM/yyy):");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter Your mailID:");
            string mailID = Console.ReadLine();

            CustomerRegistration customer = new CustomerRegistration(_balance, name, fatherName, gender, mobile, dob, mailID);
            customerList.Add(customer);
            System.Console.WriteLine("Your Customer" + customer.CustomerID);
        }
        public static void Login()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Enter the CustomerID:");
                string newcustomerID = Console.ReadLine();
                foreach (CustomerRegistration customer in customerList)
                {
                    if (customer.CustomerID.Equals(newcustomerID))
                    {
                        currentLoggedIn = customer;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Invalid Customer ID or ID Not present");
                }
                else
                {
                    System.Console.WriteLine("Login Succesfull");
                    SubMenu();
                    flag = false;
                }


            } while (flag);


        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine("Select the option\n1.Show Customer Details\n2.Show Product Details\n3.WalletRecharge\n4.Take Oder\n5.Modify Oder\n6.Cancel Oder\n7.Show Balance\n8.Exit");
                int option = int.Parse(Console.ReadLine());
                flag = true;
                switch (option)
                {

                    case 1:
                        {
                            ShowCustomerDetails();
                            break;
                        }
                    case 2:
                        {
                            ProductDetails.ShowProductDetails();
                            break;
                        }
                    case 3:
                        {
                            System.Console.WriteLine("Enter the amount to recharge:");
                            double amount = double.Parse(Console.ReadLine());
                            currentLoggedIn.WalletRecharge(amount);
                            System.Console.WriteLine("Your wallet is recharged");
                            break;
                        }
                    case 4:
                        {  TakeOrder();
                            break;
                        }
                    case 5:
                        {//ModifyOder();
                            break;
                        }
                    case 6:
                        {//cancelOder();
                            break;
                        }
                    case 7:
                        {
                            System.Console.WriteLine(currentLoggedIn.WalletBalance);
                            break;
                        }
                    case 8:
                        {
                            flag = false;
                            break;
                        }
                }

            } while (flag);
        }
        public static void ShowCustomerDetails()
        {
            System.Console.WriteLine("|CustomerID|Wallet Balance|Customer Name|Customer Father Name|Customer Gender|Customer Mobile|Customer DOB|Customer MailID|");
            bool flag = false;
            foreach (CustomerRegistration customer in customerList)
            {
                if (currentLoggedIn.CustomerID.Equals(customer.CustomerID))
                {
                    flag = true;
                    break;
                }
                if (flag)
                {
                    System.Console.WriteLine($"|{currentLoggedIn.CustomerID}|{currentLoggedIn.WalletBalance}|{currentLoggedIn.Name}|{currentLoggedIn.FatherName}|{currentLoggedIn.Gender}|{currentLoggedIn.Mobile}|{currentLoggedIn.DOB}|{currentLoggedIn.MailID}|");
                }
                else
                {
                    System.Console.WriteLine("Invalid Customer ID please re-enter again");
                }
            }


        }
        public static void AddingData()
        {
            CustomerRegistration customer1 = new CustomerRegistration(10000, "Ravi", "Ettaparajan", Gender.Male, "9994992745", new DateTime(1999, 11, 11), "ravi@gmail.com");
            CustomerRegistration customer2 = new CustomerRegistration(15000, "Baskaran", "sethurajan", Gender.Male, "9994992745", new DateTime(1999, 11, 11), "baskaran@gmail.com");
            customerList.AddRange(new List<CustomerRegistration> { customer1, customer2 });

            
            BookingDetails booking1 = new BookingDetails(currentLoggedIn.CustomerID, 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking2 = new BookingDetails(currentLoggedIn.CustomerID, 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
            BookingDetails booking3 = new BookingDetails(currentLoggedIn.CustomerID, 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
            BookingDetails booking4 = new BookingDetails(currentLoggedIn.CustomerID, 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);
            bookingList.AddRange(new List<BookingDetails> { booking1, booking2, booking3, booking4 });


            ProductDetails product1 = new ProductDetails("sugar", 20, 40);
            ProductDetails product2 = new ProductDetails("Rice", 100, 50);
            ProductDetails product3 = new ProductDetails("Milk", 10, 40);
            ProductDetails product4 = new ProductDetails("cofee", 20, 10);
            ProductDetails product5 = new ProductDetails("Tea", 10, 40);
            ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
            ProductDetails product7 = new ProductDetails("salt", 10, 10);
            ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
            ProductDetails product9 = new ProductDetails("Chili Powder", 10, 20);
            ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);
            productList.AddRange(new List<ProductDetails> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 });


            OderDetails oder1 = new OderDetails(booking1.BookingID, product1.ProductID, 2, 80);
            OderDetails oder2 = new OderDetails(booking1.BookingID, product2.ProductID, 2, 100);
            OderDetails oder3 = new OderDetails(booking1.BookingID, product3.ProductID, 1, 40);
            OderDetails oder4 = new OderDetails(booking1.BookingID, product1.ProductID, 1, 40);
            OderDetails oder5 = new OderDetails(booking2.BookingID, product2.ProductID, 4, 200);
            OderDetails oder6 = new OderDetails(booking2.BookingID, product10.ProductID, 1, 140);
            OderDetails oder7 = new OderDetails(booking2.BookingID, product9.ProductID, 1, 20);
            OderDetails oder8 = new OderDetails(booking3.BookingID, product2.ProductID, 2, 100);
            OderDetails oder9 = new OderDetails(booking3.BookingID, product8.ProductID, 4, 100);
            OderDetails oder10 = new OderDetails(booking3.BookingID, product1.ProductID, 2, 80);
            productList.AddRange(new List<ProductDetails> { product1, product2, product3, product4, product5, product6, product7, product8, product9, product10 });

        }


    }
}