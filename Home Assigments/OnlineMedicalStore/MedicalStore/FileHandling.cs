// using System;
// using System.Collections.Generic;
// using System.IO;
// using System.Linq;
// using System.Threading.Tasks;

// namespace MedicalStore
// {
//     public class FileHandling
//     {
//         public static void Create()
//         {
//             if(!Directory.Exists(@"MedicalStore\FileHandling"))
//             {
//                 System.Console.WriteLine("Creating Folder...");
//                 Directory.CreateDirectory(@"MedicalStore\FileHandling");
//             }
//             else
//             {
//                 System.Console.WriteLine("Directory Already Exists");
//             }
//             if(!File.Exists(@"MedicalStore\FileHandling\Medicine.CSV"))
//             {
//                 System.Console.WriteLine("Creating CSV file...");
//                 File.Create(@"MedicalStore\FileHandling\Medicine.CSV");
//             }
//             else
//             {
//                 System.Console.WriteLine("File Already Exists");
//             }

//             if(!File.Exists(@"MedicalStore\FileHandling\oder.CSV"))
//             {
//                 System.Console.WriteLine("Creating CSV file...");
//                 File.Create(@"MedicalStore\FileHandling\oder.CSV");
//             }
//             else
//             {
//                 System.Console.WriteLine("File Already Exists");
//             }

//             if(!File.Exists(@"MedicalStore\FileHandling\user.CSV"))
//             {
//                 System.Console.WriteLine("Creating CSV file...");
//                 File.Create(@"MedicalStore\FileHandling\user.CSV");
//             }
//             else
//             {
//                 System.Console.WriteLine("File Already Exists");
//             }

            
//         }
   
// //     public static void WriteToCSV()
// //     {
// //         string [] users = new string[Operations.userList.Count];
// //         for(int i = 0;i<Operations.userList.Count;i++)
// //         {
// //             users[i]=Operations.userList[i].UserID+","+
// //         }
// //     }
   
   
   
// //     }
// // }