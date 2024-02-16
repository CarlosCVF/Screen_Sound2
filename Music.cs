class Music
{
    public string Name {set; get;}
    public string Artist{set; get;}
    public int Duration{set; get;}
    public bool Available{set; get;}

    public string Description => 
        $"A música {Name} pertence ao artista {Artist}";

    public void DisplayTechnicalSheet()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Artista: {Artist}");
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