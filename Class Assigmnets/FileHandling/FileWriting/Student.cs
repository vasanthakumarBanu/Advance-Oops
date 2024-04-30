using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileWriting
{
    public class Student
    {
        public enum Gender { slect, Male, Female, Transgender }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender studentGender { get; set; }
        public DateTime DOB { get; set; }
        public int TotalMark { get; set; }
    }
}