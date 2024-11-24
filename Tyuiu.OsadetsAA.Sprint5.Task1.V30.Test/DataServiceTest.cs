using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task1.V30.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string[] paths = { @"C:\Users", "Mecht", "source", "repos", "Tyuiu.OsadetsAA.Sprint5", "Tyuiu.OsadetsAA.Sprint5.Task1.V30", "bin", "Debug", "OutPutFileTask1.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}