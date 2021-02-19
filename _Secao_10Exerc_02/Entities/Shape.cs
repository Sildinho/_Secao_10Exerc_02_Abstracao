using _Secao_10Exerc_02.Entities.Enums;

// aula 136. Exercício resolvido - prof. nelio alves(C#)
namespace _Secao_10Exerc_02.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}