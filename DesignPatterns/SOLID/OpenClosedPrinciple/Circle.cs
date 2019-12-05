﻿using DesignPatterns.SOLID.OpenClosedPrinciple;
using System;

public class Circle : Shape
{
    public double Radius { get; set; }
    public override double Area()
    {
        return Radius * Radius * Math.PI;
    }
}
