using System.IO;
using System.Text.RegularExpressions;
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
                string proc = Regex.Replace(line, @"\d", "");
                File.AppendAllText(pathSave, proc + Environment.NewLine);
            }
        }
        return pathSave;

    }
}
