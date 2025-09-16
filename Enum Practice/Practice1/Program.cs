using System.ComponentModel;

namespace EnumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create an Enum called "WeekDay" with the days of the week(Monday to Sunday)
            //as its members.Then, write a C# program that prints out all the days of the week using this Enum.

            foreach(WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine(day);
            }




        }
    }
}
