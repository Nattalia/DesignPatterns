using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class ColorFactory : IAbstractFactory
    {
        public IColor GetColor(string color)
        {
            switch (color)
            {
                case "red":
                    return new Red();
                case "green":
                    return new Green();
                default:
                    return null;
            }
        }

        public IShape GetShape(string shape)
        {
            return null;
        }
    }
}
