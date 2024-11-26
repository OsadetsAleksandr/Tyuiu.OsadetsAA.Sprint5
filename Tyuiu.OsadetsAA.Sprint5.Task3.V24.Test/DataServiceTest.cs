using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task3.V24.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string[] paths = { @"C:\Users", "Mecht", "source", "repos", "Tyuiu.OsadetsAA.Sprint5", "Tyuiu.OsadetsAA.Sprint5.Task2.V24", "bin", "Debug", "OutPutFileTask3.bin" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}