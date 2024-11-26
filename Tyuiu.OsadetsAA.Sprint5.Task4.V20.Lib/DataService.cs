using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX);
            double res = Math.Round(Math.Pow(((Math.Pow(x, 2)) / (Math.Sin(x))), 3), 3);
            string s = res.ToString();
            string d = s.Replace(",", ".");
            return d;

        }
    }
}
