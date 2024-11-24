using System.Diagnostics.CodeAnalysis;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task1.V30.Lib
{
    public class DataService : ISprint5Task1V30
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            string strY;
            double y;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2 - 2 * i == 0)
                {
                    y = 0;
                }
                
                y = Math.Round((Math.Cos(i) + (Math.Sin(i)) / (2 - (2 * i)) - 4 * i), 2);
                strY = y.ToString();

                if (i != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}
