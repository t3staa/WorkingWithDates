using System.Globalization;
public static class LearningCultureInfo{
    public static void Show()
    {
        // Localização e Globalização
        var br = new CultureInfo("pt-BR");
        var enUs = new CultureInfo("en-US");
        var pt = new CultureInfo("pt-PT");
        var de = new CultureInfo("de-DE");
        var atual = CultureInfo.CurrentCulture;

        Console.WriteLine("==================================");
        Console.WriteLine("       USANDO CULTURE INFO        ");
        Console.WriteLine("==================================\n");

        Console.WriteLine(DateTime.Now.ToString("D", de)); // Forma mais comum 
        // Console.WriteLine(String.Format("0:D", DateTime.Now)); // Outra forma de utilizar

        Console.WriteLine(DateTime.Now.ToString("D", atual)); // Atribuindo cultura atual da maquina
        Console.WriteLine(DateTime.Now.ToString("D", enUs)); // Atribuindo cultura en
        Console.WriteLine(DateTime.Now.ToString("D", br)); // Atribuindo cultura br

        Console.WriteLine("\n");

        DateTime dateTimeUtc = DateTime.UtcNow;
        
        Console.WriteLine(dateTimeUtc); // Hora universal, interessante usar em aplicações onde o server nao fique na nossa regiao, ou
                                        // um projeto que fique disponivel para varias localidades do mundo.

        Console.WriteLine(dateTimeUtc.ToLocalTime()); // Passando a hora de formato universal para formato local.

        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland"); // Classe para mudar as zonas.
        Console.WriteLine(timezoneAustralia);

        var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezoneAustralia);
        Console.WriteLine(horaAustralia);

        Console.WriteLine("\n Mostrando todas as timezones: ");

        // Mostra todas as timezones do sistema
        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTimeUtc, timezone));
            Console.WriteLine("-------------");
        }

        Console.WriteLine("\n\n");
    }
}