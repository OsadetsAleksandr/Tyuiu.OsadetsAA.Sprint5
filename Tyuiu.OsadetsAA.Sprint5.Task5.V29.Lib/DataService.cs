using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task5.V29.Lib
{
    public class DataService : ISprint5Task5V29
    {
        public double LoadFromDataFile(string path)
        {
            double res = 11;

            string[] lines = File.ReadAllLines(path);
                
            foreach (string line in lines)
            {
                if (double.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out double number))
                {
                    if (number == 11)
                        res += number;
                }
            }
            return res;
        }
    }
}
