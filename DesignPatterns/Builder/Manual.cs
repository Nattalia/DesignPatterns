using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Clase que representa el manual de las partes de un coche
    /// </summary>
    public class Manual
    {
        public string SeatsDescription { get; set; }
        public string EngineDescription { get; set; }
        public string TripComputerDescription { get; set; }
        public string GpsDescription { get; set; }
    }
}
