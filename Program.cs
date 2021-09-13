using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, media;

            Console.Beep();
            Console.Clear();
            Console.Write("Digite o 1º número : ");
            n1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número : ");
            n2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o 3º número : ");
            n3 = double.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.Write($"\nMédia : ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(media);
            Console.ResetColor();
        }
    }
}
