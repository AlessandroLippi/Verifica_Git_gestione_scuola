using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git_Gestione_Scuola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            alunno a = new alunno("Matteo", "Rossi", "Meldola", 17);
            Scuola s = new Scuola("Ed mondo de amicis", "Via cavour 14", "dal lunedi al sabato dalle 7:55-13:00; 14:30-16:30");


            a.ToStringAlunno();
            s.AggiungiAlunno(a);
            s.RicercaPerEtà();
            s.RicercaPerCognome();
            s.AlunniPresenti();

            Console.ReadKey();

        }
    }
}
