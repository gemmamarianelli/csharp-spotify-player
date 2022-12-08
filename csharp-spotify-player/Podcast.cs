using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Podcast
    {
        private string nome;
        public int puntate;
        public string autore;
        public int minutiPuntate;

        public Podcast(string nome, int puntate, string autore, int minutiPuntate)
        {
            this.nome = nome;
            this.puntate = puntate;
            this.autore = autore;
            this.minutiPuntate = minutiPuntate;
        }

        //GETTERS
       public string GetNome()
        {
            return nome;
        }
        public int GetPuntate()
        {
            return puntate;
        }
        public string GetAutore()
        {
            return autore;
        }
        public int GetMinutiPuntate()
        {
            return minutiPuntate;
        }


        public void Stampa() 
        {
            Console.WriteLine("--------" + "PODCAST" + "--------");
            Console.WriteLine("NOME PODCATS: " + nome);
            Console.WriteLine("AUTORE: " + autore);
            Console.WriteLine("NUMERO PUNTATE: " + puntate);
            Console.WriteLine("MINUTI PUNTATA SINGOLA: " + minutiPuntate + " min");
            Console.WriteLine("---------------------------");


        }
        public void Play()
        {
            Console.WriteLine("Riproduzione Podcast" + nome + " di " + autore);
        }
        public void Pausa()
        {
            Console.WriteLine("In pausa Podcast " + nome + " di " + autore);
        }
        public void Stop()
        {
            Console.WriteLine("Messo in stop " + nome + " di " + autore);
        }

    }
}
