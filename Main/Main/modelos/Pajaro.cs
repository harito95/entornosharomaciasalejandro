using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.modelos
{
    class Pajaro : Animal
    {
        //atributos

        protected string _especie;
        protected bool _cantador;

        //constructor

        public Pajaro(string _nombre, string _fechaNacimiento, double _peso,
           string _especie, bool _cantador) : base(_nombre, _fechaNacimiento, _peso)
        {
            Especie = _especie;
            Cantador = _cantador;
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
                    throw new ArgumentException("La especie no puede estar vacia.");
                }
            }
        }

        public bool Cantador
        {
            get;
            private set;
        }

        //tostring

        public override string ToString()
        {
            return "\nFicha de [pajarito]" +
                "\nNombre: " + Nombre +
                "\nRaza: " + Especie +
                "\nFechaNacimiento: " + FechaNacimiento +
                "\nPeso: " + Peso +
                "\nCantador: " + Cantador +
                "\nComentarios: " + Comentarios;
        }
    }
}
