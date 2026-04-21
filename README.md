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
