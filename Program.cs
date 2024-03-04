Band TDG = new Band();
TDG.BandName = "Three Days Grace";

Album AlbumTDG = new Album();
AlbumTDG.Name = "One-x";

Music music1 = new Music(TDG);
music1.Name = "Get out Alive";
music1.Duration = 262;

Music music2 = new Music(TDG);
music2.Name = "Riot";
music2.Duration = 207;

AlbumTDG.AddMusic(music1);
AlbumTDG.AddMusic(music2);

TDG.AdicionarAlbum(AlbumTDG);
TDG.ShowDiscography();