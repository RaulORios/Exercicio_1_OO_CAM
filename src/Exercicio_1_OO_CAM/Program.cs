using System;
using System.Globalization;

namespace Exercicio_1_OO_CAM
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre a Largura e Altura do Retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"AREA = {r.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
