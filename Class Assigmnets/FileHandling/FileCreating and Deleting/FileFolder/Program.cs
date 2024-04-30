using System;
using System.Data.Common;
using System.IO;
using System.Runtime.ConstrainedExecution;
namespace FileFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\VasanthakumarBanukum\OneDrive - Syncfusion\Desktop\MyFolder";
        string folderPath = path + "/Vasanthakumar";
        if (!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("CreatingFolder...");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Folder already exists");
        }
        string filepath = path + "/myFile.txt";
        if (!File.Exists(filepath))
        {
            System.Console.WriteLine("Creating file ......");
            File.Create(filepath);
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }
        System.Console.WriteLine("Select\n1.Create Folder\n2.create File\n3.Delete Folder\n4.Delete file");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    System.Console.WriteLine("Enter the Folder name to create:");
                    string folder = Console.ReadLine();
                    string newPath = path + "/" + folder;
                    if (!Directory.Exists(newPath))
                    {
                        System.Console.WriteLine("Creating folder ...");
                        Directory.CreateDirectory(newPath);
                    }
                    else
                    {
                        System.Console.WriteLine("Folder already Exists");
                    }
                    break;
                }
            case 2:
                {
                    System.Console.WriteLine("Enter the File name you want to create ");
                    string fileName = Console.ReadLine();
                    System.Console.WriteLine("Enter the file extension");
                    string extension = Console.ReadLine();
                    string newFilePath = path + "/" + fileName + "." + extension;
                    if (!File.Exists(newFilePath))
                    {
                        System.Console.WriteLine("Creating file" + fileName + "." + extension);
                        File.Create(newFilePath);
                    }
                    else
                    {
                        System.Console.WriteLine("File already exists");
                    }
                    break;
                }
            case 3:
                {
                    foreach (string path1 in Directory.GetDirectories(path))
                    {
                        System.Console.WriteLine(path1);
                    }
                    System.Console.WriteLine("Select the folder wish to remove");
                    string folder1 = Console.ReadLine();
                    foreach (string path1 in Directory.GetDirectories(path))
                    {
                        if (path1.Contains(folder1))
                        {
                            System.Console.WriteLine("Removing folder......" +folder1);
                            Directory.Delete(path1);
                        }
                    }
                    break;
                }
            case 4:
                {
                    foreach(string file1 in Directory.GetFiles(path) )
                    {
                        System.Console.WriteLine(file1);
                    }
                    System.Console.WriteLine("Enter the name and extendions to be removed");
                    string file2 = Console.ReadLine();
                    foreach(string file1 in Directory.GetFiles(path))
                    {
                        if(file1.Contains(file2))
                        {
                            System.Console.WriteLine("Removing files...."+file2);
                            File.Delete(file1);
                        }
                    }
                    break;
                }


        }
    }
}


