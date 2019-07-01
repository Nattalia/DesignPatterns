using DesignPatterns.Prototype;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class Prototype
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CloneRectangle()
        {
            // Creamos un rectángulo
            Rectangle rectangle1 = new Rectangle();            
            rectangle1.width = 20;
            rectangle1.height = 30;
            
            // Clonamos el rectángulo anterior
            Rectangle rectangle2 = (Rectangle)rectangle1.Clone();            

            Assert.AreEqual(rectangle1.ToString(), rectangle2.ToString());
        }

        [Test]
        public void CloneCircle()
        {
            // Creamos un rectángulo
            Circle circle1 = new Circle();
            circle1.radius = 25;

            // Clonamos el rectángulo anterior
            Circle circle2 = (Circle)circle1.Clone();

            Assert.AreEqual(circle1.ToString(), circle2.ToString());
        }
    }
}
