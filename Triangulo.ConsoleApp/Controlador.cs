using System;
using System.Collections.Generic;
using System.Text;


namespace Triangulo.ConsoleApp
{
    public class Controlador 
    {
        public int x;
        public int y;
        public int z;
        public void CalcularTriangulos()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triangulo Eqüilátero");
            }
            else if (x == y || y == z || x == z)
            {
                Console.WriteLine("Triangulo Isósceles");
            }
            else if (x != y || y != z || x != z)
            {
                Console.WriteLine("Triangulo Escaleno");
            }
            else
            {
                Console.WriteLine("Triangulo Inválido");
            }
        }
    }
}


