using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes
{
    // INHERITANCE: here Circle  classdisplays inheritance from the Shape class
    public class Circle : Shape
    {
        // ENCAPSULATION: here the getter takes care of the math behind figuring a circumference/Area
        // all a user has to do is call Cirlce.Circumference or Circle.Area and they get the value
        public double Circumference { get => 2 * 3.14159 * Radius; }
        public override double Area { get => 3.14159 * (Radius*Radius); }
        private double Radius {  get; set; }
        public override Color Color { get; set; }

        public Circle(double radius, Color color)
        {
            Radius = radius;
            Color = color;
        }
    }
}
