using System;
using AbstractClassesAndMethods;
class Program
{
    public static void Main(string[] args)
    {
        Employee job1 = new Syncfusion();
        job1.Name = "kemaki";
        System.Console.WriteLine(job1.Display());
        System.Console.WriteLine(job1.Salary(30));

       Employee job2 = new Zoho();
        job2.Name = "Chinshan";
        System.Console.WriteLine(job2.Display());
        System.Console.WriteLine(job2.Salary(30));
    }
}