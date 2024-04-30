using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public class FileHandling
    {
        public static void Create()
        {
            if(!Directory.Exists("FileHandling"))
            {
                System.Console.WriteLine("Creating Folder....");
                Directory.CreateDirectory("FileHandling");
                
            }
            else
            {
                System.Console.WriteLine("Dircetory Exists");
            }

            if(!File.Exists("FileHandling/CustomerDetails.csv"))
            {
                System.Console.WriteLine("Creating File....");
                File.Create("FileHandling/CustomerDetails.csv").Close();

            }
            else
            {
                 System.Console.WriteLine("File Exists");   
            }
             if(!File.Exists("FileHandling/FoodDetails.csv"))
            {
                System.Console.WriteLine("Creating File....");
                File.Create("FileHandling/FoodDetails.csv").Close();

            }
            else
            {
                 System.Console.WriteLine("File Exists");   
            }
            if(!File.Exists("FileHandling/ItemDetails.csv"))
            {
                System.Console.WriteLine("Creating File....");
                File.Create("FileHandling/ItemDetails.csv").Close();

            }
            else
            {
                 System.Console.WriteLine("File Exists");   
            }
              if(!File.Exists("FileHandling/OderDetails.csv"))
            {
                System.Console.WriteLine("Creating File....");
                File.Create("FileHandling/OderDetails.csv").Close();

            }
            else
            {
                 System.Console.WriteLine("File Exists");   
            }
        }
        public static void WriteToCSV()
        {
            string [] customers = new string[Operations.customerList.Count];

            for(int i = 0;i<Operations.customerList.Count;++i)
            {
                customers[i] = Operations.customerList[i].CustomerID+","+Operations.customerList[i].Name+","+Operations.customerList[i].FatherName+","+Operations.customerList[i].Gender+","+Operations.customerList[i].Mobile+","+Operations.customerList[i].DOB.ToString("dd/MM/yyyy")+","+Operations.customerList[i].MailID+","+Operations.customerList[i].Location+Operations.customerList[i]._balance;
            }
            File.WriteAllLines("FileHandling/CustomerDetails.csv",customers);

            string [] food = new string[Operations.foodList.Count];

            for(int i = 0;i<Operations.foodList.Count;++i)
            {
                customers[i] = Operations.foodList[i].FoodName+","+Operations.foodList[i].PricePerQuantity+","+Operations.foodList[i].QuantityAvailable;
             }
            File.WriteAllLines("FileHandling/FoodDetails.csv",food);

             string [] oder = new string[Operations.foodList.Count];

            // for(int i = 0;i<Operations.oderList.Count;++i)
            // {
            //     oder[i] = Operations.oderList[i]*
            //  }
            // File.WriteAllLines("FileHandling/FoodDetails.csv",food);
        }
    }
}