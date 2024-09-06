using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassiComputer;

namespace Programmacomputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer(1080, 100);

            c.AccesoIniziato += OnAccesoIniziato;
            c.StandByIniziato += OnStandByIniziato;
            c.SpentoIniziato += OnSpentoIniziato;

            c.Acceso();
            c.StandBy();
            c.Acceso();
            c.Spento();

            Console.ReadLine();
        }

        static void OnAccesoIniziato() { Console.WriteLine("OnAccesoIniziato Fired"); }
        static void OnStandByIniziato() { Console.WriteLine("OnStandByIniziato Fired"); }
        static void OnSpentoIniziato() { Console.WriteLine("OnSpentoIniziato Fired"); }

    }
}
