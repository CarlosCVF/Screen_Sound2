Album AlbumTDG = new Album();
AlbumTDG.Name = "One-x";

Music music1 = new Music();
music1.Name = "Get out Alive";
music1.Artist = "Three Days Grace";
music1.Duration = 262;

Music music2 = new Music();
music2.Name = "Riot";
music2.Artist = "Three Days Grace";
music2.Duration = 207;

AlbumTDG.AddMusic(music1);
AlbumTDG.AddMusic(music2);

Band TDG = new Band();
TDG.BandName = "Three Days Grace";
TDG.AdicionarAlbum(AlbumTDG);
TDG.ShowDiscography();