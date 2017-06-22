using Main.Lectura;
using Main.Main;
using Main.modelos;
using System;

namespace Main
{
    class Program
    {

        //clases

        ClinicaVeteniraria cv;
        Lector leer;

        static void Main(string[] args)
        {

            Program p = new Program();
        }

        public Program()
        {
            cv = new ClinicaVeteniraria();
            leer = new Lector();
            Menu();
        }

        //Menu

        private void Menu()
        {
            bool salir = false;
            int opcion = 0;

       
            Console.WriteLine("Bienvenido a la Clínica Veterinaria");
            do
            {
                Console.WriteLine("\n elija una opción:");
                Console.WriteLine("1.- Aniadir animales de los diferentes tipos");
                Console.WriteLine("2.- Modificar los comentarios");
                Console.WriteLine("3.- Pesar animal");
                Console.WriteLine("4.- Mostrar por pantalla la ficha de un animal");
                opcion = leer.leerInt(0, 4);
                switch (opcion)
                {
                    case 0:
                        salir = true;
                        break;
                    case 1:
                        aniadirNuevoAnimal();
                        break;
                    case 2:
                        modificarComentarios();
                        break;
                    case 3:
                        pesarAnimal();
                        break;
                    case 4:
                        mostrarFicha();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }

            } while (!salir);

        }

        //añadir tipo de animal(submenu)
        
        private void aniadirNuevoAnimal()
        {
            string nombre;
            string fechaNacimiento;
            double peso;
            int eleccion = 0;

            Console.WriteLine("¿Qué animal desea añadir?");
            Console.WriteLine("1- Perro.");
            Console.WriteLine("2- Gato.");
            Console.WriteLine("3- Pájaro.");
            Console.WriteLine("4- Reptil.");
            eleccion = leer.leerInt(1, 4);
            Console.WriteLine("Introduce nombre:");
            nombre = leer.leerString();
            Console.WriteLine("Introduce fecha de nacimiento:");
            fechaNacimiento = leer.leerString();
            Console.WriteLine("Introduce peso:");
            peso = leer.leerDouble(0.01, 100);

            switch (eleccion)
            {
                // Perro
                case 1:
                    string raza, microchip;
                    Console.WriteLine("Introduce raza:");
                    raza = leer.leerString();
                    Console.WriteLine("Introduce microchip:");
                    microchip = leer.leerString();
                    Perro pe = new Perro(nombre, fechaNacimiento, peso, raza, microchip);
                    cv.InsertaAnimal(pe);
                    Console.WriteLine(pe + "\nHas añadido al perro con exito.");
                    break;
                // Gato
                case 2:
                    Console.WriteLine("Introduce raza:");
                    raza = leer.leerString();
                    Console.WriteLine("Introduce microchip:");
                    microchip = leer.leerString();
                    Gato g = new Gato(nombre, fechaNacimiento, peso, raza, microchip);
                    cv.InsertaAnimal(g);
                    Console.WriteLine(g + "\nHas añadido al gato con éxito.");
                    break;
                // Pájaro
                case 3:
                    String especie;
                    bool cantor;
                    Console.WriteLine("Introduce especie:");
                    especie = leer.leerString();
                    Console.WriteLine("¿Es cantor?");
                    cantor = leer.leerBoolean();
                    Pajaro pa = new Pajaro(nombre, fechaNacimiento, peso, especie, cantor);
                    cv.InsertaAnimal(pa);
                    Console.WriteLine(pa + "\nHas añadido al pajaro con éxito.");
                    break;
                // Reptil
                case 4:
                    bool venenoso;
                    Console.WriteLine("Introduce especie:");
                    especie = leer.leerString();
                    Console.WriteLine("¿Es venenoso?");
                    venenoso = leer.leerBoolean();
                    Reptil r = new Reptil(nombre, fechaNacimiento, peso, especie, venenoso);
                    cv.InsertaAnimal(r);
                    Console.WriteLine(r + "\nHas añadido al reptil con éxito.");
                    break;
                default:
                    Console.WriteLine("[ERROR] Opción no válida introducida.");
                    break;
            }
        }

        //modificacion de comentario

        private void modificarComentarios()
        {
            string nombre, nuevo_Comentario;
            Console.WriteLine("Introduce el nombre del animal:");
            nombre = leer.leerString();
            Console.WriteLine("Introduce el nuevo comentario:");
            nuevo_Comentario = leer.leerString();
            cv.ModificaComentarioAnimal(nombre, nuevo_Comentario);
        }

        
        //modificacion del peso

        private void pesarAnimal()
        {
            string nombre;
            double kilogramos;
            Console.WriteLine("Introduce el nombre del animal:");
            nombre = leer.leerString();
            Console.WriteLine("Introduce el nuevo peso:");
            kilogramos = leer.leerDouble(0, 100);

            cv.BuscaAnimal(nombre).Pesar(kilogramos);
            Console.WriteLine("El animal pesa: " + kilogramos);
        }

        //ficha

        private void mostrarFicha()
        {
            string nombre;
            Console.WriteLine("Introduce el nombre del animal:");
            nombre = leer.leerString();
            Console.WriteLine(cv.BuscaAnimal(nombre));
        }
    }
}
