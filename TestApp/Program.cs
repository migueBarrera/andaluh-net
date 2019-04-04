using System;
using Andaluh;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Andaluh.EPA.Transcribe("Llavero");
            var newREsult = "Esto es una prueba de transcripción con el modo debug activo para ver cómo va cambiando la frase cada regla".ToAndaluh();
            Console.WriteLine("------------------RESULT=>"+ newREsult);
        }
    }
}
