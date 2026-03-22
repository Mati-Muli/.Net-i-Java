### Lab 1 - problem plecakowy
# Wymagania zadania:
- implementacja problemu plecakowego w języku C#
- rozpisanie kolejnych klas wykorzytanych w tym zadaniu w osobnych plikach
- implementacja testów jednostkowych, sprawdzających poprawność implementacji
- utworzenie graficznego interfejsu do całego zadania
# Podział plików:
- [Program.cs](Lab1/Plecak/Plecak/Program.cs) - główny plik wykonawczy
- [Plecak.cs](Lab1/Plecak/Plecak/Plecak.cs) - klasa opisująca strukturę plecaka
- [Problem.cs](Lab1/Plecak/Plecak/Problem.cs) - klasa zawierająca listę przedmiotów, generator przedmiotów wykorzystujący seeda oraz algorytm zachłanny
- [Result.cs](Lab1/Plecak/Plecak/Result.cs) - klasa zawierająca wartości rozwiązania zadania
# Testy jednostkowe

Zawarte w pliku [Test1.cs](Lab1/Plecak/UnitTest/Test1.cs), sprawdzają poprawne działanie algorytmu w 5 różnych sytuacjach:
- jeśli jeden przedmiot istnieje,
- jeśli nie ma żadnego przedmiotu,
- powtarzalność wyniku wybranego seeda,
- sprawdzanie pierwszeństwa,
- ujemna pojemność.

# GUI

Całość interfejsu została zaprojektowana przy użyciu Windows Froms App.
