using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Clase que realiza las llamadas al Builder para construir los objetos correspondientes
    /// </summary>
    public class Director
    {
        private IBuilder Builder;

        /// <summary>
        /// El Director trabaja con cualquier instancia de builder que el cliente le pasa.
        /// En este caso puede crear coches y puede crear manuales
        /// </summary>
        /// <param name="builder"></param>
        public void SetBuilder(IBuilder builder)
        {
            Builder = builder;
        }

        public void BuildSportsCar()
        {
            Builder.Reset();
            Builder.SetSeats(2);
            Builder.SetEngine("sport");
            Builder.SetGPS();
            Builder.SetTripComputer();
        }

        public void BuildSuvCar()
        {
            Builder.Reset();
            Builder.SetSeats(4);
            Builder.SetEngine("suv");
            Builder.SetGPS();            
        }

        public void BuildBus()
        {
            Builder.Reset();            
            Builder.SetSeats(55);
            Builder.SetEngine("bus");
        }
    }
}
