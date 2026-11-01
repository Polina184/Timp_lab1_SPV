class Item
{
    public string Name { get; }
    public int Attempts { get; }

    public Item(string name, int attempts)
    {
        Name = name;
        Attempts = attempts;
    }
}
