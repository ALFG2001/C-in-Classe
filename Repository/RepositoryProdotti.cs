using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using EsempioClassi;

namespace Repository
{
    public class RepositoryProdotti
    {
        private readonly string _pathfile;
        public RepositoryProdotti(string pathfile)
        {
            _pathfile = pathfile;
        }
        public void Inserisci(Prodotto p) 
        {
            throw new NotImplementedException();
        }
        public void Modifica(Prodotto pDaModificare, Prodotto pNuovo)
        {
            throw new NotImplementedException();
        }
        public void Cancella(Prodotto pDaCancellare)
        {
            throw new NotImplementedException();
        }
        public ICollection<Prodotto> LeggiTutto()
        {
            throw new NotImplementedException();
        }
    }
}
