using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        public Zombie() {
            this.health = 0;
        }
        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        private string name = "(No name)";
        public string Name(string value) {
            get => this.name;
            set => this.name = value;
        }
        public int GetHealth() {
            return this.health;
        }
        public override string ToString() {
        return String.Format("Zombie Name: {0} / Total Health: {1}", this.health, this.name);
        }
    }
}
