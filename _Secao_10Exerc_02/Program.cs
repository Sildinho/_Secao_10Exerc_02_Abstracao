using System;
using System.Collections.Generic;
using System.Globalization;
using _Secao_10Exerc_02.Entities;
using _Secao_10Exerc_02.Entities.Enums;

// aula 136. Exercício resolvido - prof. nelio alves(C#)
namespace _Secao_10Exerc_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.Write("Digite o número de figuras (formas): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Figura #{i} Informações:");

                Console.Write("Retangulo ou Circulo (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("Raio: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(radius, color));
                    Console.WriteLine();
                }
            }
                        
            Console.WriteLine("AREAS DAS FIGURAS:");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}