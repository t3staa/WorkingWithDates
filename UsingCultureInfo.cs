using System.Globalization;
public static class UsingCultureInfo{
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

        Console.WriteLine("\n\n");
    }
}