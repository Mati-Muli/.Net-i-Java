using System;
namespace Plecak
{
    internal class Przedmiot
    {
        public int Id { get; set; }
        public int Wartosc { get; set; }
        public int Waga { get; set; }

        public Przedmiot(int id, int wartosc, int waga)
        {
            Id = id;
            Wartosc = wartosc;
            Waga = waga;
        }
        public override string ToString()
        {
            return $"no.: {Id} v: {Wartosc} w: {Waga} ";
        }
    }
}
