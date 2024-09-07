using EsempioClassi;
using System;


namespace EsempioClassiCA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prezzo p1 = new Prezzo();
            Prezzo p2 = new Prezzo();
            p1.SetValore(-10);
            p2.SetValore(10);
            Console.WriteLine("p1 sconto: " + p1.GetSconto());
            Console.WriteLine("p2 sconto: " + p2.GetSconto());
            Console.ReadLine();
        }
    }
}
