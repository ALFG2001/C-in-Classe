using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiComputer
{
    public class Computer
    {
       // dimensioneHd, vlocità processore,
        public int DimensioneHd { get; set; }
        public int VelocitaProcessore { get; set; }

        private enum Status
        {
            acceso, standBy, spento
        }
        private Status _status = Status.spento;

        public Computer(int dimensione, int velocita)
        {
            this.DimensioneHd = dimensione;
            this.VelocitaProcessore = velocita;
        }

        public delegate void AccesoDelegate();
        public event AccesoDelegate AccesoIniziato;

        public delegate void StandByDelegate();
        public event StandByDelegate StandByIniziato;

        public delegate void SpentoDelegate();
        public event SpentoDelegate SpentoIniziato;

        public void Acceso() 
        {
            Console.WriteLine("Acceso Fired");
            if (this._status != Status.acceso) 
            {
                this._status = Status.acceso;
                if (AccesoIniziato != null) AccesoIniziato();
            }
        }

        public void StandBy()
        {
            Console.WriteLine("StandBy Fired");
            if (this._status == Status.acceso)
            {
                this._status = Status.standBy;
                if (StandByIniziato != null) StandByIniziato();
            } else if (this._status == Status.spento) 
            {
                throw new Exception("Operazione non Permessa");
            }
        }

        public void Spento()
        {
            Console.WriteLine("Spento Fired");
            if (this._status == Status.acceso)
            {
                this._status = Status.spento;
                if (SpentoIniziato != null) SpentoIniziato();
            }
            else if (this._status == Status.standBy)
            {
                throw new Exception("Operazione non Permessa");
            }
        }

    }
}
