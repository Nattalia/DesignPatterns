using DesignPatterns.AbstractFactory;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class AbstractFactory
    { 
        FactoryProducer factoryProducer = new FactoryProducer();
        IAbstractFactory abstractFactory;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateCircleObject()
        {
            abstractFactory = factoryProducer.getFactory("shape");
            IShape shape = abstractFactory.GetShape("circle");

            Assert.IsInstanceOf<Circle>(shape);
        }

        [Test]
        public void CreateSquareObject()
        {
            abstractFactory = factoryProducer.getFactory("shape");
            IShape shape = abstractFactory.GetShape("square");

            Assert.IsInstanceOf<Square>(shape);
        }

        [Test]
        public void CreateRedObject()
        {
            abstractFactory = factoryProducer.getFactory("color");
            IColor color = abstractFactory.GetColor("red");

            Assert.IsInstanceOf<Red>(color);
        }

        [Test]
        public void CreateGreenObject()
        {
            abstractFactory = factoryProducer.getFactory("color");
            IColor color = abstractFactory.GetColor("green");

            Assert.IsInstanceOf<Green>(color);
        }
    }
}
