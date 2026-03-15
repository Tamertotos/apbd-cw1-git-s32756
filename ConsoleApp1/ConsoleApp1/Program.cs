namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Non fast-forward merge completed");
        Console.WriteLine("Another main branch commit before non fast-forward merging");
        Console.WriteLine("Fast forward merge");
        Console.WriteLine("Hello, World!");

        var a = 5;

        if (a > 10)
        {
            Console.WriteLine(a + " is bigger than 10");
        }
        else
        {
            Console.WriteLine(a + " is smaller than 10");
        }

        int[] x = { 3, 4 };
        Console.WriteLine("Average value of the array is: " + CalculateAverage(x));
        Console.WriteLine("The maximum value in the array is: " + CalculateMax(x));
        Console.WriteLine("Another line before rebase in main branch");
    }

    static int CalculateAverage(int[] values)
    {
        return (values.Sum() / values.Length);
    }

    static int CalculateMax(int[] values)
    {
        return values.Max();
    }
}