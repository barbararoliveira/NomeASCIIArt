using System;
using Figgle;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Olá usuário, digite o seu nome (sem acentos) e receba uma ASCII Art: ");
            string nomeu = (Console.ReadLine()); //nomeu= nome do usuário.
            
            string recadoamavel = "Você é incrível, a maior e mais linda obra de arte <3";

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(FiggleFonts.FlowerPower.Render(nomeu));

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(recadoamavel);
        }
    }
}
