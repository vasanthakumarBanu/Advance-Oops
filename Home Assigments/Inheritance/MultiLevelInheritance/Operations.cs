using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public static  class Operations
    {
        public static List<StudentInfo> studentList = new List<StudentInfo>();
        public static List<HSCDetails> hscList = new List<HSCDetails>();
        public static void Mainmenu()
        {
            
            System.Console.WriteLine("Select the optionn\n1.ShowInfo\n3.GetMakrs,\n4.Calculate\n5.ShowMarksheet");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    StudentInfo.ShowInfo();
                    break;
                }

                case 1:
                {
                    StudentInfo.ShowInfo();
                    break;
                }
            }
        }

        public static void  AddingData()
        {
            StudentInfo student1 = new StudentInfo("Bharani", "Banukumar", "8110877339", "Vasanthbanukumar@gmail.com", new DateTime(1997, 07, 18), Gender.Male, 12, "CSC", new DateTime(2015));
            StudentInfo student2 = new StudentInfo("Sarika", "Abirami", "9500404040", "Babucat@gmail.com", new DateTime(1997, 01, 03), Gender.Female, 12, "CSC", new DateTime(2015));
            studentList.AddRange(new List<StudentInfo>{student1,student2});


            HSCDetails mark1 = new HSCDetails(student1.RegisterNumber,"Bharani", "Banukumar", "8110877339", "Vasanthbanukumar@gmail.com", new DateTime(1997, 07, 18), Gender.Male, 12, "CSC", new DateTime(2015),student1.);
            
        }

    }
}