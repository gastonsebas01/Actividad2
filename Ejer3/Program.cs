using System;

namespace Ejer3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal gato=new Animal();
            gato.especie = "felino";
            gato.edad = 3;
            gato.tamanio = "mediano";
            gato.genero = "hembra";
            gato.sonido = "maullando";
            gato.mostrarAnimal();
            gato.alimentar();

            Animal raton=new Animal();
            raton.especie = "roedor";
            raton.edad = 1;
            raton.tamanio = "pequenio";
            raton.genero = "macho";
            raton.sonido = "chillando";
            raton.mostrarAnimal();
            raton.reproducir();

            Animal caballo=new Animal();
            caballo.especie = "equino";
            caballo.edad = 10;
            caballo.tamanio = "grande";
            caballo.genero = "macho";
            caballo.sonido = "relinchando";
            caballo.mostrarAnimal();
            caballo.sonidos();

        }
    }
}
