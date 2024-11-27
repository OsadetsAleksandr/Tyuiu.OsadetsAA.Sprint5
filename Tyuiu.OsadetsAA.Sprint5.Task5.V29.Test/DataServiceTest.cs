using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task0.V13.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] paths = { @"C:\DataSprint5", "InPutDataFileTask5V29.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}