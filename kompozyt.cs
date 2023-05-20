using System;
using System.Collections.Generic;

// Klasa abstrakcyjna reprezentująca osobę
abstract class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }

    public abstract void PrzedstawSie();
}

// Klasa reprezentująca Klienta
class Klient : Osoba
{
    public override void PrzedstawSie()
    {
        Console.WriteLine($"Jestem klientem o imieniu {Imie} {Nazwisko}.");
    }
}

// Klasa reprezentująca Pracownika
class Pracownik : Osoba
{
    public string Stanowisko { get; set; }

    public override void PrzedstawSie()
    {
        Console.WriteLine($"Jestem pracownikiem o imieniu {Imie} {Nazwisko} i pracuję jako {Stanowisko}.");
    }
}

// Klasa reprezentująca Sklep
class Sklep
{
    public string Nazwa { get; set; }
    public List<Pracownik> Pracownicy { get; set; }

    public Sklep()
    {
        Pracownicy = new List<Pracownik>();
    }

    public void DodajPracownika(Pracownik pracownik)
    {
        Pracownicy.Add(pracownik);
    }

    public void UsunPracownika(Pracownik pracownik)
    {
        Pracownicy.Remove(pracownik);
    }

    public void WyswietlPracownikow()
    {
        Console.WriteLine($"Pracownicy w sklepie {Nazwa}:");
        foreach (var pracownik in Pracownicy)
        {
            pracownik.PrzedstawSie();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektów
        var klient = new Klient { Imie = "Jan", Nazwisko = "Kowalski" };
        var pracownik1 = new Pracownik { Imie = "Anna", Nazwisko = "Nowak", Stanowisko = "Kasjerka" };
        var pracownik2 = new Pracownik { Imie = "Piotr", Nazwisko = "Kowalczyk", Stanowisko = "Sprzedawca" };

        var sklep = new Sklep { Nazwa = "Sklep ABC" };

        // Dodawanie pracowników do sklepu
        sklep.DodajPracownika(pracownik1);
        sklep.DodajPracownika(pracownik2);

        // Wyświetlanie informacji o pracownikach w sklepie
        sklep.WyswietlPracownikow();

        // Przedstawianie się klienta
        klient.PrzedstawSie();

        Console.ReadLine();
    }
}
