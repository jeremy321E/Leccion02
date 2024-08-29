using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección2
{
    public class Coche : Vehiculo
    {
        public int NumeroPuertas { get; private set; }

        public Coche(string marca, string modelo, int numeroPuertas) : base(marca, modelo)
        {
            NumeroPuertas = numeroPuertas;
        }

        // Implementación específica de Arrancar y Detener
        public override void Arrancar()
        {
            Console.WriteLine($"{Marca} {Modelo} está arrancando con el motor...");
        }

        public override void Detener()
        {
            Console.WriteLine($"{Marca} {Modelo} está detenido en el estacionamiento.");
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"Número de puertas: {NumeroPuertas}");
        }
    }
}
