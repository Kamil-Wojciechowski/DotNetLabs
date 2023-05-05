using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie04
{
    public class Person
    {
        public Person() {}
        public Person(String Imie, String Nazwisko, int Wiek, long Pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Wiek = Wiek;
            this.Pesel = Pesel;
        }
        public long Pesel { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
    }
}
