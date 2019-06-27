using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class ShapeFactory : IAbstractFactory
    {
        public IColor GetColor(string color)
        {
            return null;
        }

        public IShape GetShape(string shape)
        {
            switch (shape)
            {
                case "circle":
                    return new Circle();
                case "square":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}
