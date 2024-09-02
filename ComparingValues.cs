public static class ComparingValues{
    public static void Show()
    {
        // Comparando datas
        DateTime date = DateTime.Now;

        Console.WriteLine("==================================");
        Console.WriteLine("       COMPARANDO VALORES         ");
        Console.WriteLine("==================================\n");

        if(date.Date == DateTime.Now.Date)
            Console.WriteLine("É igual");

        Console.WriteLine(date);

        Console.WriteLine("\n\n");
    }
}