namespace CSharp;

internal class Program
{
    private static void One(int m, int n)
    {
        if (m * 60 + n <= 384)
            Console.WriteLine("поместится");
        else
            Console.WriteLine("не поместится");
    }


    private static void Two(int[] m)
    {
        var result = 1;
        for (var i = 0; i < m.Length - 1; i++)
            if (m[i] + m[i + 1] <= 50)
                m[i + 1] += m[i];
            else
                result++;
        Console.WriteLine(result);
    }


    private static void Three(int m, int n)
    {
        var result = 0;
        for (var i = m; i <= n; i++)
            if (i / 100000 + i / 10000 % 10 + i / 1000 % 10 == i / 100 % 10 + i / 10 % 10 + i % 10)
                result++;
        Console.WriteLine(result);
    }


    private static void Four(int n)
    {
        for (var y = 0; y <= n / 5; y++)
        {
            var x = (n - 5 * y) / 3;
            if (3 * x + 5 * y == n)
                Console.WriteLine(x + " " + y);
        }
    }


    private static void Main()
    {
        
    }
}