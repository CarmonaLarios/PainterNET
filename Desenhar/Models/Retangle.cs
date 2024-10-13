namespace Desenhar.Models
{
    public class Retangle: Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Retangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
