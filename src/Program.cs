namespace Exercise012
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintFromNumberToOne(5);
        }
        public static void PrintFromNumberToOne(int goal)
        {
            Console.WriteLine($"Printing numbers from {goal} to zero!");

            while (goal >= 1)
            {
                Console.WriteLine(goal);
                goal = goal - 1;
            }

            Console.WriteLine("Done!");
        }
    }
}
