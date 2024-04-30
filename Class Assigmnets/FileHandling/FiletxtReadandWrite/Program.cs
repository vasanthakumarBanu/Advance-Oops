using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        if (!Directory.Exists("TextFolder"))
        {
            System.Console.WriteLine("Creating Folder");
            Directory.CreateDirectory("Test Folder");
        }
        else
        {
            System.Console.WriteLine("Directory exists");
        }
        if (!File.Exists(@"D:\SyncFusion\Phase-III\Class Assigmnets\FileHandling\FiletxtReadandWrite\Test Folder\MyFile.txt"))
        {
            System.Console.WriteLine("Creating file...");
            File.Create(@"D:\SyncFusion\Phase-III\Class Assigmnets\FileHandling\FiletxtReadandWrite\Test Folder\MyFile.txt").Close();
        }
        else { System.Console.WriteLine("File already exists"); }

        System.Console.WriteLine("Select\n1.Read from file\n2.Write to file");
        int option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                {
                    StreamReader sr = new StreamReader(@"D:\SyncFusion\Phase-III\Class Assigmnets\FileHandling\FiletxtReadandWrite\Test Folder\MyFile.txt");
                    string data = sr.ReadLine();
                    while (data != null)
                    {
                        System.Console.WriteLine(data);
                        data = sr.ReadLine();

                    }
                    sr.Close();
                    break;
                }
            case 2:
                {
                    string[] contents = File.ReadAllLines(@"D:\SyncFusion\Phase-III\Class Assigmnets\FileHandling\FiletxtReadandWrite\Test Folder\MyFile.txt");
                    StreamWriter sw = new StreamWriter(@"D:\SyncFusion\Phase-III\Class Assigmnets\FileHandling\FiletxtReadandWrite\Test Folder\MyFile.txt");

                    System.Console.WriteLine("Enter what you want to place in the file");
                    string data = Console.ReadLine();
                    string old = "";
                    foreach (string line in contents)
                    {
                        old = old + line + "\n";

                    }
                    old = old + data;
                    sw.WriteLine(old);
                    sw.Close();
                    System.Console.WriteLine(old);

                    break;
                }
        }

    }
}