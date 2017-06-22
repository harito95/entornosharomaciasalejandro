using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Lectura
{
    public class Lector
    {
        
        //Crea un nuevo objeto tipo lector.
         
        public Lector()
        {
        }

        //leer string

        public string leerString()
        {
            string s = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(s))
            {
                Console.WriteLine("[ERROR] La cadena de texto está vacía. Introdúcela de nuevo:");
                s = Console.ReadLine();
            }
            return s;
        }

        //leer booleano

        public bool leerBoolean()
        {
            string s = "";
            bool retorno = true;
            bool error = true;

            do
            {
                Console.WriteLine("(si/no)");
                s = Console.ReadLine().ToLower();
                if (s.Equals("si"))
                {
                    retorno = true;
                    error = false;
                }
                else if (s.Equals("no"))
                {
                    retorno = false;
                    error = false;
                }
                else
                {
                    Console.WriteLine("Dato no válido introducido");
                    error = true;
                }
            } while (error);
            return retorno;
        }

        //leer entero

        public int leerInt(int min, int max)
        {
            string aux = "";
            int i = 0;
            bool error = true;
            do
            {
                Console.WriteLine("(Número entero entre " + min + " y " + max + ")");
                try
                {
                    aux = Console.ReadLine();
                    i = Int32.Parse(aux);
                    if (i >= min && i <= max)
                        error = false;
                    else
                        Console.WriteLine("[ERROR] Número introducido fuera de rango");
                }
                catch (Exception e)
                {
                    Console.WriteLine(("[ERROR] Dato no válido introducido"));
                    error = true;
                }
            } while (error);
            return i;
        }

       //leer double

        public double leerDouble(double min, double max)
        {
            string aux = "";
            double d = 0;
            bool error = true;
            do
            {
                Console.WriteLine("(Número entero entre " + min + " y " + max + ")");
                try
                {
                    aux = Console.ReadLine();
                    d = Double.Parse(aux);
                    if (d >= min && d <= max)
                        error = false;
                    else
                        Console.WriteLine("[ERROR] Número introducido fuera de rango");
                }
                catch (Exception e)
                {
                    Console.WriteLine(("[ERROR] Dato no válido introducido"));
                    error = true;
                }
            } while (error);
            return d;
        }
    }
}
