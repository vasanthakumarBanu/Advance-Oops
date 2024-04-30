using System;
namespace ByType;
public class Program
{
    public static void Main(string[] args)
    {
        //Add method addn integer
       int result = Add(1,2);
        string result1 = Add("kkk","kkkk");
      
    }
    public static int Add(int a,int b)
    {
        return a+b;
    }

    public static string Add(string a,string b)
    {
        return a+b;
    }
}