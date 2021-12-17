using Clases;
using System;
using System.Collections.Generic;

namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //ingreso / recepcion de autos a consecionaria a su stock.
            
            Console.WriteLine("Concesionario. \n");


            
            Auto aN = new Auto(marca:"Ford", modelo:"Focus", color:"Azul", ruedas:4, velocidadMax:195, km:1200, precio:3500, puertas:4, convertible: false,ingresoVehiculo: true);
            
            aN.GuardarVehiculo+=IngresarAlGarage;
            aN.CheckearIngresos();
            
            
            /* Auto aC = new Auto(marca:"BMW", modelo:"Z4", color:"Blanco", ruedas:4, velocidadMax:280, km:4500, precio:9500, puertas:4, convertible: true,  ingresoVehiculo: false); 
                
            aC.GuardarVehiculo+=IngresarAlGarage;
            aC.Checkea();*/
            
            
            /* Camioneta cN = new Camioneta(marca:"Ford", modelo:"Raptor", color:"Amarillo", ruedas:4, velocidadMax:165, km:350, precio:7500, puertas:4, remolque: false, ingresoVehiculo: true);
            
            cN.GuardarVehiculo+=IngresarAlGarage;
            cN.CheckearIngresos(); */

            
            Camioneta cR = new Camioneta(marca:"Toyota", modelo:"Hilux", color:"Negro", ruedas:4, velocidadMax:155, km:7350, precio:4500, puertas:4, remolque: true,ingresoVehiculo: false);

            cR.GuardarVehiculo+=IngresarAlGarage;
            cR.CheckearIngresos();
            

            Tienda t = new Tienda();
               
            t.StockVehiculos.Add(aN);
            /* t.StockVehiculos.Add(aC); */
            t.StockVehiculos.Add(cR);
            /* t.StockVehiculos.Add(cR); */
            
           /*  aN.GuardarVehiculo+=IngresarAlGarage;
            
            aN.CheckearIngresos(); */

            
             
            
            VehiculosEnStock(t);

            

            decimal total = t.CalcularValorTotal(); 
            Console.WriteLine("\n    La tienda vale: $" + total +"\n");

            aN.CalcularAceleracion();
            //aR.CalcularAceleracion();
            //cN.CalcularAceleracion(); 
            cR.CalcularAceleracion(); 
           
        }
         
         
        static void IngresarAlGarage(){
            Console.WriteLine("Vehiculo guardado en el garage.");
        }
        
        private static void VehiculosEnStock(Tienda t)
        {
            Console.WriteLine("\n*** Stock Disponible: \n");
            for (int i = 0; i < t.StockVehiculos.Count; i++)
            {
                Console.WriteLine("Vehiculo: " + i + " " + t.StockVehiculos[i]);
            }
        }
       

    }
}
