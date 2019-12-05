using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactoryPatternPractice
{
    //abstract factory
    public abstract class CarFactory
    {
        public abstract SportsCar CreateSportsCar();
        public abstract SUV CreateSUV();
    }
}
