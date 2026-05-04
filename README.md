# Lab 1 - problem plecakowy
<details>
<summary>Opis zadania</summary>
  
## Wymagania zadania:
- implementacja problemu plecakowego w języku C#
- rozdzielenie poszczególnych klas na osobne pliki, dla lepszej czytelności i struktury kodu
- implementacja testów jednostkowych, sprawdzających poprawność implementacji
- utworzenie graficznego interfejsu do całego zadania
  
## Podział plików:
- [Program.cs](Lab1/Plecak/Plecak/Program.cs) - główny plik wykonawczy
- [Plecak.cs](Lab1/Plecak/Plecak/Plecak.cs) - klasa opisująca strukturę plecaka
- [Problem.cs](Lab1/Plecak/Plecak/Problem.cs) - klasa zawierająca listę przedmiotów, generator przedmiotów wykorzystujący seed oraz algorytm zachłanny
- [Result.cs](Lab1/Plecak/Plecak/Result.cs) - klasa zawierająca wartości rozwiązania zadania

## Testy jednostkowe

Zawarte w pliku [Test1.cs](Lab1/Plecak/UnitTest/Test1.cs), sprawdzają poprawne działanie algorytmu w 5 różnych sytuacjach:
- jeśli jeden przedmiot istnieje
- jeśli nie ma żadnego przedmiotu
- powtarzalność wyniku wybranego seeda
- sprawdzanie pierwszeństwa
- ujemna pojemność

## GUI

Całość interfejsu została zaprojektowana przy użyciu Windows Forms App.

</details>

# Lab 2 - Web API i Maui
<details>
<summary>Opis zadania</summary>

## Wymagania zadania:
- komunikacja z wybranym API (w tym przypadku OpenWeather) w celu pobrania danych oraz ich deserializacji,
- proste operacje bazodanowe - dodawanie, usuwanie, pokazywanie,
- utworzyć prostą aplikację przy pomocy interfejsu MAUI.

## Podział plików:
### Baza danych:
- [Program.cs](Lab2/API/Program.cs) - główny plik wykonawczy,
- [Commands.cs](Lab2/API/Commands.cs) - definicja operacji bazodanowych,
- [db.cs](Lab2/API/db.cs) - inicjalizacja bazy danych,
- [Class1.cs](Lab2/API/Class1.cs) - call do serwera API, deserializacja JSON oraz zapis wyników do pliku,
- [Class2.cs](Lab2/API/Class2.cs) - klasa zawieracjąca definicję modelu danych ToDo.
### MAUI:
- [db.cs](Lab2/Maui_API/db.cs) - inicjalizacja bazy danych,
- [ToDo.cs](Lab2/Maui_API/ToDo.cs) - definicja modelu danych,
- [MainPage.xaml](Lab2/Maui_API/MainPage.xaml) - plik odpowiadający za wygląd aplikacji,
- [MainPage.xaml.cs](Lab2/Maui_API/MainPage.xaml.cs) - główna logika programu - pobieranie danych z serwera oraz ich zapis do pliku bazy danych.
## Funkcjonalność:
- pobieranie informacji o aktualnej temperaturze, warunkach pogodowych oraz wilgotności wybranego miasta,
- deserializacja odpowiedzi JSON,
- możliwość wyświetlenia bazy danych, dodania oraz usunięcia wskazanego rekordu.
</details>

# Lab 3 - Obliczenia wielowątkowe
<details>
  <summary> Opis zadania </summary>
  Całośc aplikacji została zrobiona w Microsoft Formsach. Dzięki użyciu UserControlów, wszystkie 3 zadania są zawarte w jednym projekcie w jednej aplikacji okienkowej, gdzie wybór zadania jest wyraźnie widoczny po lewej stronie aplikacji.
  
  ## Wymagania zadania:
  - użycie biblioteki Parrarel w celu porównania szybkości wykonywania obliczeń - sekwencyjnie a wielowątkowo,
  - porównanie szybkości wykonywania obliczeń między biblioteką Parrarel a własnoręcznie utworzonymi wątkami,
  - wykorzystanie dowolnej metody wielowątkowości w celu zrobiania aplikacji, pozwalającej na przetwaerzanie obrazów (nakładanie filtrów)

  ## Podział plików:
  - [Matrix.cs](Lab3/Macierze/Matrix.cs) - klasa odpowiadająca za obliczenia wykonywane na macierzach - posiada funkcję mnożenia wykonaną na bibliotece Parrarel oraz przy użyciu własnoręcznie wydzielonych wątków,
  - [Images.cs](Lab3/Macierze/Images.cs) - klasa odpowiadająca za przetwarzanie obrazów do zadania 3 - zostały zdefiniowane 4 filtry: Negatyw, odcienie szarości, czarno-biały, tylko odcienie zielonego,

  ## Funkcjonalność:
  - kompaktowość - wszystkie 3 zadania w jednej aplikacji,
  - szybkie przetwarzanie obrazów,
  - ręczny dobór ilości przydzielonych wątków do zadania 1 oraz 2,
  - ręczny dobór wielkości macierzy dla zadania 1 oraz 2.

  ## Porównanie wyników:
  
</details>
