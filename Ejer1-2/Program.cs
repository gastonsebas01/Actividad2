using System;

namespace Ejer1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autobus autobus1=new Autobus();
            autobus1.color = "verde";
            autobus1.anio = 2020;
            autobus1.cantAsientos = 33;
            autobus1.cantPuertas = 3;
            autobus1.marca = "Volkswagen";
            autobus1.modelo = "EOD";
            autobus1.nroSerie = 12385;
            autobus1.cantPasajeros = 35;
            autobus1.mostrarAutobus();
            autobus1.cargarPasajeros();
            autobus1.arrancar();
            autobus1.detener();
            autobus1.descargaPasajeros();



            Vehiculo moto1=new Vehiculo();
            moto1.marca = "Honda";
            moto1.modelo = "NXM";
            moto1.nroSerie = 512;
            moto1.color = "rojo";
            moto1.anio = 2019;
            moto1.mostrarVehiculo();
            moto1.arrancar();

            Vehiculo camion = new Vehiculo();
            camion.marca = "Scania";
            camion.modelo = "RGC";
            camion.nroSerie = 856;
            camion.color = "blanco";
            camion.anio = 2018;
            camion.mostrarVehiculo();
            camion.detener();

            Vehiculo auto=new Vehiculo();
            auto.marca = "Ford";
            auto.modelo = "TYN";
            auto.nroSerie = 468;
            auto.color = "azul";
            auto.anio = 2021;
            auto.mostrarVehiculo();
            auto.arrancar();
        }
    }
}
