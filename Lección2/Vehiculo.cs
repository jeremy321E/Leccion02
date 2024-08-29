using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección2
{
    public class Vehiculo : IVehiculo
    {
        // Encapsulamiento de las propiedades
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }

        // Constructor para inicializar las propiedades
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        // Métodos que pueden ser sobrescritos en las clases derivadas
        public virtual void Arrancar()
        {
            Console.WriteLine($"{Marca} {Modelo} está arrancando...");
        }

        public virtual void Detener()
        {
            Console.WriteLine($"{Marca} {Modelo} está detenido.");
        }

        // Método común para mostrar información
        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }

}
