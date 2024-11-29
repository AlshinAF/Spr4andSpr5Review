using Tyuiu.AlshinAF.Sprint4.Rev.V1.Lib;
DataService ds = new DataService();
Random rnd = new Random();
Console.Title = "Спринт #4 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Спринтревью                                                      *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана строка из одноразрядных цифр 135792468. Преобразуйте её в матрицу  *");
Console.WriteLine("* 5 на 3 и подсчитайте количество четных чисел.                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int rows = 3;
int cols = 3;
int[,] mtrx = new int[rows, cols];
int index = 0;
string str = "135792468";
Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{str[index]}");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine();


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество чётных чисел = " + ds.Calculate(rows, cols, str));
Console.ReadKey();