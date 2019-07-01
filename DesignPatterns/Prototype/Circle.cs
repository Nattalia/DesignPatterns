using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Prototipo concreto: Circle
    /// </summary>
    public class Circle : Shape
    {
        public int radius { get; set; }

        /// <summary>
        /// Constructor genérico
        /// </summary>
        public Circle() : base()
        {

        }

        /// <summary>
        /// Constructor para crear el objeto clonado
        /// </summary>
        /// <param name="circle"></param>
        public Circle(Circle circle) : base(circle)
        {
            radius = circle.radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }

        /// <summary>
        /// Sobrescritura del método ToString(). Para los assert de los unit test.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1}", base.ToString(), radius);
        }
    }
}
