using csharp_spotify_player;

Brano canzone1 = new Brano("Billie Jean", 5, "Michael Jackson");
canzone1.Stampa();
canzone1.Play();
canzone1.Stop();
canzone1.Pausa();

Podcast podcast1 = new Podcast("Muschio Selvaggio", 500, "Fedez e Luis", 160);
podcast1.Stampa();
podcast1.Play();
podcast1.Stop();
podcast1.Pausa();