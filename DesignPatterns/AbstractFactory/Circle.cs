using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing... [Circle]");
        }
    }
}
