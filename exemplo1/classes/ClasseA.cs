using System;

namespace exemplo1.classes
{
    public class ClasseA
    {
        public int PrimeiroValor;

        public ClasseA()
        {
            
        }
        public void MetodoA()
        {
            Console.WriteLine("Teste MetodoA");
        }

        public int MetodoB()
        {
            return 10;
        }

        public int MetodoC(int valor1, int valor2)
        {
            int valor3 = valor1 + valor2;

            return valor3;
        }
        
    }
}