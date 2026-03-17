using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("UnitTest"), InternalsVisibleTo("GUI")]
namespace Plecak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe przedmiotow:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\nPodaj seed:");
            int seed = int.Parse(Console.ReadLine());
            Problem problem = new Problem(n, seed);
            Console.WriteLine("\nWygenerowane itemy:");
            Console.WriteLine(problem.ToString());
            Console.WriteLine("\nPodaj pojemnosc plecaka:");
            int capacity = int.Parse(Console.ReadLine());
            Result result = problem.Solve(capacity);
            Console.WriteLine("\nWyniki:");
            Console.WriteLine(result.ToString());
        }
    }
}
