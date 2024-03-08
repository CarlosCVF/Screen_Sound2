class Episodio
{
    private List<string> guests = new();
    public Episodio(int order, string name, int duration)
    {
        Order = order;
        Name = name;
        Duration = duration;
    }

    public int Order { get;}
    public string Name { get;}
    public int Duration { get;}
    public string Summary => $"{Order} - {Name} ({Duration} min) - feat. {string.Join(", ",guests)}";
    public void AddGuests(string guest)
    {
        guests.Add(guest);
    }
}