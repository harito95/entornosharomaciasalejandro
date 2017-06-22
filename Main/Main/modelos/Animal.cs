using Main.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.modelos
{
    public abstract class Animal: Ipesable
    {
        
         //Atributos
         
        protected string _nombre;
        protected string _fechaNacimiento;
        protected string _comentarios;
        protected double _peso;

        public Animal(string _nombre, string _fechaNacimiento, double _peso)
        {
            Nombre = _nombre;
            FechaNacimiento = _fechaNacimiento;
            Peso = _peso;
        }

        //Propiedades

        public string Nombre
        {
            get { return _nombre; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _nombre = value;
                }
                else
                {
                    throw new ArgumentException("Nombre no puede estar vacío.");
                }
            }
        }

        public string FechaNacimiento
        {
            get { return _fechaNacimiento; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _fechaNacimiento = value;
                }
                else
                {
                    throw new ArgumentException("Fecha no puede estar vacio.");
                }
            }
        }

        public string Comentarios
        {
            get { return _comentarios; }
            set
            {
                if (value != null)
                {
                    _comentarios = value;
                }
                else
                {
                    throw new ArgumentNullException("Comentario no puede ser null. Introduzca cadena vacía.");
                }
            }
        }

        public double Peso
        {
            get { return _peso; }
            private set
            {
                if (value >= 0.01 && value <= 100)
                {
                    _peso = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Peso no valido");
                }
            }
        }



        //Metodos
        public void Pesar(double _peso)
        {
            Peso = _peso;
        }

    }
}
