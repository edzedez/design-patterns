﻿using System;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    /// <summary>

    /// The 'ProductB1' class

    /// </summary>

    class Lion : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}