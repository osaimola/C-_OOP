using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes
{
    public class Rectangle : Shape
    {
        public double Perimeter { get => 2 * (Length + Height); }
        public override double Area { get => Length * Height ;  }
        private double Length { get; set; }
        private double Height { get; set; }
        public override Color Color { get; set; }

        public Rectangle(double length, double height, Color color)
        {
            Height = height;
            Length = length;
            Color = color;
        }

    }
}
