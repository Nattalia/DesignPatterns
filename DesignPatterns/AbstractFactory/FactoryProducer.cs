using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class FactoryProducer
    {
        public IAbstractFactory getFactory(string option)
        {
            switch (option)
            {
                case "shape":
                    return new ShapeFactory();
                case "color":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
