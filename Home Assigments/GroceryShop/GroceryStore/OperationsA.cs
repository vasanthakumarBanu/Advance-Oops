using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore
{
    public static partial class Operations
    {
        public static void TakeOrder()
        {
            bool flag = true;
            System.Console.WriteLine("Do you need to Purchase (yes or No)");
            string ans = Console.ReadLine();
            do
            {

                if (ans == "yes")
                {
                    List<OderDetails> TempproductList = new List<OderDetails>();
                    System.Console.WriteLine("|ProductID|Product Name|Quantity Avialable|Priceperquantity|");
                    foreach (ProductDetails product in Operations.productList)
                    {
                        System.Console.WriteLine($"|{product.ProductID}|{product.ProductName}|{product.QuantityAvialable}|{product.PricePerQuantity}");
                    }
                    System.Console.WriteLine("Enter the Product ID you like it to buy");
                    string newProductID = Console.ReadLine();
                    string option1 = "no";
                    foreach (ProductDetails product in Operations.productList)
                    {
                        if (product.ProductID.Equals(newProductID) && product.QuantityAvialable > 0)
                        {
                            option1 = "yes";
                        }
                        bool point = true;
                        do
                        {
                            if (option1 == "yes")
                            {
                                System.Console.WriteLine("Please enter the purchase quantity");
                                int purchaseQuantity = int.Parse(Console.ReadLine());

                                if (product.QuantityAvialable < purchaseQuantity)
                                {
                                    System.Console.WriteLine("The Avialable quantity is" + product.QuantityAvialable);
                                    point = false;

                                }
                                else
                                {
                                    int totalprice = purchaseQuantity * product.PricePerQuantity;
                                    BookingDetails newbooking = new BookingDetails(currentLoggedIn.CustomerID, totalprice, DateTime.Now, BookingStatus.Initiated);
                                    bookingList.Add(newbooking);
                                    OderDetails newoder = new OderDetails(newbooking.BookingID, product.ProductID, purchaseQuantity, totalprice);
                                    tempoderList.Add(newoder);
                                    foreach (ProductDetails product1 in productList)
                                    {
                                        if (newProductID.Equals(product1.ProductID))
                                        {
                                            product1.QuantityAvialable -= purchaseQuantity;
                                            break;
                                        }

                                    }
                                    System.Console.WriteLine("Product Succefully added to cart.");

                                }

                            }


                        } while (!point);

                    }
                }
                else
                {
                    System.Console.WriteLine("No Product AVialable for your productID");

                }
                System.Console.WriteLine("DO you need to purchace again(yes or no)");
                string option2 = Console.ReadLine();
                if (option2 == "yes")
                {
                    flag = true;
                }
                else
                {
                    System.Console.WriteLine("Do you need to Confirm the oder (yes or no) ");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        foreach (BookingDetails booking in bookingList)
                        {
                            if (currentLoggedIn.WalletBalance > booking.TotalPrice)
                            {
                                   deductbalance(amount);

                            }
                        }
                    }
                    else
                    {

                    }
                }
            } while (flag);
        }



    }

}
