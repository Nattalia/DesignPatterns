using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing... [Square]");
        }
    }
}
