class Band
{
    private List<Album> albums = new List<Album>();
    public string? BandName { get; set; }
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }
    public void ShowDiscography()
    {
        System.Console.WriteLine($"Os albuns da banda {BandName} são:");
        foreach(Album album in albums)
        {
            System.Console.WriteLine($"Album: {album.Name} ({album.TotalDuration} segundos)");
        }
    }
}