using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task4.V20.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string[] paths = { @"C:\DataSprint5", "InPutDataFileTask4V20.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}