using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task6.V13.Lib;
namespace Tyuiu.OsadetsAA.Sprint5.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc ()
        {
            DataService ds = new DataService();
            string[] paths = { @"C:\DataSprint5", "InPutDataFileTask6V13.txt" };
            string fullPath = Path.Combine(paths);
            var res = ds.LoadFromDataFile(fullPath);
            int wait = 3;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void LoadFromDataFile ()
        {
            string[] paths = { @"C:\DataSprint5", "InPutDataFileTask6V13.txt" };
            string fullPath = Path.Combine(paths);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}