

Console.Clear();

LearningDates.Show(); // Aprendo sobre criação de struct etc.

FormatingDates.Show(); // Aprendo sobre formatação de datas.

ProcessingData.Show(); // Brinco um pouco com tratamento de dados.

AddingValues.Show(); // Aprendo e adicionar e remover valores da data.

ComparingValues.Show(); // Vejo como eu posso comparar valores das datas.

LearningCultureInfo.Show(); // Aprendo sobre culture info.

LearningTimeSpan.Show(); // Aprendo sobre timespan

// Alguns metodos legais para saber:

// Como contar quantos dias tem em um mes
Console.WriteLine($"Tem {DateTime.DaysInMonth(2024, 4)} no mes");

// Printando o resultado da função IsWeekend
Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));

// Saber se estamos no verão
Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

//Verificar se é final de semana
static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}
