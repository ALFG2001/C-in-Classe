using System;
using System.IO;

namespace EsempioFileCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePathName = "./prova.txt";

            if (!File.Exists(filePathName))
                Console.WriteLine($"il file: '{filePathName}' non esiste");
        }
    }
}
