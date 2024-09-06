using System;

namespace ClassiCellulare
{
    public class Cellulare
    {
        public Fotocamera Fotocamera { get; set; } // non sostituibile
        public Batteria Batteria { get; set; } // non sostituibile
        public Schermo Schermo { get; set; } // sostituibile

        private bool _inChiamata = false;

        public delegate void ChiamataIniziataDelegate();
        public event ChiamataIniziataDelegate ChiamataIniziata;
        public Cellulare()
        {

        }
        public Cellulare(Fotocamera fotocamera, Schermo schermo, Batteria batteria)
        {
            this.Fotocamera = fotocamera;
            this.Schermo = schermo;
            this.Batteria = batteria;
        }
        public void Chiama(string numero)
        {
            if (!this._inChiamata)
            {
                Console.WriteLine($"Chiamando {numero}");
                this._inChiamata = true;
                if (ChiamataIniziata != null) ChiamataIniziata();
                return;
            }
            else
            {
                throw new Exception("Operazione non Supportata");
            }
        }

        public void Attacca()
        {
            if (_inChiamata) this._inChiamata = false;
        }
    }
}
