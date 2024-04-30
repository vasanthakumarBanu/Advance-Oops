using System;
using System.IO;
using System.Collections.Generic;
using FileWriting;
namespace ReadWite;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder"))
        {
            System.Console.WriteLine("Creating folder ...");
            Directory.CreateDirectory("TestFolder");
        }
        else
        {
            System.Console.WriteLine("Directory exists");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("Creating CSV file....");
            File.Create("TestFolder/Data.csv").Close();
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }

        //Json file Creation
        if(!File.Exists("TestFolder/Data1.json"))
        {
            System.Console.WriteLine("Creating JSON file...");
            File.Create("TestFolder/Data1.json").Close();
        }
        else
        {
            System.Console.WriteLine("JSON file already Exists");
        }
        List<Student> studentList = new List<Student>();
        studentList.Add(new Student(){Name = "Vasanth",FatherName="banukumar",DOB = new DateTime(1997,07,18),studentGender=Student.Gender.Male,TotalMark = 499});
        studentList.Add(new Student(){Name = "Ravi",FatherName="Mani",DOB = new DateTime(1997,07,18),studentGender=Student.Gender.Male,TotalMark = 479});
        studentList.Add(new Student(){Name = "Bharani",FatherName="banukumar",DOB = new DateTime(1997,07,18),studentGender=Student.Gender.Male,TotalMark = 459});
        studentList.Add(new Student(){Name = "Krisna",FatherName="Gujebathi",DOB = new DateTime(1997,07,18),studentGender=Student.Gender.Male,TotalMark = 429});
        WriteToCSV(studentList);
        ReadCSV();
    }
    static void WriteToCSV(List<Student>studentList)
    {
        StreamWriter sw =new StreamWriter("TestFolder/Data.csv");
        foreach(Student student in studentList)
        {
            string line = student.Name+","+student.FatherName+","+student.studentGender+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMark;
            sw.WriteLine(line);
        }
        sw.Close();    
    }
    static void ReadCSV()
    {
        List<Student> newList = new List<Student>();
        StreamReader sr = new StreamReader("TestFolder/Data.csv");
        String line = sr.ReadLine();
        while(line!=null)
        {
            string [] Values = line.Split(",");
            if(Values[0]!="")
            {
                Student student =  new Student()
                {
                    Name = Values[0],
                    FatherName = Values[1],
                    studentGender = Enum.Parse<Student.Gender>(Values[2]),
                    DOB = DateTime.ParseExact(Values[3],"dd/MM/yyyy",null),
                    TotalMark = int.Parse(Values[4])
                };
                newList.Add(student);
            }
            line = sr.ReadLine();
        }
        sr.Close();

        foreach(Student student in newList)
        {
            System.Console.WriteLine("NAME "+student.Name+" FatherName "+student.FatherName);
            System.Console.WriteLine(" Gender "+student.studentGender+" DOB "+student.DOB.ToString("dd/MM/yyyy",null)+" Marks "+student.TotalMark);
        }

   
    }
}