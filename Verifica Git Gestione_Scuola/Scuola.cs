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
        string cognome { get; set; }
        int orario { get; set; }
        List<alunno> alunni = new List<alunno>(); 

            public Scuola(string nome, string cognome, int orario)
            {
                this.nome = nome;
                this.cognome = cognome;
                this.orario = orario;

            }

        public void AggiungiAlunno()
        {
            alunno a = new alunno("Alessandro", "Lippi", "Meldola", 18);
            alunni.Add(a);
        }
        //metodo che gestisce la ricerca degli alunni:

        //public string RicercaPerCognome()
        //{
        //    foreach(int alunno in alunni)
        //    {
        //        if(alunni[alunno].cognome)
        //    }
        //}


        //metodo di ricerca per l'età:





        //metodo di controllo di tutti gli alunni presenti : 



    }
}
