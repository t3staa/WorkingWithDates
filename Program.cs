
Console.Clear();

Console.WriteLine("=====================");
Console.WriteLine("Trabalhando com datas");
Console.WriteLine("===================== \n\n");

// var date = new DateTime(); // DateTime é uma Struct, ou seja, tenho sempre que inicializar os valores
                              // Pois nao existe valores nulos para eles.

var currentDate = DateTime.Now; // Pegando a data atual diretamente da Struct

var date = new DateTime(2020, 10, 13, 13, 23, 14); // Criar uma data especificando os valores.

Console.WriteLine($"Data atual: {currentDate} \n\n");

Console.WriteLine($"Data completa: {date}"); // Apresenta os valores

// Apresenta os valores separadamente
Console.WriteLine($"Ano: {date.Year}");
Console.WriteLine($"Mes: {date.Month}");
Console.WriteLine($"Dia: {date.Day}");
Console.WriteLine($"Hora: {date.Hour}");
Console.WriteLine($"Minuto: {date.Minute}");
Console.WriteLine($"Segundo: {date.Second} \n");

Console.WriteLine($"Dia da semana: {date.DayOfWeek}"); // A propriedade DayOfWeek é um Enum.
Console.WriteLine($"Dia da semana (Enum): {(int)date.DayOfWeek}\n"); // Fazendo um Cast(Conversão Explicita) para pegar o valor do Enum.

Console.WriteLine($"Dia do ano: {date.DayOfYear}");
