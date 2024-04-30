using System;
namespace HierarchicalInheritance;
class Program
{
    public static void Main(string[] args)
    {
      PersonelDetails data = new PersonelDetails("vasanthakuamr","Banukuamr",Gender.Male,"8110877339");

        System.Console.WriteLine($"Personel ID:{data.UserID}|{data.Name}|{data.FatherName}|{data.Gender}|{data.PhoneNumber}");
        StudentDetails student = new StudentDetails(data.Name,data.FatherName,data.Gender,data.PhoneNumber,5,"2012");
        CustomerDetails customer = new CustomerDetails(1000,"vasanthakuamr",data.UserID,"Banukuamr",Gender.Male,"8110877339");
        System.Console.WriteLine($"Customer ID:{data.UserID}|{data.Name}|{data.FatherName}|{data.Gender}|{data.PhoneNumber}");
    }
}