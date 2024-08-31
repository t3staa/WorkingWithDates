
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



Console.WriteLine(" ");



Console.WriteLine("================");
Console.WriteLine("FORMATANDO DATAS");
Console.WriteLine("================\n");

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




















