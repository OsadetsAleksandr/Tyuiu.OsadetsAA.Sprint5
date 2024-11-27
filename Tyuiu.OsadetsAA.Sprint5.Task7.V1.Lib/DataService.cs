using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task7.V1.Lib
{
    public class DataService : ISprint5Task7V1
    {
        public string LoadDataAndSave(string path)
        {
            string pathSave = $@"{Path.GetTempPath()}OutPutDataFileTask7V1.txt";
            FileInfo fileInfo = new FileInfo(pathSave);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSave);
            }
            string result = "";
            foreach (char c in path)
            {
                if (!char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
