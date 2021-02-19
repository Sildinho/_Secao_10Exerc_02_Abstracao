using System;
using _Secao_10Exerc_02.Entities.Enums;

// aula 136. Exercício resolvido - prof. nelio alves(C#)
namespace _Secao_10Exerc_02.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}