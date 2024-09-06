using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioClassi2
{
    public enum UnitaDiMisuraEnum
    {
        mm, cm, dm, m, km, kg, g, mg, dg, hg, mmq, cmq, dmq, mq, kmq
    }
    public class Dimensione
    {
        public decimal Valore { get; set; }

        public UnitaDiMisuraEnum UnitaMisura { get; set; }

    }
}
