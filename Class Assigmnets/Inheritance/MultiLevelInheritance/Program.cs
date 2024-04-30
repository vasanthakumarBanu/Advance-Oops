using System;
namespace SingleInheritance;
class Program
{
    public static void Main(string[] args)
    {
      PersonelDetails data = new PersonelDetails("vasanthakuamr","Banukuamr",Gender.Male,"8110877339");

        System.Console.WriteLine($"PErsonel ID:{data.UserID}|{data.Name}|{data.FatherName}|{data.Gender}|{data.PhoneNumber}");
        StudentDetails student = new StudentDetails(data.Name,data.FatherName,data.Gender,data.PhoneNumber,5,"2012");
    }
}