using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Clase que crea objetos de tipo Car
    /// </summary>
    public class CarBuilder : IBuilder
    {
        private Car Car;

        public CarBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            Car = new Car();
        }

        public void SetEngine(string engine)
        {
            Car.Engine = engine;
        }

        public void SetGPS()
        {
            Car.Gps = true;
        }

        public void SetSeats(int number)
        {
            Car.NumberSeats = number;
        }

        public void SetTripComputer()
        {
            Car.TripComputer = true;
        }

        public Car GetCar()
        {
            Car resultCar = Car;

            Reset(); // Buena práctica dejar el objeto reseteado

            return resultCar;
        }
    }
}
