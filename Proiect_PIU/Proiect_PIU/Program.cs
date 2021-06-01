using System.Windows.Forms;

namespace Proiect_PIU
{
    class Program
    {   //tema 1+tema 2: Fisierele Program.cs si Persoana.cs
        //tema 3: Fisierele IStocareData.cs(interfata) si StocareData.cs
        //tema 4: Fisierul Enumerari.cs( pentru folosirea enum) si StocareData.cs(pentru folosire liste)
        //tema 5: Fisierul Form1.cs
        //tema 6: Fisierul Form1.cs(radio button)
        static void Main(string[] args)

        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Proiect_PIU.Form1());
            /*string nume, numar_telefon, email,zi;
            string opt;
            bool yes=true;
            List<Persoana> sir_persoane = new List<Persoana>();
            
            do
            {
                //Console.Clear();
                Console.WriteLine("A. Adaugare");
                Console.WriteLine("B. Afisare");
                Console.WriteLine("C. Cautare dupa nume");
                Console.WriteLine("D. Stergere persoana");
                Console.WriteLine("X. Iesire program");
                Console.WriteLine("Introduceti optiunea");
                opt = Console.ReadLine();
                //Console.Clear();
                switch (opt)
                {
                    case "A":
                        do
                        {
                            
                            Console.WriteLine("Introduceti numele");
                            nume = Console.ReadLine();
                            Console.WriteLine("Introduceti ziua de nastere");
                            zi = Console.ReadLine();
                            Console.WriteLine("Introduceti numarul de telefon");
                            numar_telefon = Console.ReadLine();
                            Console.WriteLine("Introduceti adresa de email");
                            email = Console.ReadLine();
                            Persoana p = new Persoana(nume, numar_telefon, email,zi);
                            sir_persoane.Add(p);
                            Console.WriteLine("Doriti sa mai adaugati o persoana? D/N");
                            string c=Console.ReadLine();
                            if (c != "D")
                            {
                                yes = false;
                            }
                        }while (yes == true);
                        break;
                    case "B":
                        Console.WriteLine("Nume\tZi nastere\tNr. telefon\tEmail");
                        foreach (Persoana pers  in sir_persoane)
                        {
                            string sir = pers.ConversieLaSir();
                            Console.WriteLine(sir);
                        }
                        break;
                    case "C":

                        string nume_cautat;
                        Console.WriteLine("Introduceti numele cautat: ");
                        nume_cautat = Console.ReadLine();
                        bool ok = false;
                        foreach (Persoana p in sir_persoane)
                        {
                            if (p.Cautare(nume_cautat)==true)
                            {
                                Console.WriteLine("Persoana a fost gasita!");
                                Console.WriteLine(p.ConversieLaSir());
                                ok = true;
                                break;
                            }
                        }
                        if (ok == false)
                            Console.WriteLine("Persoana cautata nu a fost gasita");
                        break;
                    case "D":
                        string nume_sters;
                        Console.WriteLine("Introduceti numele care va fi sters: ");
                        nume_sters = Console.ReadLine();
                        foreach(Persoana p in sir_persoane)
                        {
                            if(p.Cautare(nume_sters)==true)
                            {
                                sir_persoane.Remove(p);
                            }
                            foreach (Persoana pers in sir_persoane)
                            {
                                string sir = pers.ConversieLaSir();
                                Console.WriteLine(sir);
                            }

                        }
                        break;
                    default:
                        Console.WriteLine("Optiune invalida");
                        break;

                }
            } while (opt !="X");
            Console.ReadKey();*/
        }


    }
}