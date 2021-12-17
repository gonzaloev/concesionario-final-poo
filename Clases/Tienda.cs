using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Tienda 
    {
        public List<Vehiculo> StockVehiculos { get; set; }

        public Tienda()
        {
            try
            {
                StockVehiculos = new List<Vehiculo>();
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
            }

        }

        public decimal CalcularValorTotal()
        {
            decimal costoTotal = 0;

            foreach (var c in StockVehiculos)
            {
                
                costoTotal += c.Precio;

            }
            return costoTotal;
        }
        
    }

    
}
