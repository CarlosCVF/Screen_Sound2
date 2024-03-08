// Band TDG = new Band();
// TDG.BandName = "Three Days Grace";

// Album AlbumTDG = new Album();
// AlbumTDG.Name = "One-x";

// Music music1 = new Music(TDG, "Get out Alive")
// {
//     Duration = 262,
//     Available = false,
// };


// Music music2 = new Music(TDG, "Riot")
// {
//     Duration = 207,
//     Available = true,
// };

// AlbumTDG.AddMusic(music1);
// AlbumTDG.AddMusic(music2);
// TDG.AdicionarAlbum(AlbumTDG);

// music1.DisplayTechnicalSheet();
// music2.DisplayTechnicalSheet();
// TDG.ShowDiscography();
Episodio eps1 = new(1, "Técnica de Facilitação", 30);
eps1.AddGuests("João");
eps1.AddGuests("Maria");

Episodio eps2 = new(1, "Técnica de Conhecimento", 47);
eps2.AddGuests("Roberto");
eps2.AddGuests("Catarina");
eps2.AddGuests("Carlos");

Podcast podcast = new("Podcast Diferenciado","Danilo");
podcast.AdicionarEpisodio(eps1);
podcast.AdicionarEpisodio(eps2);
podcast.ShowDetails();