using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public interface IAbstractFactory
    {
        IShape GetShape(string shape);
        IColor GetColor(string color);
    }
}
