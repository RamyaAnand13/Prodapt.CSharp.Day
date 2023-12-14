using System;
using Prodapt.CSharp.Library;

namespace Prodapt.CSharp.Day4
{
    internal class Example
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Example1");
            Login obj = new Login();
            var result = obj.Validation("admin", "admin@123");
            Console.WriteLine(result ? "Valid User" : "Invalid User");
                }
    }
}
