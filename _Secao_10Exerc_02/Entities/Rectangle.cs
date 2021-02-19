using _Secao_10Exerc_02.Entities.Enums;

// aula 136. Exercício resolvido - prof. nelio alves(C#)
namespace _Secao_10Exerc_02.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}
