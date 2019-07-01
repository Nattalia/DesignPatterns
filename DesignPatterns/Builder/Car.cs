using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Clase que representa un coche
    /// </summary>
    public class Car
    {
        public int NumberSeats { get; set; }
        public string Engine { get; set; }
        public bool Gps { get; set; }
        public bool TripComputer { get; set; }
    }
}
