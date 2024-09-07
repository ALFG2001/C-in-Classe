using System;

namespace ClassiAutomobile
{
    public class Automobile
    {
        public int NumeroPorte { get; set; }

        private bool _eAcceso = false;

        public delegate void AccensioneIniziataDelegate();
        public event AccensioneIniziataDelegate AccensioneIniziata;

        public delegate void SpegnimentoIniziatoDelegate();
        public event SpegnimentoIniziatoDelegate SpegnimentoIniziato;

        public void AvviaMotore()
        {
            Console.WriteLine("AvviaMotore fired");
            if (_eAcceso) throw new Exception("Operazione non Permessa");
            this._eAcceso = true;
            if (AccensioneIniziata != null) AccensioneIniziata();
        }
        public void SpegniMotore()
        {
            Console.WriteLine("SpegniMotore fired");
            if (!_eAcceso) throw new Exception("Operazione non Permessa");
            this._eAcceso = false;
            if (SpegnimentoIniziato != null) SpegnimentoIniziato();
        }

    }
}
