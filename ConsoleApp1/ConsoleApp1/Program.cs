namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
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
    }

    static int CalculateAverage(int[] values)
    {
        return (values.Sum() / values.Length);
    }
}