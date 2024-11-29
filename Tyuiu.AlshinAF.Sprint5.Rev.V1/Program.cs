﻿using Tyuiu.AlshinAF.Sprint5.Rev.V1.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #5 | Выполнил: Альшин А. Ф. | РППб-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема:  Спринтревью                                                      *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Альшин Артур Фаритович | РППб-24-1                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл в котором есть набор символьных данных. Удалить все цифры      *");
Console.WriteLine("*  Полученный результат сохранить в файл OutPutDataFileTask7V1.txt       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
string[] paths = { @"C:\DataSprint5", "InPutDataFileTask7V1.txt" };
string path = Path.Combine(paths);
Console.WriteLine("Данные находится в файле: " + path);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Находится в файле: ");
Console.WriteLine(ds.LoadDataAndSave(path));
Console.ReadKey();