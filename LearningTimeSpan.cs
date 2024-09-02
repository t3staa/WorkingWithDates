

public static class LearningTimeSpan{
    public static void Show()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("         USANDO TIME SPAN         ");
        Console.WriteLine("==================================\n");

        // Unidade de medida, ele devolve uma fração de tempo
        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        var timeSpanNanosegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanosegundos);

        var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
        Console.WriteLine(timeSpanHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
    }
}