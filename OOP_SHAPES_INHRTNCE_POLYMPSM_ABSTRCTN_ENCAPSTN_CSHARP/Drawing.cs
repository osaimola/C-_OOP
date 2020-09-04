using System;
using System.Collections.Generic;
using System.Text;
using OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes;
using System.Linq;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP
{
    class Drawing
    {
        public double SpaceCovered { get => Shapes.Select(x => x.Area).Sum(); }
        public double LinesDrawn
        { 
            get 
            {
                // use linq Where to filter for Triangles/Rectangles/Circles
                // use linq select to return type casted objects for each filtered list
                // use linq select to return the perimeters/circumference of each object
                // use the linq sum to get the sums
                // return the sum of sums to complete the LinesDrawn get
                return (
                    Shapes.Where(x => x.GetType() == typeof(Triangle)).Select(x => (Triangle)x).Select(x => x.Perimeter).Sum()
                    + Shapes.Where(x => x.GetType() == typeof(Rectangle)).Select(x => (Rectangle)x).Select(x => x.Perimeter).Sum()
                    + Shapes.Where(x => x.GetType() == typeof(Circle)).Select(x => (Circle)x).Select(x => x.Circumference).Sum()
                    );
                    
            } 
        }

        private List<Shape> Shapes { get; set; }

        public Drawing(List<Shape> shapes)
        {
            Shapes = shapes;
        }

        public void Draw(Shape shape)
        {
            Shapes.Add(shape);
        }

        public override string ToString()
        {
            double redArea = Shapes.Where(x => x.Color == Color.Red).Select(x => x.Area).Sum();
            double blueArea = Shapes.Where(x => x.Color == Color.Blue).Select(x => x.Area).Sum();
            double greenArea = Shapes.Where(x => x.Color == Color.Green).Select(x => x.Area).Sum();
            return $"A drawing consisting of {Shapes.ToArray().Length} Shapes. It is {redArea/SpaceCovered*100:F2}% red, {blueArea / SpaceCovered * 100:F2}% blue, and {greenArea / SpaceCovered * 100:F2}% green";
        }
    }
}
