using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Proiect_PIU
{
    public class StocareDate : IStocareData
    {
        string NumeFisier { get; set; }
        public StocareDate(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }
        public void AdaugaPersoana(Persoana p)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(p.ConversieLaSir());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public List<Persoana> GetPersoana()
        {
            List<Persoana> sir_persoane = new List<Persoana>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Persoana pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Persoana persDinFisier = new Persoana(line);
                        sir_persoane.Add(persDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return sir_persoane;
        }
        public bool UpdatePersoana(Persoana persoanaActualizata)
        {
            // throw new NotImplementedException();
            List<Persoana> sir_p = GetPersoana();
            bool actualizareCuSucces = false;
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Persoana pers in sir_p)
                    {
                        Persoana persoanaPentruScrisInFisier = pers;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "persoanaActualizata" 
                        if (pers.Nume == persoanaActualizata.Nume)
                        {
                            persoanaPentruScrisInFisier = persoanaActualizata;
                        }
                        swFisierText.WriteLine(persoanaPentruScrisInFisier.ConversieLaSir());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }
    }
}
