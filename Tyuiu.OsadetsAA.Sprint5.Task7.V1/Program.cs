using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = ("Спринт #5 | Выполнил: Осадец А. А. | ПКТб-24-1");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
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

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask7V1.txt");
            Console.WriteLine("Данные находятся в файле: " + path);
            string pathSave = Path.Combine("C:", "DataSprint5", "OutPutDataFileTask7V1.txt");
            Console.WriteLine("Данные сохранятся в файл: " + pathSave);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            pathSave = ds.LoadDataAndSave(path);
            Console.WriteLine(File.ReadAllText(pathSave));
        }
    }
}
