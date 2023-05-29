using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMaui1
{
    internal class VehiculoBase : IVehiculo
    {
        public string dueño { get; set; }

        public string marca { get; set; }

        public string modelo { get; set; }

        public string color { get; set; }

        public int anio { get; set; }

        public string placa { get; set; }

        public string tipo { get; set; }

        public int velocidadMaxima { get; }

        public int velocidadActual { get; }

        public VehiculoBase(String nuevo_dueño, string marca_, string color_, int modelo_, string placa_, string carroceria, int maximavelo, int velociactu)
        {
            this.dueño = nuevo_dueño;
            this.marca = marca_;
            this.color = color_;
            this.anio = modelo_;
            this.placa = placa_;
            this.tipo = carroceria;
            this.velocidadMaxima = maximavelo;
            this.velocidadActual = velociactu;

            Console.WriteLine($"Se ha creado un vehiculo para {this.dueño}, tu carro ha sido creado");
        }
        public VehiculoBase()
        {

        }

        public void bocina()
        {
            Console.Beep();
        }
        private int llave = 0;
        public void acelerar(int cuanto)
        {

            if (llave == 1)
            {
                Console.WriteLine($"La velocidad actual es de {0}" + cuanto);
            }
            else
            {
                Console.WriteLine("El carro esta apago, no es posible acelerar");
            }
        }

        public void encender()
        {
            Console.WriteLine("El carro ha sido encendido");
            llave = 1; 
        }

        public void apagar()
        {
            Console.WriteLine("El carro ha sido apagado");
            llave = 0;
        }

        public void frenar(int cuanto)
        {
            if (llave == 1)
            {
                Console.WriteLine($"La velocidad actual es de {0}" + cuanto);
            }
            else
            {
                Console.WriteLine("El carro esta apago, no es posible frenar");
            }
        }
    }
}
