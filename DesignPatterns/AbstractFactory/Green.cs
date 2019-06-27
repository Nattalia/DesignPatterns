using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class Green : IColor
    {
        public void Paint()
        {
            Console.WriteLine("Painting... [Green]");
        }
    }
}
