//Así se realiza un comentario
//link de este lenguaje de programción: https://dotnet.microsoft.com/es-es/languages/csharp

// Acorta los comandos de entrada y salida de consola
using System;
using System.Threading.Tasks;


class shundizora 
{
    private static char letra = 'a'; /caracter debe estar entre ''
    private static string cadena = "Cadena de texto"; /texto completo debe estar entre ""
    private static int numeroEntero = 10; //Constante entera
    private static double numeroNegativo = -10; //Constante Negativa
    private static float numeroDecimal = 5.5; //Constante decimal
    private static float variableDependiente = numeroDecimal; //Variable dependiente
    private static string lenguaje = "C#"; //Declarar Lenguaje de programación para pimprimirlo luego
    private static bool boolean = false;   //Booleano
//Imprimir el primer Hola + lenguaje de programación    
    static void Main(string[] args)
    {
       Console.WriteLine($"Hola {lenguaje}!");
    }

}
