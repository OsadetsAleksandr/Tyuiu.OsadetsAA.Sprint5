using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task6.V13.Lib
{
    public class DataService : ISprint5Task6V13
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string data = File.ReadAllText(path);

            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] == 'с' && data[i + 1] == 'с' || data[i] == 'С' && data[i + 1] == 'с')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
