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

                // Decrease goal by 1 (same as goal = goal - 1)
                goal--;
            }

            Console.WriteLine("Done!");
        }
    }
}
