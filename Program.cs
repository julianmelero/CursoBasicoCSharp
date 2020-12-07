using System;

namespace CursoBasicoCSharp
{
    class Program
    {
        static public void declaracion()
        {
            int number = 10;
            double numberDecimal = 0.0d;
            bool yayOrnay = true;
            string hello = "This is a text!";
            Console.WriteLine(typeof(int));
            Console.WriteLine(hello);

        }
        static void Main(string[] args)
        {

            declaracion();
            // Llamamos a la clase
            Song song = new Song();
            
            song.Title = "My title";
            song.Play();
            Console.ReadKey();

        }
    }
}
