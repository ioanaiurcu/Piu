using System;

namespace Proiect_PIU
{
    public class Persoana
    {

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Nr_telefon { get; set; }
        public string Email { get; set; }
        public string Zi_Nastere { get; set; }
        public Enumerari Cadru { get; set; }

        public Persoana()
        {
            Nume = String.Empty;
            Prenume = String.Empty;
            Nr_telefon = String.Empty;
            Email = String.Empty;
            Zi_Nastere = String.Empty;
        }
        public Persoana(string nume=" ", string prenume=" ", string telefon=" ", string email=" ", string zi=" ")
        {
            Nume = nume;
            Prenume = prenume;
            Nr_telefon = telefon;
            Email = email;
            Zi_Nastere = zi;
        }
        public Persoana(string sir)
        {

        }
        public string GetNume()
        {
            return Nume;
        }
        public string ConversieLaSir()
        {
            //string sir = Nume + " " + Nr_telefon + " " + Email;
            //return sir;
            return $"{Nume} {Prenume}\t{Zi_Nastere}\t{Nr_telefon}\t{Email}";

        }
        public bool Cautare(string name)
        {
            bool ok = false;
            if (this.GetNume() == name)
            {
                Console.WriteLine("Persoana a fost gasita!");
                Console.WriteLine(this.ConversieLaSir());
                ok = true;

            }
            return ok;
        }
    }
}
