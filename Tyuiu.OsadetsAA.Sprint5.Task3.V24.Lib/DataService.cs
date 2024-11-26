﻿using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.OsadetsAA.Sprint5.Task3.V24.Lib
{
    public class DataService : ISprint5Task3V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            y = Math.Round(y, 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8 ))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
