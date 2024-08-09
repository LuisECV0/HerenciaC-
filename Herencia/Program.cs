using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    // Clase base
    public class Animal
    {
        // Propiedad para el nombre del animal
        public string Nombre { get; set; }

        // Constructor para inicializar el nombre
        public Animal(string nombre)
        {
            Nombre = nombre;
        }

        // Método virtual que puede ser sobrescrito por clases derivadas
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }
    }

    // Clase derivada que hereda de Animal
    public class Perro : Animal
    {
        // Constructor que llama al constructor de la clase base
        public Perro(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Guau guau!");
        }

        // Método específico de la clase Perro
        public void MoverCola()
        {
            Console.WriteLine($"{Nombre} está moviendo la cola.");
        }
    }

    // Otra clase derivada que hereda de Animal
    public class Gato : Animal
    {
        // Constructor que llama al constructor de la clase base
        public Gato(string nombre) : base(nombre) { }

        // Sobrescribir el método HacerSonido
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} dice: ¡Miau miau!");
        }

        // Método específico de la clase Gato
        public void Ronronear()
        {
            Console.WriteLine($"{Nombre} está ronroneando.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Perro y Gato
            Perro miPerro = new Perro("Rex");
            Gato miGato = new Gato("Misu");

            // Llamar a métodos de las clases derivadas
            miPerro.HacerSonido();
            miPerro.MoverCola();

            miGato.HacerSonido();
            miGato.Ronronear();
        }
    }
}

