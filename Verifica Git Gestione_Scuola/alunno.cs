using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica_Git_Gestione_Scuola
{
<<<<<<< HEAD
<<<<<<< HEAD
    public class alunno
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public string residenza { get; set; }
        public int eta { get; set; }

        public alunno(string nome, string cognome, string residenza, int eta)
=======
    internal class alunno
    {
=======
    public class alunno
    {
>>>>>>> scuola
        string nome { get; set; }
        string cognome { get; set; }
        string residenza { get; set; }
        int eta { get; set; }

<<<<<<< HEAD
        internal alunno(string nome, string cognome, string residenza, int eta)
>>>>>>> alunno
=======
        public alunno(string nome, string cognome, string residenza, int eta)
>>>>>>> scuola
        {
            this.nome = nome;
            this.cognome = cognome;
            this.residenza = residenza;
            this.eta = eta;
        }

        // metodi: 

        public string ToStringAlunno()
        {
            return  "dati dell'alunno :" + this.nome+" "+this.cognome + " "+this.residenza + " " +this.eta.ToString();
        }

        public void Classe()
        {
            alunno a = new alunno("Alessandro", "Lippi", "Meldola", 18);
            if (a.eta <= 16)
                Console.WriteLine("L'alunno " + a.nome + "frequenta il biennio");
            else
                Console.WriteLine("L'alunno " + a.nome + "frequenta il triennio");                      /u git sa ttfaca ifdimo

        }
    }
}
