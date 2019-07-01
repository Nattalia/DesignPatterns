using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Prototipo concreto. Rectangle
    /// </summary>
    public class Rectangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        /// <summary>
        /// Constructor genérico
        /// </summary>
        public Rectangle() : base()
        {

        }

        /// <summary>
        /// Constructor para crear el objeto clonado
        /// </summary>
        /// <param name="rectangle"></param>
        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            width = rectangle.width;
            height = rectangle.height;
        }

        /// <summary>
        /// Método para clonar el objeto
        /// </summary>
        /// <returns></returns>
        public override Shape Clone()
        {
            return new Rectangle(this);
        }

        /// <summary>
        /// Sobrescritura del método ToString(). Para los assert de los unit test.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), width, height);                
        }
    }
}
