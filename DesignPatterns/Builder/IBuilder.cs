using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Interfaz para construir varios tipos de coches diferentes (mismo objeto) pero también los manuales (objeto diferente)
    /// </summary>
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(string engine);
        void SetTripComputer();
        void SetGPS();
    }
}
