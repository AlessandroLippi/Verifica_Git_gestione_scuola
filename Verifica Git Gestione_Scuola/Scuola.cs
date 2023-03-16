using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git_Gestione_Scuola
{
    public class Scuola
    {
        string nome { get; set; }
        string indirizzo { get; set; }
        string orario { get; set; }
        List<alunno> alunni = new List<alunno>(); 

            public Scuola(string nome, string cognome, string orario)
            {
                this.nome = nome;
                this.indirizzo = cognome;
                this.orario = orario;

            }

        public void AggiungiAlunno(alunno a)
        {
            alunni.Add(a);
        }
        //metodo che gestisce la ricerca degli alunni(da completare perchè da problemi nel foreach):

        public void RicercaPerCognome()
        {
            Console.WriteLine("inserire il cognome dell'alunno da ricercare:");
            string Ricarcato = Console.ReadLine();
            foreach (alunno x in alunni)
            {
                if (x.cognome == Ricarcato)
                    Console.WriteLine(x.ToStringAlunno());
                break;

            }
        }


        //metodo di ricerca per l'età:

        public void RicercaPerEtà()
        {
            Console.WriteLine("inserire l'età dell'alunno da ricercare:");
            int EtàRicarcato = int.Parse(Console.ReadLine());
            foreach (alunno x in alunni)
            {
                if (x.eta == EtàRicarcato)
                    Console.WriteLine(x.ToStringAlunno());
                break;

            }
        }
        //metodo di controllo di tutti gli alunni presenti : 

        
        public void AlunniPresenti()
        {
            foreach(alunno x in alunni)
            {
                Console.WriteLine(x.ToStringAlunno());
            }
        }




    }
}
