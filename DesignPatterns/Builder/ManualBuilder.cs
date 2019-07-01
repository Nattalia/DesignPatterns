using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Clase que crea objetos de tipo Manual
    /// </summary>
    public class ManualBuilder : IBuilder
    {
        private Manual Manual;

        public ManualBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Manual = new Manual();
        }

        public void SetEngine(string engine)
        {
            Manual.EngineDescription = "Engine Description: " + engine;
        }

        public void SetGPS()
        {
            Manual.GpsDescription = "This car is provided with GPS";
        }

        public void SetSeats(int number)
        {
            Manual.SeatsDescription = "This car has " + number + " seats";
        }

        public void SetTripComputer()
        {
            Manual.TripComputerDescription = "This car is provided with Trip Computer";
        }

        public Manual GetManual()
        {
            Manual resultManual = Manual;

            Reset();

            return resultManual;
        }
    }
}
