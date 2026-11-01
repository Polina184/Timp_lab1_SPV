using System.Collections.Generic;

static class Selection
{
    private const int Limit = 3;

    public static Item[] Apply(Item[] items)
    {
        var retry = new List<Item>();
        foreach (Item item in items)
        {
            if (item.Attempts < Limit)
                retry.Add(item);
        }
        return retry.ToArray();
    }
}
