﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_spotify_player
{
    public interface ContenutoRiproducibile
    {
        public void Play();
        public void Stop();
        public void Pausa();
    }
}
