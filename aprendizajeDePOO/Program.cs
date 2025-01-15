using System;

namespace LearningPOO
{
    // 1. Definición de una clase:
    // Una clase es un modelo que define las propiedades y métodos de un objeto.
    class Persona
    {
        // 2. Propiedades (atributos):
        // Estas definen las características de un objeto.
        public string Nombre { get; set; } // Propiedad con getter y setter automáticos.
        public int Edad { get; set; }

        // 3. Constructor:
        // Un constructor inicializa los objetos de la clase.
        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        // 4. Métodos:
        // Las acciones que los objetos de la clase pueden realizar.
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }

        // Método adicional para verificar si la persona es mayor de edad.
        public bool EsMayorDeEdad()
        {
            return Edad >= 18;
        }
    }

    // Clase derivada para mostrar el concepto de herencia.
    class Estudiante : Persona
    {
        // Nueva propiedad específica de la clase derivada.
        public string Escuela { get; set; }

        // Constructor que utiliza el constructor de la clase base (Persona).
        public Estudiante(string nombre, int edad, string escuela) : base(nombre, edad)
        {
            Escuela = escuela;
        }

        // Sobrescribiendo un método de la clase base.
        public void PresentarseComoEstudiante()
        {
            Console.WriteLine($"Hola, soy {Nombre}, tengo {Edad} años y estudio en {Escuela}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 5. Crear un objeto:
            // Instanciación de un objeto usando el constructor.
            Persona persona1 = new Persona("Juan", 25);
            persona1.Saludar();

            // Verificar si es mayor de edad.
            if (persona1.EsMayorDeEdad())
            {
                Console.WriteLine($"{persona1.Nombre} es mayor de edad.");
            }
            else
            {
                Console.WriteLine($"{persona1.Nombre} es menor de edad.");
            }

            // 6. Herencia:
            // Crear un objeto de la clase derivada.
            Estudiante estudiante1 = new Estudiante("Ana", 20, "Universidad Nacional");
            estudiante1.PresentarseComoEstudiante();

            // 7. Polimorfismo:
            // Llamar métodos de la clase base desde un objeto de la clase derivada.
            estudiante1.Saludar();

            // 8. Ejemplo de encapsulamiento:
            // Uso de getters y setters automáticos para acceder a las propiedades.
            estudiante1.Escuela = "Instituto Tecnológico";
            Console.WriteLine($"Ahora {estudiante1.Nombre} estudia en {estudiante1.Escuela}.");

            // 9. Finalizando el programa.
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
