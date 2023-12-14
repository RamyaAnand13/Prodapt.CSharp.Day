namespace Prodapt.CSharp.Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Now;
            Console.WriteLine($"Today:{today}");
            Console.WriteLine($"DateTime:{today.ToShortDateString()}");
            Console.WriteLine($"DateOnly:{DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"TimeOnly:{today.ToShortTimeString}");
            Console.WriteLine($"TimeOnly:{DateTime.Now.ToShortTimeString()}");
            Console.WriteLine($"LongDate:{today.ToLongDateString()}");
            Console.WriteLine($"LongTImeOnly:{today.ToLongTimeString()}");
        }
    }
}
