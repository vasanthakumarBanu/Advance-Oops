using System;
namespace List;
class Program
{
    // create List as generic
    public static void Main(string[] args)
    {
        CustomList<int> numberList = new CustomList<int>();
       //Adding extra space in array
        numberList.Add(10);
        numberList.Add(20);
        numberList.Add(30);
        numberList.Add(40);
        numberList.Add(50);
        numberList.Add(60);
        System.Console.WriteLine(numberList.Capacity);
        numberList.Add(10); 
        numberList.Add(1);
        numberList.Add(111);
        CustomList<int> numbers = new CustomList<int>();
        numbers.Add(60);
        numbers.Add(70);
        numbers.AddRange(numbers);

        for(int i = 0;i<numberList.Count;i++)
        {
            System.Console.WriteLine(numberList[i]);
        }
        foreach(int value in numbers)
        {
            System.Console.WriteLine(value);
        }
        bool result = numberList.Contains(40);
        System.Console.WriteLine(result);
        int position = numberList.IndexOf(40);
        System.Console.WriteLine(position);
         numberList.Insert(2,30);
         numberList.RemoveAt(3);
         bool temp = numberList.Remove(40);   
         numberList.Revers(); 

    
    }
}