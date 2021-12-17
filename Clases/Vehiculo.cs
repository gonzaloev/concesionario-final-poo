using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{   
    public abstract class Vehiculo
    {
        public delegate void IngresoNuevoVehiculo();
        public event IngresoNuevoVehiculo  GuardarVehiculo;
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Ruedas { get; set; } 
        public int VelocidadMax { get; set; }
        public int Km { get; set; }
        public virtual decimal Precio { get; set; }
        public int Puertas { get; set; }
        public bool IngresoVehiculo { get; set; }
        

        
        public Vehiculo()
        {
        
        }

        public Vehiculo(string marca, string modelo, string color, int ruedas, int velocidadMax, int km, decimal precio, int puertas, bool ingresoVehiculo)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Ruedas = ruedas;
            VelocidadMax = velocidadMax;
            Km = km;
            Precio = precio;
            Puertas = puertas;
            IngresoVehiculo = ingresoVehiculo;
        }

        public override string ToString()
        {
            
            return ("Marca: " + Marca + " Modelo: " + Modelo + " Color: " + Color + " Ruedas: " + Ruedas + " Velocidad Máxima: " + VelocidadMax + "km/h" + " Kilometraje: "+ Km+ "km"+" Precio: $" + Precio + " Puertas: " + Puertas);
        }
        
        public void CheckearIngresos() {
            if(IngresoVehiculo)
            {   
                Console.Write(Marca + " " + Modelo + ": " ); 
                GuardarVehiculo();                  
                
            }
            else 
            {   Console.WriteLine($"El vehiculo {Marca + " " + Modelo} todavia no ingreso a planta"); }
            
        }
       

        }
}


