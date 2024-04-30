using System;
using SingleinHeritance;
class Program
{
    public static void Main(string[] args)
    {
        PersonelInfo data = new PersonelInfo("Vasanthakumar","Banukumar","8110877339",DateTime.ParseExact("18/07/1997","dd/MM/yyyy",null),Gender.Male);
        StudentInfo student = new StudentInfo(data.Name,data.FatherName,data.PhoneNumber,data.DOB,data.Gender,5,"Computerscience","2012");
        System.Console.WriteLine($"PErsonel ID:{student.Name}|{student.FatherName}|{student.PhoneNumber}|{student.DOB}|{student.Gender}|{student.Standard}|{student.Branch}|{student.AcademicYear}|");
    

    }
}