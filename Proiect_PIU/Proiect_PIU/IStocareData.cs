using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proiect_PIU
{
    public interface IStocareData
    {
        void AdaugaPersoana(Persoana p);
        List<Persoana> GetPersoana();
        bool UpdatePersoana(Persoana persoanaActualizata);
    }
}
