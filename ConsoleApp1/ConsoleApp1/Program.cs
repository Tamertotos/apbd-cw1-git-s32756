namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rebased 2 branches");
        Console.WriteLine("Non fast-forward merge completed");
        Console.WriteLine("Another main branch commit before non fast-forward merging");
        Console.WriteLine("Fast forward merge");
        Console.WriteLine("Hello, World!");

        var b = 5;

        if (b > 10)
        {
            Console.WriteLine(b + " is bigger than 10");
        }
        else
        {
            Console.WriteLine(b + " is smaller than 10");
        }

        int[] x = { 3, 4 };
        Console.WriteLine("Average value of the array is: " + CalculateAverage(x));
        Console.WriteLine("The maximum value in the array is: " + CalculateMax(x));
        Console.WriteLine("The minimum value in the array is: " + CalculateMin(x));
        Console.WriteLine("Hello");
    }

    static int CalculateAverage(int[] values)
    {
        return (values.Sum() / values.Length);
    }

    static int CalculateMax(int[] values)
    {
        return values.Max();
    }

    static int CalculateMin(int[] values)
    {
        return values.Min();
    }
}