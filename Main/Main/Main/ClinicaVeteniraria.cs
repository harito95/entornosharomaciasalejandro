using Main.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Main
{
    public class ClinicaVeteniraria
    {

        //atributos

        private List<Animal> animales;

        //objeto

        public ClinicaVeteniraria()
        {
            animales = new List<Animal>();
        }

        //inserta tu animal

        public void InsertaAnimal(Animal animal)
        {
            animales.Add(animal);
        }

        //buscar animal por su nombre

        public Animal BuscaAnimal(string nombre)
        {
            return animales.Find(ani => ani.Nombre.Equals(nombre));
        }

        //modificar metodo de un animal

        public void ModificaComentarioAnimal(string nombre, string nuevoComentario)
        {
            animales.FindAll(ani => ani.Nombre.Equals(nombre)).ForEach(ani => ani.Comentarios = nuevoComentario);
        }

        //tostring

        public override string ToString()
        {
            string retorno = "";
            animales.ForEach(ani => retorno += ani.ToString());
            return retorno;
        }

    }
}
