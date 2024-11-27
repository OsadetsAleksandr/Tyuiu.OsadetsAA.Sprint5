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
            string str = "";

            for (int i = 0; i < path.Length; i++)
            {
                if ((path[i] != 1) && (path[i] != 2) && (path[i] != 3) && (path[i] != 4) && (path[i] != 5) && (path[i] != 6) && (path[i] != 7) && (path[i] != 8) && (path[i] != 9) && (path[i] != 0))
                {
                    str += path[i];
                }
            }
            File.AppendAllText(pathSave, str + Environment.NewLine);
            str = "";
            return File.ReadAllText(pathSave);
        }
    }
}
