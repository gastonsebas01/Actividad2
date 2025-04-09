using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer3
{
    public class Animal
    {
        public string especie;
        public string genero;
        public int edad;
        public string tamanio;
        public string sonido;

        public void alimentar()
        {
            Console.WriteLine("El "+especie+" esta comiendo.");
        }
        public void reproducir()
        {
            Console.WriteLine("El "+especie+" se esta reproduciendo.");
        }
        public void sonidos()
        {
            Console.WriteLine("El "+especie+ " esta "+sonido);
        }
        public void mostrarAnimal()
        {
            string especie = this.especie;
            string genero = this.genero;
            string tamanio = this.tamanio;
            string sonido = this.sonido;
            int edad = this.edad;

            Console.WriteLine(especie + '\n' +genero + '\n' + tamanio + '\n' + edad+" años");
        }
    }
}
