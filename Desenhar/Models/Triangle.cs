namespace Desenhar.Models
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea()
        {
            return 0.5 * Base * Height;
        }
    }
}
