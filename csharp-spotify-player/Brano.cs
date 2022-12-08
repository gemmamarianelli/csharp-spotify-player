using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    internal class Brano : ContenutoRiproducibile
    {
        
        private string nomeCanzone;
        private int Minuti;
        private string nomeArtista;
        public Brano(string nomeCanzone, int minuti, string nomeArtista)
        {
            this.nomeCanzone = nomeCanzone;
            this.Minuti = minuti;
            this.nomeArtista = nomeArtista;
        }
        public string GetnomeCanzone()
        {
            return nomeCanzone;
        }
        public int GetMinuti()
        {
            return Minuti;
        }
        public string GetnomeArtista()
        {
            return nomeArtista;
        }
        public void Stampa()
        {
            Console.WriteLine("-------" + "CANZONE" + "------");
            Console.WriteLine("CANZONE: " + nomeCanzone);
            Console.WriteLine("ARTISTA: " + nomeArtista);
            Console.WriteLine("MINUTI: " + Minuti + " min");
            Console.WriteLine("--------------------");
        }
        public void Play()
        {
            Console.WriteLine("il bradno " + nomeCanzone + " di " + nomeArtista + " è in riproduzione");
        }
        public void Pausa()
        {
            Console.WriteLine("il brano " + nomeCanzone + " di " + nomeArtista + " è in pausa");
        }
        public void Stop()
        {
            Console.WriteLine("Il brano " + nomeCanzone + " di " + nomeArtista + " è stoppato");
        }

    }
}
