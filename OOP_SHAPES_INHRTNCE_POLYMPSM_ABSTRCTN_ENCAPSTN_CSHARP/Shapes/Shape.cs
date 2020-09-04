using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_SHAPES_INHRTNCE_POLYMPSM_ABSTRCTN_ENCAPSTN_CSHARP.Shapes
{
    public enum Color { 
        Red, 
        Blue,
        Green
    }

    // ABSTRACTION: Here the Shape class abstracts all the necesarry properties to create
    // a shape. in this case, shpes must have an area and a color
    public abstract class Shape
    {
        abstract public double Area { get; }

        abstract public Color Color { get; set; }
    }
}
