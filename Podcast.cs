class Podcast
{
    private List<Episodio> episodios = new();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get;}
    public string Host {get;}
    public int TotalEpisodio => episodios.Count;
    public void ShowDetails()
    {
        System.Console.WriteLine($"O podcast {Name} apresentado por {Host} possui:\n");
        foreach(Episodio episodio in episodios.OrderBy(e => e.Order))
        {
            System.Console.WriteLine(episodio.Summary);
        }
        System.Console.WriteLine($"\nTem um total de {TotalEpisodio} episódios.");
    }
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
}