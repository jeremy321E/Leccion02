using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección2
{
    public class Motocicleta : Vehiculo
    {
        public bool TieneSidecar { get; private set; }

        public Motocicleta(string marca, string modelo, bool tieneSidecar) : base(marca, modelo)
        {
            TieneSidecar = tieneSidecar;
        }

        // Implementación específica de Arrancar y Detener
        public override void Arrancar()
        {
            Console.WriteLine($"{Marca} {Modelo} está arrancando con el motor de motocicleta...");
        }

        public override void Detener()
        {
            Console.WriteLine($"{Marca} {Modelo} está detenido en la calle.");
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();
            Console.WriteLine($"¿Tiene sidecar?: {(TieneSidecar ? "Sí" : "No")}");
        }
    }
}
