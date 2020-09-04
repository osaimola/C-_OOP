using System;
using OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myCircle = new Circle(5, Color.Red);
            Shape myRectangle = new Rectangle(5, 10, Color.Blue);
            Shape myTriangle = new Triangle(5, 9, Color.Green);
        }
    }
}
