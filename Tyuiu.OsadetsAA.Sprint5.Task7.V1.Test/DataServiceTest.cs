using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task7.V1.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task7.V1.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void LoadDataAndSave()
    {
        string[] paths = { @"C:\DataSprint5", "InPutDataFileTask7V1.txt" };
        string fullPath = Path.Combine(paths);

        FileInfo fileInfo = new FileInfo(fullPath);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}