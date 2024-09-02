public static class AddingValues{
    public static void Show()
    {
        // Adicionando e removendo dias, meses e anos na data.
        var date = DateTime.Now;

        Console.WriteLine("==================================");
        Console.WriteLine("       ADICIONANDO VALORES        ");
        Console.WriteLine("==================================\n");

        Console.WriteLine(date);
        Console.WriteLine(date.AddDays(12));
        Console.WriteLine(date.AddDays(-12));
        Console.WriteLine(date.AddMonths(1));
        Console.WriteLine(date.AddYears(1));

        Console.WriteLine("\n\n");
    }
}