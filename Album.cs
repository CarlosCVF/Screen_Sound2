class Album
{
    private List<Music> musics = new List<Music>();
    public string? Name { get; set; }
    public int TotalDuration => musics.Sum(m => m.Duration);

    public void AddMusic(Music music)
    {
        musics.Add(music);
    }
    public void DisplayAlbum()
    {
        System.Console.WriteLine($"O album {Name} tem as seguintes musicas: \n");
        foreach (var music in musics)
        {
            System.Console.WriteLine(music.Name);
        }
        Console.WriteLine($"\nO tempo total do album é de: {TotalDuration} segundos");
    }
}