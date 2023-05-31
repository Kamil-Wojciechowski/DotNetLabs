using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie04
{
    internal class OsobaDTO
    {
        private Dictionary<string, Osoba> baza = new Dictionary<string, Osoba>();

        public void DodajOsobe(string pesel, Osoba osoba)
        {
            if (!baza.ContainsKey(pesel))
            {
                baza.Add(pesel, osoba);
            }
        }

        public void UsunOsobe(string pesel)
        {
            baza.Remove(pesel);
        }

        public Osoba ZnajdzOsobe(string pesel)
        {
            Osoba osoba;
            baza.TryGetValue(pesel, out osoba);
            return osoba;
        }
    }
}
