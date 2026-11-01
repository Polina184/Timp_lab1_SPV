using System;

static class Summary
{
    private const int Limit = 3;

    public static string Build(Item[] items)
    {
        int slots = 0;
        foreach (Item item in items)
            slots += Math.Max(0, Limit - item.Attempts);
        return "Slots: " + slots;
    }
}
