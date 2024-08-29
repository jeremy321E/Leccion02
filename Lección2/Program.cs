using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Usamos polimorfismo para tratar diferentes tipos de vehículos como tipo Vehiculo
            IVehiculo[] vehiculos = new IVehiculo[]
        {
            new Coche("Toyota", "Corolla", 4),
            new Motocicleta("Harley-Davidson", "Iron 883", true)
        };

            foreach (var vehiculo in vehiculos)
            {
                vehiculo.Arrancar();
                vehiculo.MostrarInfo();
                vehiculo.Detener();
                Console.WriteLine();
            }

            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}