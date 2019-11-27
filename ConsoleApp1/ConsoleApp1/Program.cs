using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            String v = string.Empty;
            double a = double.NaN;
            double sq = double.NaN;
            int n = 0;
            Console.WriteLine("Please select Round or Square");
            Console.WriteLine("Input r for round or s for square");
            v = Convert.ToString(Console.ReadLine());
            if (n < 3)
            {
                Console.WriteLine("Input lenght");
                //a = Convert.ToDouble();
                While (double.TryParse(Console.ReadLine(), out a) != true){ };
                n++;
            }
            else { a = Random(0.5, 5); 
            }
            
            switch (v)
            {
                case "r": sq = Math.PI * Math.Pow(a, 2);
                    break;
                case "s": sq = Math.Pow(a, 2);
                    break;
            }
            Console.WriteLine("The sqare is equal to " + sq);
        }

        private static double Random(double v1, double v2)
        {
            throw new NotImplementedException();
        }
    }
}
