using ClassiAutomobile;
using System;

namespace ProgrammaAutomobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile a = new Automobile();
            a.NumeroPorte = 5;
            a.AccensioneIniziata += OnAccensioneIniziata;
            a.SpegnimentoIniziato += OnSpegnimentoIniziato;

            a.AvviaMotore();
            Console.WriteLine("Avvia finito");
            a.SpegniMotore();
            Console.WriteLine("Spegni finito");
            Console.ReadLine();
        }

        private static void OnAccensioneIniziata()
        {
            Console.WriteLine("OnAccensioneIniziata fired");
        }
        private static void OnSpegnimentoIniziato()
        {
            Console.WriteLine("OnSpegnimentoIniziato fired");
        }
    }
}
