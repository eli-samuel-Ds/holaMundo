using System;

namespace LearningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            // 1. Declaración de variables:
            // Las variables se declaran especificando primero el tipo y luego el nombre.
            // El estándar recomienda usar CamelCase para variables locales.
            int numeroEntero = 10; // Variable de tipo entero.
            double numeroDecimal = 20.5; // Variable de tipo decimal.
            string texto = "Hola, C#"; // Variable de tipo cadena de texto.
            bool esVerdad = true; // Variable de tipo booleano.

            // 2. Imprimir en pantalla:
            Console.WriteLine("Hola, este es un ejemplo de impresión en pantalla.");
            Console.WriteLine($"Número entero: {numeroEntero}, Número decimal: {numeroDecimal}");

            // 3. Entrada de datos por parte del usuario:
            Console.WriteLine("Introduce tu nombre:");
            string nombreUsuario = Console.ReadLine(); // Lee texto ingresado por el usuario.
            Console.WriteLine($"Hola, {nombreUsuario}!");

            // 4. Condicionales: if, else if, else
            Console.WriteLine("Introduce tu edad:");
            int edad = int.Parse(Console.ReadLine()); // Convierte la entrada a un número entero.
            if (edad < 18)
            {
                Console.WriteLine("Eres menor de edad.");
            }
            else if (edad >= 18 && edad <= 65)
            {
                Console.WriteLine("Eres adulto.");
            }
            else
            {
                Console.WriteLine("Eres adulto mayor.");
            }

            // 5. Bucle for
            Console.WriteLine("Bucle for: Números del 1 al 5:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Número: {i}");
            }

            // 6. Bucle while
            Console.WriteLine("Bucle while: Introduce un número mayor a 0 para continuar.");
            int numero = int.Parse(Console.ReadLine());
            while (numero > 0)
            {
                Console.WriteLine($"Número ingresado: {numero}");
                Console.WriteLine("Introduce otro número (0 o menor para salir):");
                numero = int.Parse(Console.ReadLine());
            }

            // 7. Bucle foreach (opcional)
            Console.WriteLine("Bucle foreach: Mostrando una lista de nombres.");
            string[] nombres = { "Ana", "Luis", "María", "Juan" };
            foreach (string nombre in nombres)
            {
                Console.WriteLine($"Nombre: {nombre}");
            }

            // 8. Finalizando el programa
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar.
        }
    }
}
