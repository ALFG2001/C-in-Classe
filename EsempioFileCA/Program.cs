using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
