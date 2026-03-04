namespace ConsoleApp1
{
    internal class Program
    {
        public class FizzBuzz()
        {
            public void FizzBuzze(int z)
            {
                for (int i = 1; i <= z; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj zakres");
            int zakres = int.Parse(Console.ReadLine());
            FizzBuzz fb = new FizzBuzz();
            fb.FizzBuzze(zakres);


        }
    }
}

