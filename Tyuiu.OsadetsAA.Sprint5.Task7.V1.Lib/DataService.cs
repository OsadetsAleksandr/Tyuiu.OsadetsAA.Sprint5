using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task7.V1.Lib;

public class DataService : ISprint5Task7V1
{
    public string LoadDataAndSave(string path)
    {
        string temp = Path.GetTempPath();
        string pathSave = Path.Combine(temp, "OutPutDataFileTask7V1.txt");
        FileInfo fileInfo = new FileInfo(pathSave);
        bool fileExists = fileInfo.Exists;
        if (fileExists)
        {
            File.Delete(path);
        }
        string strLine = "";
        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                foreach (char c in path)
                {
                    if (!char.IsDigit(c))
                    {
                        strLine += c;
                    }
                }
                File.AppendAllText(pathSave, strLine + Environment.NewLine);
                strLine = "";
            }
        }
        return pathSave;

    }
}
