namespace API
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            API api = new API();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Wybierz opcję:");
                Console.WriteLine("1. Dodaj | 2. Pokaż bazę danych | 3. Usuń element | 0. Wyjdź");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await api.GetData();
                        break;
                    case "2":
                        Commands.ShowDatabase();
                        break;
                    case "3":
                        Commands.DeleteRecord();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa opcja.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine("\nNaciśnij dowolny klawisz, aby kontynuować..");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}