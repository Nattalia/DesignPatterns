using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public enum ShapeType
    {
        Circle, 
        Square, 
        Rectangle
    }

    public class ShapeFactory
    {
        public IShape getShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();                    
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Rectangle:
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
