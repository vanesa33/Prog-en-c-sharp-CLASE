using System;

namespace clase
{
    class Program
    {

        static void Main(string[] args)
        {
            Ventana calculadora = new Ventana();

            calculadora.cerrar();
            calculadora.maximizar();

            Console.ReadKey();

        }

               
    }

    class Ventana
    {
        private int ancho = 15, altura = 20;
        private string color = "rojo";

        //metodo
        public void cerrar()
        {
            Console.WriteLine("la ventana se cerro");

        }
        public void minimizar()
        {
            Console.WriteLine("la ventana se minimizo");

        }
        public void maximizar()
        {
            Console.WriteLine(" la ventana se agrando");

        }
    }

}
