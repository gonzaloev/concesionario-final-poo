using System;
using Clases.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public sealed class Auto : Vehiculo , IAceleracion
    {
        private bool convertible;
        
       
        public Auto(string marca, string modelo, string color, int ruedas, int velocidadMax, int km, decimal precio, int puertas, bool convertible, bool ingresoVehiculo)
            : base(marca, modelo, color, ruedas, velocidadMax, km, precio, puertas, ingresoVehiculo)
        {
            this.Convertible = convertible;
        }

        public bool Convertible { get => convertible; set => convertible = value; }

        public override decimal Precio 
        { get
            {
                if(this.Convertible==true)
                {
                    return base.Precio + 30000M;
                }
                else
                {
                    return base.Precio;
                }
            }
                
         }
        public override string ToString()
        {
            if (this.Convertible)
            {
                return base.ToString() + " y es convertible.";
            }
            else
            {
                return base.ToString() + " y no es convertible.";
            }

           
        }

         public void CalcularAceleracion()
        {
            double aceleracion = 0;
            aceleracion = this.VelocidadMax  / 3;
            Console.WriteLine($"La aceleracion de {this.Marca} {this.Modelo} es de: " + aceleracion + "km/h.");
        }

        
    }
}
