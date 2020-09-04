using System;
using System.Collections.Generic;
using OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            // create three colored shapes
            Shape myCircle = new Circle(5, Color.Red);
            Shape myRectangle = new Rectangle(5, 10, Color.Blue);
            Shape myTriangle = new Triangle(5, 9, Color.Green);

            // POLYMORPHISM: here our listOfShapes diplayes polymorphism as all shapes are acting as Object type 'Shape' as well
            // as Circle, Rectangel, and Triangle..
            // create a list of shapes to add to our drawing
            List<Shape> listOfShapes = new List<Shape> { myCircle, myRectangle, myTriangle };

            // create a drawing and call the tostring into the console.
            // Expect: A drawing consisting of 3 Shapes. It is 52.00% red, 33.10% blue, and 14.90% green
            Drawing myDrawing = new Drawing(listOfShapes);
            Console.WriteLine(myDrawing);

            // Expect: 85.7115
            Console.WriteLine($"Lines Drawn: {myDrawing.LinesDrawn}");
            // Expect: 151.0397
            Console.WriteLine($"Space Covered: {myDrawing.SpaceCovered}");


            Shape anotherRectangle = new Rectangle(59.44, 13.89, Color.Red);
            myDrawing.Draw(anotherRectangle);
            Shape anotherTriangle = new Triangle(5.56, 69.44, Color.Blue);
            myDrawing.Draw(anotherTriangle);
            Shape anotherCircle = new Circle(46, Color.Green);
            myDrawing.Draw(anotherCircle);

            Console.WriteLine("\n\nAdding 3 more drawings...");
            Console.WriteLine(myDrawing);

        }
    }
}
