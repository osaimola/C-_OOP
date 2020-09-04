using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes
{
    public class Triangle : Shape
    {
        public double Perimeter { get => Height + Width + (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width,2))); }
        public override double Area { get => 0.5 * Height * Width; }
        private double Width { get; set; }
        private double Height { get; set; }
        public override Color Color { get; set; }

        public Triangle(double width, double height, Color color)
        {
            Width = width;
            Height = height;
            Color = color;
        }
    }
}
