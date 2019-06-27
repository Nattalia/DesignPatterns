using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing... [Circle]");
        }
    }
}
