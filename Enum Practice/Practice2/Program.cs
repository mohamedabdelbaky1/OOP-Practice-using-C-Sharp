namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2-Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season.
            //Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)


            bool IsParsed;
            Seasons season;
            do
            {
                Console.WriteLine("Please enter the Season Name : ");                
                IsParsed = Enum.TryParse(Console.ReadLine().ToUpper(), out season);
            } while (!IsParsed);
            switch(season)
            {
                case Seasons.AUTUMN :
                    Console.WriteLine("September to November");
                    break;
                case Seasons.SUMMER:
                    Console.WriteLine("June to August");
                    break;
                case Seasons.SPRING:
                    Console.WriteLine("March to May");
                    break;
                case Seasons.WINTER:
                    Console.WriteLine("December to February");
                    break;
            }
        }
    }
}
