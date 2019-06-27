using DesignPatterns.Singleton;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTest
{
    public class Singleton
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateSingletonObject()
        {
            SingletonObject instance = SingletonObject.GetInstance();
            string field = instance.GetField();
            int flag = instance.GetFlag();           

            Assert.AreEqual("field1", field);
            Assert.AreEqual(2, flag);            
        }
    }
}
