using System;

namespace Task_3._7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your name");
            byte age = (byte)int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite day of week?");
            DaysOfWeek day = (DayOfWeek) int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);
            Console.ReadKey();
        }
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Sateday,
            Sunday
        }
    }
    

}
