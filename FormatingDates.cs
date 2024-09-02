public static class FormatingDates{
    public static void Show(){
        Console.WriteLine("==================================");
        Console.WriteLine("        FORMATANDO DATAS          ");
        Console.WriteLine("==================================\n");

        var formatDate = DateTime.Now;
        var formated = ""; // Variavel para mostrar a saida com as formatações diferentes.

        Console.WriteLine(formatDate);

        // Y - year, M - month, D - day, H - Hour, m - minute, s - second

        formated = String.Format("Ano: {0:yyyy}", formatDate); // Formata para mostrar so o ano.
        Console.WriteLine(formated); // Saida: 2024

        formated = String.Format("Ano: {0:yy}", formatDate); // Formata para mostrar so o ano.
        Console.WriteLine(formated); // Saida: 24

        formated = String.Format("Ano: {0:y}", formatDate); // Formata para mostrar so o ano.
        Console.WriteLine(formated); // Saida: agosto de 2024

        formated = String.Format("Mês: {0:MM}", formatDate); // Formata para mostrar so o mês.
        Console.WriteLine(formated); // Saida: 08

        formated = String.Format("Dia e Mês: {0:M}", formatDate); // Formata para mostrar so o mês.
        Console.WriteLine(formated); // Saida: 31 de agosto

        formated = String.Format("Dia: {0:dd}", formatDate); // Formata para mostrar so o dia.
        Console.WriteLine(formated); // Saida: 31

        formated = String.Format("Data: {0:d}", formatDate); // Formata para mostrar so a data.
        Console.WriteLine(formated); // Saida: 31/08/2024

        formated = String.Format("Hora: {0:hh}", formatDate); // Formata para mostrar so o minuto.
        Console.WriteLine(formated); // Saida: 18 

        formated = String.Format("Minuto: {0:mm}", formatDate); // Formata para mostrar so o minuto.
        Console.WriteLine(formated); // Saida: 03 

        formated = String.Format("Padrão Americano: {0:yyyy-MM-dd}", formatDate); // Formata para mostrar a data no padrao americano.
        Console.WriteLine(formated); // Saida: 2024-08-31

        formated = String.Format("Padrão Brasileiro: {0:dd-MM-yyyy}", formatDate); // Formata para mostrar a data no padrao brasileiro.
        Console.WriteLine(formated); // Saida: 31-08-2024

        // Formata para mostrar a data no padrao americano porem com a separação diferente, eu posso usar qualquer caractere
        formated = String.Format("Separação diferente: {0:yyyy*MM*dd}", formatDate); 
        Console.WriteLine(formated); // Saida: 2024-08-31

        // Formata para mostrar a data no padrao americano porem com a separação diferente, eu posso usar qualquer caractere
        formated = String.Format("Completa com Zona: {0:yyyy/MM/dd hh:mm:ss zzz}", formatDate); 
        Console.WriteLine(formated); // Saida: 2024/08/31


        // Usando formatações pre-definidas
        formated = String.Format("Hora Compactada: {0:t}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Data Compactada: {0:d}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Hora por extenso: {0:T}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Data por extenso: {0:D}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Data e Hora combinada: {0:F}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Data e Hora combinada: {0:G}", formatDate);
        Console.WriteLine(formated);

        formated = String.Format("Padrão muito utilizado em sistemas: {0:r}\n", formatDate);
        Console.WriteLine(formated);

        // Padrão universal
        formated = String.Format("Padrão Universal: {0:u}", formatDate);
        Console.WriteLine(formated); 

        // Padrão bastante utilizado em formatos JSON
        formated = String.Format("Padrão JSON: {0:s}", formatDate);
        Console.WriteLine(formated); 

        Console.WriteLine("\n\n");
    }
}