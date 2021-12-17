using System;
using Clases.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public sealed class Camioneta : Vehiculo , IAceleracion
    {
        private bool remolque;
        public Camioneta(string marca, string modelo, string color, int ruedas, int velocidadMax, int km, decimal precio, int puertas, bool remolque, bool ingresoVehiculo)
            : base(marca, modelo, color, ruedas, velocidadMax, km, precio, puertas, ingresoVehiculo)
        {
            this.Remolque = remolque;
        }

        public bool Remolque { get => remolque; set => remolque = value; }

        public override decimal Precio
        {
            
            get
            {
                if(this.Remolque)
                {
                    return base.Precio + 10000M;
                }
                else
                {
                    return base.Precio;
                }
            }
        }
        public override string ToString()
        {
           if(this.Remolque)
            {
                return base.ToString() + " y tiene remolque.";
            }
            else
            {
                return base.ToString() + " y no tiene remolque.";
            }
        }

        public void CalcularAceleracion()
        {       double aceleracion = 0;
                aceleracion = this.VelocidadMax  / 7;
                Console.WriteLine($"La aceleracion de {this.Marca} {this.Modelo} es de : " + aceleracion + "km/h.");
        }
    }
}
