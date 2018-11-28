using System;

namespace SimUDuck.Pato
{
    public class Pato
    {
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public void voar()
        {
            Console.WriteLine("Voando");
        }

        public void grasnar()
        {
            Console.WriteLine("Grasnando");
        }

        public void nadar()
        {
            Console.WriteLine("Nadando");
        }
    }
}