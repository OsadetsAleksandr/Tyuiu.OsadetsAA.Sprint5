using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task7.V1;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = ("Спринт #5 | Выполнил: Осадец А. А. | ПКТб-24-1");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Осадец Александр Александрович | ПКТб-24-1                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Удалить все цифры из файла. Полученный результат сохранить в файл       *");
        Console.WriteLine("* OutPutDataFileTask7V1.txt.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(@"C:\DataSprint5", "InPutDataFileTask7V1.txt");
        string pathSave = Path.Combine(@"C:\DataSprint5", "OutPutDataFileTask7V1");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        pathSave = ds.LoadDataAndSave(path);
        Console.WriteLine(pathSave);
    }
}
