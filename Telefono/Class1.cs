using System;

public class Program
{
    public static void Main()
    {
        Cellulare c1 = new Cellulare();

        c1.Fotocamera = new Fotocamera();
        c1.Fotocamera.Risoluzione = "1280x740";

        c1.Batteria = new Batteria();
        c1.Batteria.CapacitaW = 5;

        c1.Schermo = new Schermo();
        c1.Schermo.LuminositaLUMENS = 100;

        Console.WriteLine(c1);
    }
}

public class Fotocamera
{
    public string Risoluzione { get; set; }
}

public class Batteria
{
    public int CapacitaW { get; set; }
}

public class Schermo
{
    public int LuminositaLUMENS { get; set; }
}

public class Cellulare
{
    public Fotocamera Fotocamera { get; set; } // non sostituibile
    public Batteria Batteria { get; set; } // non sostituibile
    public Schermo Schermo { get; set; } // sostituibile
}

