using System.IO;
using Tyuiu.OsadetsAA.Sprint5.Task0.V13.Lib;

namespace Tyuiu.OsadetsAA.Sprint5.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(5);
            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists, "Файл не был создан");
            string content = File.ReadAllText(path);
            double expected = Math.Round((-1.4 * Math.Pow(3, 3) + 2.3 * Math.Pow(3, 2) + 0.6 * 3), 3);
            Assert.AreEqual(expected.ToString(), content, "Содержимое файла некорректно");
        }
    }
}