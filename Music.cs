class Music
{
    public string? name;
    public string? artist;
    public int duration;
    public bool available;

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Nome: {name}");
        Console.WriteLine($"Artista: {artist}");
        Console.WriteLine($"Duração: {duration}");
        if (available)
        {
            System.Console.WriteLine("Está disponível");
        }
        else
        {
            System.Console.WriteLine("Não está disponível ainda");
        }
    }
}