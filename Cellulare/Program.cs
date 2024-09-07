using ClassiCellulare;
using System;

public class Program
{
    public static void Main()
    {
        Cellulare c1 = new Cellulare();

        c1.Fotocamera = new Fotocamera();
        c1.Batteria = new Batteria();
        c1.Schermo = new Schermo();

        c1.Fotocamera.Risoluzione = "1280x740";
        c1.Batteria.CapacitaW = 5;
        c1.Schermo.LuminositaLUMENS = 500;

        c1.ChiamataIniziata += OnChiamataIniziata;
        c1.Chiama("3280395577");
        Console.WriteLine("fine");
        //c1.Chiama("1234");
        //c1.Attacca();
        //c1.Chiama("1234");
        Console.ReadLine();
    }

    public static void OnChiamataIniziata()
    {
        Console.WriteLine("OnChiamataIniziata Fired!!!");
    }
}
