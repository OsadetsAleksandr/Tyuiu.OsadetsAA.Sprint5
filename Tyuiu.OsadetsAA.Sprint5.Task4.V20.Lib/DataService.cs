using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string s = s.Replace(",", ".");
            double x = double.Parse(s);
            double res = Math.Round(Math.Pow(((Math.Pow(x, 2)) / (Math.Sin(x))), 3), 3);
            return res;

        }
    }
}
