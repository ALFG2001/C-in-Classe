using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassi2
{
    public class Prezzo
    {
        private bool _eSconto = false;
        public bool GetSconto() { return _eSconto; }

        private decimal _valore = 0;

        public decimal GetValore() { return _valore; }
        public void SetValore(decimal valore) { 
            _valore = valore;
            _eSconto = valore < 0;
        }
    }
}
