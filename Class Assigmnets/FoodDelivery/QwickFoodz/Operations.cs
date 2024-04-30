using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public static class Operations
    {
        public static string Line = "-----------------------------------------------------------";
        public static CustomerDetails currentLoggedIn;
        //List for datas
        public static List<CustomerDetails> customerList = new List<CustomerDetails>();
        public static List<FoodDetails> foodList = new List<FoodDetails>();
        public static List<OderDetails> oderList = new List<OderDetails>();
        public static List<ItemDetails> itemList = new List<ItemDetails>();
        public static void AddingData()
        {
            //Customer Details
            CustomerDetails cutomer1 = new CustomerDetails("Ravi", "Ettaparajan", Gender.Male, "9747746467", new DateTime(1999, 11, 11), "ravi@gamil.com", "Chennai", 10000);
            CustomerDetails cutomer2 = new CustomerDetails("Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "Baskaran@gamil.com", "Chennai", 15000);
            customerList.AddRange(new List<CustomerDetails> { cutomer1, cutomer2 });

            // foreach(CustomerDetails customer in customerList)
            // {
            //     System.Console.WriteLine($"|{customer.CustomerID}|{customer.Name}|{customer.FatherName}|{customer.Gender}|{customer.Mobile}||{customer.DOB.ToString("dd/MM/yyyy")}|{customer.MailID}|{customer.Location}|{customer._balance}");
            // }


            //FoodDetails
            FoodDetails food1 = new FoodDetails("Chiken Biriyani 1KG", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Biriyani 1KG", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodels", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly(2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Biriyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chiken 65 (200 Grams)", 75, 30);
            foodList.AddRange(new List<FoodDetails> { food1, food2, food3, food4, food5, food6, food7, food8, food9, food10, food11 });


            // foreach(FoodDetails food in foodList)
            // {
            //     System.Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.PricePerQuantity}|{food.QuantityAvailable}");
            // }


            //oderDetails
            OderDetails oder1 = new OderDetails("CID1001", 580, new DateTime(2022, 11, 26), OderStatus.Ordered);
            OderDetails oder2 = new OderDetails("CID1002", 870, new DateTime(2022, 11, 26), OderStatus.Ordered);
            OderDetails oder3 = new OderDetails("CID1001", 820, new DateTime(2022, 11, 26), OderStatus.Cancelled);
            oderList.AddRange(new List<OderDetails> { oder1, oder2, oder3 });

            // foreach(OderDetails oder in oderList)
            // {
            //     System.Console.WriteLine($"|{oder.CustomerID}|{oder.TotalPrice}|{oder.DateOfOder.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
            // }

            //ItemDetails
            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);
            itemList.AddRange(new List<ItemDetails> { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 });
            // foreach(ItemDetails item in itemList)
            // {
            //     System.Console.WriteLine($"|{item.OderID}|{item.FoodID}|{item.PurchaseCount}|{item.PriceOfOrder}");
            // }
        }

        public static void MainMenu()
        {
            bool flag = true;

            do
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine("Select the Option\n1.Registation\n2.Login\n3.Exit");
                System.Console.WriteLine(Line);
                int option = int.Parse(Console.ReadLine());
                System.Console.WriteLine(Line);

                switch (option)
                {
                    case 1:
                        {
                            Registation();
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

        public static void Registation()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            System.Console.WriteLine("Enter your Fathername");
            string fatherName = Console.ReadLine();
            System.Console.WriteLine("Enter your gender(Male,Female,Transgender)");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            System.Console.WriteLine("Enter your PhoneNumber");
            string mobile = Console.ReadLine();
            System.Console.WriteLine("Enter your Date of Birth");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            System.Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();
            System.Console.WriteLine("Enter your Location");
            string location = Console.ReadLine();
            System.Console.WriteLine("Enter the amount to Recharge your WalletBalance");
            double amount = double.Parse(Console.ReadLine());
            System.Console.WriteLine(Line);
            CustomerDetails customer = new CustomerDetails(name, fatherName, gender, mobile, dob, mailID, location, amount);
            customerList.Add(customer);
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Registedred Succesfully and your Customer ID id " + customer.CustomerID);
            System.Console.WriteLine(Line);

        }
        public static void Login()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Enter your loginID");
            string newcustomerID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (CustomerDetails customer in customerList)
            {
                if (newcustomerID.Equals(customer.CustomerID))
                {
                    System.Console.WriteLine(Line);
                    System.Console.WriteLine("Login Successfull");
                    System.Console.WriteLine(Line);
                    flag = false;
                    currentLoggedIn = customer;
                    Submenu();
                }
            }
            if (flag)
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine("please Enter valid ID");
                System.Console.WriteLine(Line);

            }

        }
        public static void Submenu()
        {
            bool flag = true;
            do
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine("Select your option\n1.Show Profile\n2.Order Food\n3.Cancel Order\n4.Modify Order\n5.Order History\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                System.Console.WriteLine(Line);
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    // Show Profile
                    case 1:
                        {
                            ShowProfile();
                            break;
                        }

                    // Order Food
                    case 2:
                        {
                            OrderFood();
                            break;
                        }
                    // Cancel Order
                    case 3:
                        {
                            CancelOrder();
                            break;
                        }
                    // Modify Order 
                    case 4:
                        {
                            ModifyOrder();
                            break;
                        }
                    // Order History
                    case 5:
                        {
                            OrderHistory();
                            break;
                        }
                    // Recharge Wallet
                    case 6:
                        {
                            RechargeWallet();
                            break;

                        }

                    // Show Wallet Balance
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    // Exit
                    case 8:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void ShowProfile()
        {
            bool flag = false;
            foreach (CustomerDetails customer in customerList)
            {
                if (currentLoggedIn.CustomerID.Equals(customer.CustomerID))
                {
                    flag = true;
                    break;
                }

            }
            if (flag)
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine($"|{currentLoggedIn.CustomerID}|{currentLoggedIn.Name}|{currentLoggedIn.FatherName}|{currentLoggedIn.Gender}|{currentLoggedIn.Mobile}||{currentLoggedIn.DOB.ToString("dd/MM/yyyy")}|{currentLoggedIn.MailID}|{currentLoggedIn.Location}|{currentLoggedIn._balance}");
                System.Console.WriteLine(Line);

            }
        }


        public static void OrderHistory()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("|OderID |CustomerID|TotalPrice|DateOfOder|oder.OderStatus|");
            foreach (OderDetails oder in oderList)
            {
                if (currentLoggedIn.CustomerID.Equals(oder.CustomerID))
                {
                    System.Console.WriteLine(Line);
                    System.Console.WriteLine($"|{oder.OderID} |{oder.CustomerID}|{oder.TotalPrice}|{oder.DateOfOder.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                    System.Console.WriteLine(Line);

                }

            }

        }
        public static void RechargeWallet()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Enter the amount to Reachrge");
            double amount = double.Parse(Console.ReadLine());
            if(amount>0)
            {
                 currentLoggedIn.WalletRecharge(amount);
                 System.Console.WriteLine("Your wallet is recharged");
            }
            else{
                System.Console.WriteLine("Please Enter Valid amount");
            }
           
            System.Console.WriteLine(Line);

        }

        public static void ShowWalletBalance()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Your Balance is " + currentLoggedIn._balance);
            System.Console.WriteLine(Line);
        }

        public static void CancelOrder()
        {
            System.Console.WriteLine(Line);
            System.Console.WriteLine("|OderID |CustomerID|TotalPrice|DateOfOder|oder.OderStatus|");
            System.Console.WriteLine(Line);
            // Show the list of orders placed by current logged in user whose status is “Ordered”.
            foreach (OderDetails oder in oderList)
            {

                if (currentLoggedIn.CustomerID.Equals(oder.CustomerID) && oder.OderStatus.Equals(OderStatus.Ordered))
                {
                    System.Console.WriteLine($"|{oder.OderID} |{oder.CustomerID}|{oder.TotalPrice}|{oder.DateOfOder.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                }
            }
            //Ask the user to pick an order to be cancelled by OrderID.
            System.Console.WriteLine("Enter the oder OderId to cancel");
            System.Console.WriteLine(Line);
            string newOderID = Console.ReadLine().ToUpper();
            bool flag = true;
            //check oder id in oder list
            foreach (OderDetails oder in oderList)
            {//If OrderID is present, then change the order status to “Cancelled”
                if (oder.OderID.Equals(newOderID))
                {
                    flag = false;
                    // change the order status to “Cancelled”
                    oder.OderStatus = OderStatus.Cancelled;
                    System.Console.WriteLine(Line);
                    System.Console.WriteLine("Your oder is canceled");
                    System.Console.WriteLine(Line);
                    //  Refund the total price amount of current order to user’s WalletBalance 
                    currentLoggedIn._balance += oder.TotalPrice;
                    // return the food items of the current order to FoodList. 
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OderID.Equals(oder.OderID))
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                if (food.FoodID.Equals(item.FoodID))
                                {
                                    flag = false;
                                    food.QuantityAvailable += item.PurchaseCount;

                                }

                            }
                        }

                    }

                }

            }
            if (flag)
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine("Enter the valid OderID");
                System.Console.WriteLine(Line);
            }







        }

        public static void ModifyOrder()
        {
            // Show the orders placed by current logged in user whose order status is booked.
            System.Console.WriteLine(Line);
            System.Console.WriteLine("|OderID |CustomerID|TotalPrice|DateOfOder|oder.OderStatus|");
            System.Console.WriteLine(Line);
            foreach (OderDetails oder in oderList)
            {
                if (currentLoggedIn.CustomerID.Equals(oder.CustomerID) && oder.OderStatus.Equals(OderStatus.Ordered))
                {
                    System.Console.WriteLine($"|{oder.OderID}|{oder.CustomerID}|{oder.TotalPrice}|{oder.DateOfOder.ToString("dd/MM/yyyy")}|{oder.OderStatus}");
                }

            }
            // Ask OrderID to modify orders
            System.Console.WriteLine(Line);
            System.Console.WriteLine("Enter the OderID to modify");
            System.Console.WriteLine(Line);
            string newoderID = Console.ReadLine().ToUpper();
            //  Check OrderID is valid, and it is of current user’s and its status is Ordered.
            bool flag = true;
            foreach (OderDetails oder in oderList)
            {
                if (newoderID.Equals(oder.OderID) && oder.OderStatus.Equals(OderStatus.Ordered))
                {System.Console.WriteLine("ItemID|OderID|FoodID|PurchaseCount|PriceOfOrder");
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OderID.Equals(oder.OderID))
                        { // Then fetch the item details of corresponding order and show it.
                            System.Console.WriteLine($"|{item.ItemID}|{item.OderID}|{item.FoodID}|{item.PurchaseCount}|{item.PriceOfOrder}");
                            flag = false;


                        }
                    }

                }
            }
            if (flag)
            {
                System.Console.WriteLine(Line);
                System.Console.WriteLine("Invalid OderID");
            }
            //Ask ItemID and check ItemID is valid.
            System.Console.WriteLine("Enter the ItemID");
            System.Console.WriteLine(Line);
            string newItemId = Console.ReadLine().ToUpper();
            bool flag2 = true;
            foreach (ItemDetails item1 in itemList)
            {
                if (item1.ItemID.Equals(newItemId))
                { // Then ask user to provide new item quantity.
                    System.Console.WriteLine("Enter the new ItemQuantity");
                    System.Console.WriteLine(Line);
                    int newQuantity = int.Parse(Console.ReadLine());
                    // Based on new item quantity the item object needs to be updated its price.
                    System.Console.WriteLine("Number to incread or decreased(+ or -)");
                    System.Console.WriteLine(Line);
                    char res = char.Parse(Console.ReadLine());
                    flag2 = false;
                    bool flag1 = false;
                    do
                    {
                        double eachprice = item1.PriceOfOrder / item1.PurchaseCount;
                        if (res == '+')
                        {

                            item1.PriceOfOrder += eachprice * newQuantity;
                            if (currentLoggedIn._balance > eachprice * newQuantity)
                            {
                                currentLoggedIn.DeductBalance(eachprice * newQuantity);
                                item1.PriceOfOrder += eachprice * newQuantity;
                                item1.PurchaseCount += newQuantity; 
                            }
                            else
                            {
                                RechargeWallet();
                                
                            }


                        }
                        else if (res == '-')
                        {
                            if (item1.PurchaseCount < newQuantity)
                            {
                                System.Console.WriteLine("Quantity is less in item");

                            }
                            else
                            {
                                item1.PriceOfOrder -= eachprice * newQuantity;
                                currentLoggedIn.WalletRecharge(eachprice * newQuantity);
                                item1.PurchaseCount -= newQuantity; 
                            }


                        }
                        else
                        {
                            System.Console.WriteLine("PleaseEnter valid Character");
                            flag1 = true;
                        }
                    } while (flag1);

                }

            }
            if (flag2)
            {
                System.Console.WriteLine("Please Enter valid Item ID");
            }








            // f.	If item quantity increased, then item amount will be collected from current user if he has enough balance. If he has no balance, ask him to recharge with that amount and proceed. If the item quantity reduced, then balance amount should be returned to current user.
            // g.	Update the total amount of order and show “Order ID + (OID3001) + modified successfully”.


        }


        public static void OrderFood()
        {
            //  OrderDetails object with CustomerID, TotalPrice = 0, DateOfOrder as today and OrderStatus = Initiated.

            // localItemList for adding your wishlist.

            //  list of food items available in store for processing the order.

            bool item1 = true;
            do
            {
                bool flag3 = true;
                do
                {
                    OderDetails oder1 = new OderDetails(currentLoggedIn.CustomerID, 0, DateTime.Now, OderStatus.Initiated);
                    List<ItemDetails> LocalItemlist = new List<ItemDetails>();
                    System.Console.WriteLine("FoodID|FoodName|PricePerQuantity|QuantityAvailable|");
                    foreach (FoodDetails food in foodList)
                    {
                        System.Console.WriteLine($"|{food.FoodID}|{food.FoodName}|{food.PricePerQuantity}|{food.QuantityAvailable}");
                    }
                    // Ask the FoodID
                    System.Console.WriteLine("Enter the food ID");
                    string newFoodID = Console.ReadLine().ToUpper();
                    System.Console.WriteLine("Ente the Quantity of food to purchase");
                    int newquantity = int.Parse(Console.ReadLine());
                    bool flag = true;
                    foreach (FoodDetails food in foodList)
                    {
                        // order quantity from user and check whether it is available
                        if (newFoodID.Equals(food.FoodID) && food.QuantityAvailable > newquantity)
                        {//create ItemDetails object with created OrderID, FoodID, Quantity and Price of this order, deduct the available quantity and store the ItemDetails object in localItemList.
                         // Calculate total price of this order by summing it with current item’s price.
                            flag = false;
                            double oderamount = food.PricePerQuantity * newquantity;
                            ItemDetails item = new ItemDetails(oder1.OderID, newFoodID, newquantity, oderamount);
                            LocalItemlist.Add(item);
                            // Ask the user whether he want to order more. 
                            System.Console.WriteLine("Do you need to purchase more (yes or no)");
                            flag = false;

                            string ans1 = Console.ReadLine();
                            // If “Yes” means again show food details and repeat from step “c” to create new ItemDetails object. Repeat this process until he says “No”.
                            if (ans1 == "yes")
                            {
                                item1 = true;
                                flag3 = false;
                            }
                            else if (ans1 == "no")
                            {
                                // If user select “No” then show “Do you want to confirm purchase.
                                System.Console.WriteLine("Do you need to confirm The oder (yes or no)");
                                string ans2 = Console.ReadLine();
                                if (ans2 == "yes")
                                {
                                    // Check whether the customer wallet has sufficient balance.
                                    if (currentLoggedIn._balance > oderamount)
                                    {
                                        flag3 = true;
                                        System.Console.WriteLine("Your Wallet balance is before purchase " + currentLoggedIn._balance);
                                        // modify OrderDetails object which was created at beginning with TotalPrice and OrderStatus to “Ordered”.
                                        oder1.OderStatus = OderStatus.Ordered;
                                        oder1.TotalPrice = oderamount;
                                        // Deduct the total amount from user’s wallet balance.
                                        currentLoggedIn.DeductBalance(oderamount);
                                        itemList = LocalItemlist;
                                        //Add the localItemList to ItemList.
                                        ItemDetails newItem = new ItemDetails(oder1.OderID, newFoodID, newquantity, oderamount);
                                        itemList.Add(newItem);
                                        oderList.Add(oder1);
                                        System.Console.WriteLine("Your Food is oderedand your ID is" + oder1.OderID);
                                        System.Console.WriteLine("Your Wallet balance is after purchase " + currentLoggedIn._balance);
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("Recharge your Wallet and try again");
                                        RechargeWallet();
                                    }
                                }
                                else
                                { //return the localItemList of items count back to FoodDetails list.
                                    food.QuantityAvailable = item.PurchaseCount;
                                }

                                // If the balance is insufficient, inform the customer that the wallet has insufficient balance and whether wish to recharge /not.
                                // If he says “No” return the localItemList item’s count to FoodList.

                            }


                        }
                    }
                    if (flag)
                    {
                        //show FoodID Invalid or FoodQuantity unavailable based on the scenario. 
                        System.Console.WriteLine("FoodID Invalid or FoodQuantity unavailable");
                    }
                } while (!flag3);

            } while (!item1);











        }




    }
}/* using System;

        public class Program
        {
            public static void Main(string[] args)
            {
             int num = int.Parse(Console.ReadLine());
             if(num<=0)
             {
                num = 1;

             }
             int count = 0;curr = num+1;
             while (count <3)
             {
                bool prime = true;
                for (int i  = 2;i*i<=curr;i++)
                {
                    if(curr%i==0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                Console.WriteLine(curr);
                count++;
             }
            }
        }
               */
               /*using System;

        public class Program
        {
            public static void Main(string[] args)
            {
              string [] str1 = Console.ReadLine().Split(" ");
              string first = "";
              string sec = "";
              bool flag = false;
              string lname1 = str1[str1.Length-1];
              string lname2 = str1[str2.Length-1];
              int i1 = 0,i2 =0;
              while(i1<lname1.Length && i2<lname2.Length)
              {
                if(lname1[i1]>lname2[i2])
                {
                    flag = false;
                    break;
                }
                else if (lname2[i2]>lname1[i1])
                {
                    flag = true;
                    break;
                }
                else{
                    i1++;
                    i2++;
                }
              }
              if(flag)
              {
                foreach(string i in str1)
                {
                    first +=(i+" ");
                }
                 foreach(string i in str2)
                {
                    sec +=(i+" ");
                }
              }
              else{
                 foreach(string i in str2)
                {
                    first +=(i+" ");
                }
                 foreach(string i in str1)
                {
                    sec +=(i+" ");
                }
              }
              Console.WriteLine(first.TrimEnd());
              Console.WriteLine(sec.TrimEnd());


            }
        }
               */







               /* char[] str = Console.ReadLine().ToCHarArray();
                int odd =1,even =2;
                while(odd<str.Length && even<str.Length)
                {
                    char temp = str[even];
                    str[odd] = temp;
                    odd +=2;
                    even +=2;
                }
                for (int i = 0;i<str.Length;i++)
                {
                    Console.WriteLine(str[i]);
                } */


                /*{
               int num1 = int.Parse(Console.ReadLine());
               int num2 = int.Parse(Console.ReadLine());
               char sym = char.Parse(Console.ReadLine());
               switch(sym)
               {
                case '+':
                {
                  Console.WriteLine(Addition(num1,num2));
                  break;
                }
                 case '-':
                {
                  Console.WriteLine(Subtraction(num1,num2));
                  break;
                }
                 case '*':
                {
                  Console.WriteLine(Multipilication(num1,num2));
                  break;
                }
                 case '/':
                {
                  Console.WriteLine(Division(num1,num2));
                  break;
                }
               }   */