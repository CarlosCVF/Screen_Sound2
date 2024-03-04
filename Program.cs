Band TDG = new Band();
TDG.BandName = "Three Days Grace";

Album AlbumTDG = new Album();
AlbumTDG.Name = "One-x";

Music music1 = new Music(TDG, "Get out Alive")
{
    Duration = 262,
    Available = false,
};


Music music2 = new Music(TDG, "Riot")
{
    Duration = 207,
    Available = true,
};

AlbumTDG.AddMusic(music1);
AlbumTDG.AddMusic(music2);
TDG.AdicionarAlbum(AlbumTDG);

music1.DisplayTechnicalSheet();
music2.DisplayTechnicalSheet();
TDG.ShowDiscography();