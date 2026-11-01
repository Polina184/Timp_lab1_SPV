static class Formatter
{
    public static string Format(Item item)
    {
        return "RETRY: " + item.Name + "; attempts=" + item.Attempts;
    }
}
