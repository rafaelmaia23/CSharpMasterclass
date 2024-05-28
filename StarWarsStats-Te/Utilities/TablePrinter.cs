public static class TablePrinter
{
    public static void Print<T>(IEnumerable<T> itens)
    {
        const int colunmWidth = 15;

        var properties = typeof(T).GetProperties();

        foreach (var property in properties)
        {
            Console.Write($"{{0, -{colunmWidth}}}|", property.Name);
        }
        Console.WriteLine();
        Console.WriteLine(new string('-', properties.Length * (colunmWidth + 1)));

        foreach (var item in itens)
        {
            foreach(var property in properties)
            {
                Console.Write($"{{0, -{colunmWidth}}}|", property.GetValue(item));
            }
            Console.WriteLine();
        }        
    }
}
