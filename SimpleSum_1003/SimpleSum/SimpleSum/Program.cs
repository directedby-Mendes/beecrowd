namespace SimpleSum;

public class Program
{

    public static void Main(string[] args)
    {
        double a, b, c, m;
        a = Convert.ToDouble(Console.ReadLine());
        b = Convert.ToDouble(Console.ReadLine());
        c = Convert.ToDouble(Console.ReadLine());
        m = ((a * 2 + b * 3 + c * 5) / (2 + 3 + 5));
        Console.WriteLine("Media = " + m.ToString("f1"));

        Console.ReadKey();
    }
}