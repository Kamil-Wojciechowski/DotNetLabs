namespace Zadanie04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OsobaDTO baza = new OsobaDTO();

            Osoba osoba1 = new Osoba { Imie = "Jan", Nazwisko = "Kowalski", Adres = "ul. Testowa 1", NumerTelefonu = "123456789" };
            Osoba osoba2 = new Osoba { Imie = "Anna", Nazwisko = "Nowak", Adres = "ul. Testowa 2", NumerTelefonu = "987654321" };

            baza.DodajOsobe("12345678901", osoba1);
            baza.DodajOsobe("98765432101", osoba2);

            Osoba szukanaOsoba = baza.ZnajdzOsobe("12345678901");
            if (szukanaOsoba != null)
            {
                Console.WriteLine("Znaleziono osobę: " + szukanaOsoba.Imie + " " + szukanaOsoba.Nazwisko);
            }

            baza.UsunOsobe("12345678901");
        }
    }
}