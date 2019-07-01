using DesignPatterns.Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class Builder
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BuildSportsCar()
        {
            Director Director = new Director();

            // Construimos SportsCar
            CarBuilder carBuilder = new CarBuilder();
            Director.SetBuilder(carBuilder);
            Director.BuildSportsCar();
            Car Car = carBuilder.GetCar();

            // Construimos el manual del SportsCar
            ManualBuilder manualBuilder = new ManualBuilder();
            Director.SetBuilder(manualBuilder);
            Director.BuildSportsCar();
            Manual Manual = manualBuilder.GetManual();

            Assert.AreEqual(Car.Engine, "sport");
            Assert.AreEqual(Manual.EngineDescription, "Engine Description: sport");
        }

        [Test]
        public void BuildSuvCar()
        {
            Director Director = new Director();

            // Construimos SuvCar
            CarBuilder carBuilder = new CarBuilder();
            Director.SetBuilder(carBuilder);
            Director.BuildSuvCar();
            Car Car = carBuilder.GetCar();

            // Construimos el manual del SuvCar
            ManualBuilder manualBuilder = new ManualBuilder();
            Director.SetBuilder(manualBuilder);
            Director.BuildSuvCar();
            Manual Manual = manualBuilder.GetManual();

            Assert.AreEqual(Car.Engine, "suv");
            Assert.AreEqual(Manual.EngineDescription, "Engine Description: suv");
        }

        [Test]
        public void BuildBus()
        {
            Director Director = new Director();

            // Construimos Bus
            CarBuilder carBuilder = new CarBuilder();
            Director.SetBuilder(carBuilder);
            Director.BuildBus();
            Car Car = carBuilder.GetCar();

            // Construimos el manual del Bus
            ManualBuilder manualBuilder = new ManualBuilder();
            Director.SetBuilder(manualBuilder);
            Director.BuildBus();
            Manual Manual = manualBuilder.GetManual();

            Assert.AreEqual(Car.Engine, "bus");
            Assert.AreEqual(Manual.EngineDescription, "Engine Description: bus");
        }
    }
}
