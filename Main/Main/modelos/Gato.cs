using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.modelos
{
    class Gato : Animal
    {

        //atributos

        protected string _raza;
        protected string _microchip;

        //constructor

        public Gato(string _nombre, string _fechaNacimiento, double _peso,
           string _raza, string _microchip) : base(_nombre, _fechaNacimiento, _peso)
        {
            Raza = _raza;
            Microchip = _microchip;
        }

        //propiedades

        public string Raza
        {
            get { return _raza; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _raza = value;
                }
                else
                {
                    throw new ArgumentException("La raza no puede estar vacia.");
                }
            }
        }


        public string Microchip
        {
            get { return _microchip; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _microchip = value;
                }
                else
                {
                    throw new ArgumentException("Microchip no puede ser nula ni vacía.");
                }
            }
        }

        //tostring

        public override string ToString()
        {
            return "\nFicha de [Gato]" +
                "\nNombre: " + Nombre +
                "\nRaza: " + Raza +
                "\nFechaNacimiento: " + FechaNacimiento +
                "\nPeso: " + Peso +
                "\nChip: " + Microchip +
                "\nComentarios: " + Comentarios;
        }

    }
}
