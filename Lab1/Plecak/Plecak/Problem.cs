using System;
namespace Plecak
{
	internal class Problem
	{
		public int LiczbaPrzedmiotow { get; set; }
		public List<Przedmiot> ListaPrzedmiotow { get; set; }
		public Problem(int n, int seed)
		{
			LiczbaPrzedmiotow = n;
			ListaPrzedmiotow = new List<Przedmiot>();
			Random random = new Random(seed);
			for (int i = 0; i < n; i++)
			{
				int id = i;
				int wartosc = random.Next(1, 10);
				int waga = random.Next(1, 10);
				ListaPrzedmiotow.Add(new Przedmiot(i, wartosc, waga));
			}
		}
		public override string ToString()
		{
			return string.Join(Environment.NewLine, ListaPrzedmiotow);
        }
        public Result Solve(int capacity)
        {
            Result wynik = new Result();
            var posortowane = ListaPrzedmiotow
                .OrderByDescending(p => (double)p.Wartosc / p.Waga)
                .ToList();

            foreach (var p in posortowane)
            {
                if (wynik.SumWaga + p.Waga <= capacity)
                {
                    wynik.IdPrzedmiotow.Add(p.Id);
                    wynik.SumWaga += p.Waga;
                    wynik.SumWartosc += p.Wartosc;
                }
            }

            return wynik;
        }
	}
}
