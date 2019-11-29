using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            String user_decision = string.Empty;
            double a = 0.00;
            double sq = 0.00;
            Random random = new Random();
            double random_value = random.Next(1, 5);
            int temp_counter = 0;
            Console.WriteLine("Please select Round or Square");
            Console.WriteLine("Input r for round or s for square");
            user_decision = Convert.ToString(Console.ReadLine());
            
            if (temp_counter < 3 && double.TryParse(Console.ReadLine(), out _))
            {
                Console.WriteLine("Please , input a number");
                a = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);
                temp_counter++;
            }
            else { a = random_value; }


            switch (user_decision)
            {
                case "r":
                    sq = Math.Round(Math.PI * Math.Pow(a, 2), 2);
                    break;
                case "s":
                    sq = Math.Round(Math.Pow(a, 2), 2);
                    break;
            }
            Console.WriteLine("The sqare is equal to " + sq);
        }
    }
}
