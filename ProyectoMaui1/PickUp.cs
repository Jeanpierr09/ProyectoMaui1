using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaui1
{
    internal class PickUp : VehiculoBase
    {
        private int capacidadCarga { get; set; }

        private int capacidadPersonas { get; set; }

        public PickUp(String nuevo_dueño, string marca_, string color_, int modelo_, string placa_, string carroceria, int maximavelo, int velociactu, int capacidadCarga_, int capacidadPersonas_) : base(nuevo_dueño, marca_, color_, modelo_, placa_, carroceria, maximavelo, velociactu)
        {
            this.capacidadCarga = capacidadCarga_;
            this.capacidadPersonas = capacidadPersonas_;
        }

        private void cargar()
        {
            Console.WriteLine("La camioneta esta cargada");
        }

        private void descargar()
        {
            Console.WriteLine("La camioneta esta descargada");
        }
    }
}
