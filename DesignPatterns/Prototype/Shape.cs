using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Clase abstracta utilizada como prototipo
    /// </summary>
    public abstract class Shape
    {
        private int X;
        private int Y;
        private string color;

        /// <summary>
        /// Constructor genérico
        /// </summary>
        public Shape()
        {
            X = 0;
            Y = 5;
            color = "red";
        }

        /// <summary>
        /// Constructor del prototipo
        /// </summary>
        /// <param name="shape"></param>
        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
            color = shape.color;
        }

        /// <summary>
        /// Método abstracto que permite clonar objetos
        /// </summary>
        /// <returns></returns>
        public abstract Shape Clone();

        // <summary>
        /// Sobrescritura del método ToString(). Para los assert de los unit test.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", X, Y, color);
        }

    }
}
