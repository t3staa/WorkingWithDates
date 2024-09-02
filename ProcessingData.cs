public static class ProcessingData{
    public static void Show(){
        var formatDate = DateTime.Now;
        var formated = "";

        Console.WriteLine("==================================");
        Console.WriteLine("          TRATANDO DADOS          ");
        Console.WriteLine("==================================\n");

        // Padrão bastante utilizado em formatos JSON
        formated = String.Format("{0:s}", formatDate);
        Console.WriteLine(formated);

        // Console.WriteLine(formated.Length);

        string dateReceived = formated;

        var usingSubstring = dateReceived.Substring(11, 8);
        Console.WriteLine(usingSubstring);

        string[] dateSplited = dateReceived.Split('T');
        Console.WriteLine($"Data: {dateSplited[0]}");
        Console.WriteLine($"Hora: {dateSplited[1]}");

        Console.WriteLine("\n\n");
    }
}