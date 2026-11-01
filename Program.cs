using System;

class Program
{
    static void Main(string[] args)
    {
        Item[] items = {
            new Item("jobA", 0),
            new Item("jobB", 1),
            new Item("jobC", 3),
            new Item("jobD", 4)
        };

        string set = args.Length > 0 ? args[0] : "";
        if (set == "empty")
            items = Array.Empty<Item>();
        if (set == "edge")
            items = new[] { new Item("a", 2), new Item("b", 3) };
        if (set == "over")
            items = new[] { new Item("over", 4) };
        if (set == "own")
            items = new[] {
                new Item("build", 1),
                new Item("deploy", 2),
                new Item("test", 5),
                new Item("lint", 0)
            };

        Item[] selected = Selection.Apply(items);
        foreach (Item item in selected)
            Console.WriteLine(Formatter.Format(item));

        string summary = Summary.Build(selected);
        if (summary.Length > 0)
            Console.WriteLine(summary);
    }
}
