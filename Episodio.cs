class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string name, int duration)
    {
        Ordem = ordem;
        Name = name;
        Duration = duration;
    }

    public int Ordem { get;}
    public string Name { get;}
    public int Duration { get;}
    public string Resumo => $"{Ordem} - {Name} ({Duration} s) - feat. {string.Join(", ",convidados)}";
    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}