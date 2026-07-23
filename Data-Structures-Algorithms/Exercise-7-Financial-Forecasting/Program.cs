using System;

class Program
{
    // Recursive method to calculate future value
    static double FutureValue(double currentValue, double growthRate, int years)
    {
        // Base Case
        if (years == 0)
        {
            return currentValue;
        }

        // Recursive Call
        return FutureValue(currentValue * (1 + growthRate), growthRate, years - 1);
    }

    static void Main(string[] args)
    {
        double presentValue = 10000;
        double growthRate = 0.10;   //10%
        int years = 5;

        double future = FutureValue(presentValue, growthRate, years);

        Console.WriteLine("Present Value : " + presentValue);
        Console.WriteLine("Growth Rate   : " + (growthRate * 100) + "%");
        Console.WriteLine("Years         : " + years);
        Console.WriteLine("Future Value  : " + future);
    }
}