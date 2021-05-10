using System;

namespace Triangulo.ConsoleApp
{
    public class Program
    {
        static Controlador controlador = new Controlador();
        static void Main(string[] args)
        {
            controlador.x = 1;
            controlador.y = 2;
            controlador.z = 3;
            controlador.CalcularTriangulos();
        }
    }
}
