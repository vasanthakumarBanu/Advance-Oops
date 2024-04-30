using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace CafeteriaManagment
{
    public static partial class Operations
    {
        public static string Line = "------------------------------------------------------------------";

        static List<FoodDetails> foodList = new List<FoodDetails>();
        static List<UserDetails> userList = new List<UserDetails>();
        static List<OrderDetails> oderList = new List<OrderDetails>();
        static List<Cartltem> cartList = new List<Cartltem>();





        // adding defaults starts
        public static void AddingDefault()
        {
            //FoofDetails deault data.
            FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
            FoodDetails food2 = new FoodDetails("Tea", 15, 100);
            FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
            FoodDetails food4 = new FoodDetails("Juice", 50, 100);
            FoodDetails food5 = new FoodDetails("Puff", 40, 100);
            FoodDetails food6 = new FoodDetails("Milk", 10, 100);
            FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);
            foodList.AddRange(new List<FoodDetails> { food1, food2, food3, food4, food5, food6, food7 });

            // UserDetails Data 
            UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", Gender.Male, 8857777575, "ravi@gmail.com", 400, "WS101");
            UserDetails user2 = new UserDetails("Baskaran", "Sethiurajan", Gender.Male, 9577747744, "baskaran@gmail.com", 500, "WS105");
            userList.AddRange(new List<UserDetails> { user1, user2 });

            //Oder DEtails
            OrderDetails oder1 = new OrderDetails(user1.UserID, new DateTime(2022, 06, 15), 70, OderStatus.Odered);
            OrderDetails oder2 = new OrderDetails(user2.UserID, new DateTime(2022, 06, 15), 100, OderStatus.Odered);
            oderList.AddRange(new List<OrderDetails> { oder1, oder2 });

            //cartItem Details
            Cartltem cart1 = new Cartltem(oder1.OderID, food1.FoodID, 20, 1);
            Cartltem cart2 = new Cartltem(oder1.OderID, food1.FoodID, 10, 1);
            Cartltem cart3 = new Cartltem(oder1.OderID, food1.FoodID, 40, 1);
            Cartltem cart4 = new Cartltem(oder2.OderID, food1.FoodID, 10, 1);
            Cartltem cart5 = new Cartltem(oder2.OderID, food1.FoodID, 50, 1);
            Cartltem cart6 = new Cartltem(oder2.OderID, food1.FoodID, 40, 1);
            cartList.AddRange(new List<Cartltem> { cart1, cart2, cart3, cart4, cart5, cart6 });



        }
        // adding defaults ends
        public static void MainMenu()
        {
            bool flag = true;
            do{
            System.Console.WriteLine(Line);
            System.Console.WriteLine("--------------Welcome to the SyncFusion Cafeteria-------------");
            System.Console.WriteLine("Please select the option\n1.User Registration\n2.User Login\n3.Exit");
            int option = int.Parse(Console.ReadLine());
            System.Console.WriteLine(Line);
            flag = true;
           
           
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
                    System.Console.WriteLine("-------------Thankyou ! Come gain-----------------");
                    System.Console.WriteLine(Line);
                    flag = false;
                    break;
                }

            }
            System.Console.WriteLine(Line);
            }while (flag);

        }
        //Main Menu
        public static void Registration()
        {
            System.Console.WriteLine(Line);
            Console.Write("Enter Your Name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Your FatherName: ");
            string fatherName = Console.ReadLine();
            Console.Write("Enter Your MobileNumber: ");
            long mobileNumber;
            bool isValid = long.TryParse(Console.ReadLine(), out mobileNumber);
            while (!isValid)
            {
                System.Console.WriteLine("Please enter the valid Mobile number");
                isValid = long.TryParse(Console.ReadLine(), out mobileNumber);

            }
            Console.Write("Enter Your MailID: ");
            string mailID = Console.ReadLine();
            Console.Write("Enter Your Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Please Enter your Workstation number(ex:WS101)");
            string workStationNumber = Console.ReadLine();
            System.Console.WriteLine("Please ENter the amount to Recharge:");
            int _balance = int.Parse(Console.ReadLine());
            //Need to get object.
            UserDetails user = new UserDetails(studentName, fatherName,gender,mobileNumber,mailID,_balance,workStationNumber);
            //Need to Add in the list.
            userList.Add(user);
            //Need to Display Confirmation and ID.
            System.Console.WriteLine(Line);
            Console.WriteLine("Registered Succesfully and Your StudentID is :" + user.UserID);

            
            //details end            
        }
        public static void Login()
        {
            bool flag = true;
            System.Console.WriteLine(Line);
            System.Console.WriteLine("--------Welcome to SyncFusion Login Page---------");
            do
            {
                flag = true;

                System.Console.WriteLine("Please Enter your UserID: (ex:SF1001)");
                System.Console.WriteLine(Line);
                string loginID = Console.ReadLine().ToUpper();
                foreach (UserDetails user in userList)
                {
                    if (user.UserID.Equals(loginID))
                    {
                        currentLoggedIn = user;
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    System.Console.WriteLine("Invalid ID or ID Not present");
                    System.Console.WriteLine(Line);
                }
                else
                {
                    //passing all details of current user to new variable
                    System.Console.WriteLine("Login Sucessfull");
                    System.Console.WriteLine(Line);
                    //submenu
                    SubMenu();
                }
            } while (flag);
        }




    }
}