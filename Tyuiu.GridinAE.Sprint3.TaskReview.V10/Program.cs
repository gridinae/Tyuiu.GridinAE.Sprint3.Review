using Tyuiu.GridinAE.Sprint3.TaskReview.V10.Lib;

Console.Title = "Спринт #3 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #3                                                            *");
Console.WriteLine("* Тема: Спринт ревью #3                                                *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #10                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Написать программу, на C#, которая выводит таблицу значений функции  *");
Console.WriteLine("* F(x) на диапазоне [-5; 5] с шагом 1. Произвести проверку деления на  *");
Console.WriteLine("* 0. При делении на 0 вернуть значение 0. Значения занести в массив.   *");
Console.WriteLine("* Значения округлить до двух знаков после запятой.                     *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

DataService ds = new();
double[] values = ds.GetValues(-5, 5, 1);

Console.WriteLine(" X | F(X)");
int i = 0;
foreach(double value in values)
{
    if (i - 5 < 0)
        Console.WriteLine($"{i - 5} | {value}");
    else
        Console.WriteLine($" {i - 5} | {value}");
    i++;
}

Console.ReadKey();