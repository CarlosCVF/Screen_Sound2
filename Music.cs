class Music
{
    public Music(Band artist, string? name)
    {
        Artist = artist;
        Name = name;
    }
    public string? Name {get;}
    public Band Artist{get;}
    public int Duration{get; set;}
    public bool Available{get; set;}
    public Genero? Genero{get;set;}

    public string Description => 
        $"A música {Name} pertence ao artista {Artist}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist.BandName}");
        Console.WriteLine($"Duração: {Duration}");
        if (Available)
        {
            System.Console.WriteLine("Está disponível");
        }
        else
        {
            System.Console.WriteLine("Não está disponível ainda");
        }
    }
    //Crie mais um método que exiba apenas o nome e o artista usando interpolação de String.
    public void DisplayName()
    {
        System.Console.WriteLine($"Nome: {Name}");
        System.Console.WriteLine($"Artista: {Artist}");
    }
}