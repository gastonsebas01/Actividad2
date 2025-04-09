using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1_2
{
    public class Vehiculo
    {
        public string modelo;
        public string marca;
        public int nroSerie;
        public string color;
        public int anio;

        public void arrancar()
        {
            Console.WriteLine("El vehiculo esta arrancando.");
        }
        public void frenar()
        {
            Console.WriteLine("El vehiculo esta frenando.");
        }
        public void acelerar()
        {
            Console.WriteLine("El vehiculo esta acelerando.");
        }
        public void detener()
        {
            Console.WriteLine("El vehiculo se esta deteniendo.");
        }
        public void mostrarVehiculo()
        {
           string modelo=this.modelo;
           string marca = this.marca;
           int nroSerie=this.nroSerie;
           string color=this.color;
           int anio=this.anio;

            Console.WriteLine(marca+'\n'+ modelo+ '\n'+ nroSerie+ '\n'+ color+ '\n'+ anio);
        }

    }
    public class Autobus : Vehiculo
    {
        public int cantPasajeros;
        public int cantAsientos;
        public int cantPuertas;

        public void cargarPasajeros()
        {
            Console.WriteLine("El autobus esta cargando pasajeros.");
        }
        public void descargaPasajeros()
        {
            Console.WriteLine("El autobus esta descargando pasajeros.");
        }
        public void mostrarAutobus() {
            Console.WriteLine("marca: " + marca);
            Console.WriteLine("modelo: "+modelo);
            Console.WriteLine("color: " + color);
            Console.WriteLine("nro de serie: "+nroSerie);
            Console.WriteLine("año: "+anio);
            Console.WriteLine("pasajeros: "+cantPasajeros);
            Console.WriteLine("asientos: "+cantAsientos);
            Console.WriteLine("puertas: "+cantPuertas);
        }
        
    }
}
