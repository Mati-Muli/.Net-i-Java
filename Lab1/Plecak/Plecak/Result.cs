using System;
using System.Collections.Generic;
using System.Text;

namespace Plecak
{
    internal class Result
    {
        public List<int> IdPrzedmiotow { get; set; } = new List<int>();
        public int SumWartosc { get; set; }
        public int SumWaga { get; set; }

        public override string ToString()
        {
            return "Przedmioty: " + string.Join(", ", IdPrzedmiotow) + Environment.NewLine +
            "Suma wartosci: " + SumWartosc + Environment.NewLine +
            "Suma wagi: " + SumWaga;
        }
    }
}
