using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Pato
{
    public class PatoSelvagem : IPato
    {
        public void grasnar()
        {
            Console.WriteLine("Pato de cabeça vermelha faz cuaque");
        }
    }
}