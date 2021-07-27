using System;

namespace Enemies
{
    ///<summary>Overrides ToSring method with new output</summary>
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
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int GetHealth() {
            return this.health;
        }
        public override string ToString() {
        return String.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
