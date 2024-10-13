using System.Drawing;

namespace Desenhar.Models
{
    public abstract class Shape
    {
        public Point Point {  get; set; }
        public Color Color { get; set; }

        public abstract double GetArea();
    }
}
