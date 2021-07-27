﻿using System;

namespace Enemies
{
    ///<summary>Adds setter for health field</summary>
    class Zombie
    {
        public int health;
        public Zombie() {
            this.health = 0;
        }
        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
    }
}
