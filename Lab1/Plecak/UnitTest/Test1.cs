using Plecak;
namespace UnitTest
{
    [TestClass]
    public sealed class Testowanie
    {
        [TestMethod]
        // Jeśli co najmniej jeden przedmiot istnieje - zwrócono co najmniej jeden element
        public void OneItemFits()
        {
            Problem problem = new Problem(10, 1);
            Result result = problem.Solve(10);
            Assert.IsTrue(result.IdPrzedmiotow.Count >= 1);
        }
        [TestMethod]
        // Jeśli pojemność jest zerowa - zwrócono zero elementów
        public void NoItemsFit()
        {
            Problem problem = new Problem(10, 1);
            Result result = problem.Solve(0);
            Assert.IsTrue(result.IdPrzedmiotow.Count == 0);
        }
        [TestMethod]
        // Dla tego samego seeda, suma wartości powinna być zawsze taka sama
        public void CheckCorrection()
        {
            Problem problem = new Problem(10, 100);
            Result result = problem.Solve(30);
            Assert.AreEqual(51, result.SumWartosc);
        }
        [TestMethod]
        // Sprawdzanie czy algorytm bierze bardziej cenny przedmiot
        public void CheckPriority()
        {
            Problem problem = new Problem(2, 1);
            problem.ListaPrzedmiotow.Clear();
            problem.ListaPrzedmiotow.Add(new Przedmiot(0, 10, 10)); // Przedmiot o wysokiej wartości, ale dużej wadze
            problem.ListaPrzedmiotow.Add(new Przedmiot(1, 8, 1)); // Przedmiot o niższej wartości, ale małej wadze

            var result = problem.Solve(10);
            Assert.AreEqual(8, result.SumWartosc);
            Assert.AreEqual(1, result.IdPrzedmiotow[0]);
        }
        [TestMethod]
        // Test dla ujmenej pojemności
        public void NegativeCapacity()
        {
            Problem problem = new Problem(10, 1);
            Result result = problem.Solve(-5);
            Assert.IsTrue(result.IdPrzedmiotow.Count == 0);
        }
    }
}
