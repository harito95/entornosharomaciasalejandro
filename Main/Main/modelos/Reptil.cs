using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.modelos
{
    class Reptil:Animal
    {
        //atributos

        protected string _especie;
        protected bool _venenoso;

        //constructor

        public Reptil(string _nombre, string _fechaNacimiento, double _peso,
           string _especie, bool _venenoso) : base(_nombre, _fechaNacimiento, _peso)
        {
            Especie = _especie;
            Venenoso = _venenoso;
        }

        //propiedades

        public string Especie
        {
            get { return _especie; }
            private set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    _especie = value;
                }
                else
                {
                    throw new ArgumentException("La raza no puede estar vacia.");
                }
            }
        }

        public bool Venenoso
        { get;
        private set; }

        //tostring

        public override string ToString()
        {
            return "\nFicha de [Reptil]" +
                "\nNombre: " + Nombre +
                "\nRaza: " + Especie +
                "\nFechaNacimiento: " + FechaNacimiento +
                "\nPeso: " + Peso +
                "\nVenenoso: " + Venenoso +
                "\nComentarios: " + Comentarios;
        }
    }
}
