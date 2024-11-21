using System;

namespace ConsoleApp1
{
    internal class Cow : Animal
    {
        private int milk = 0;
        public void LayAnMilk() => milk += 1;
        public void LayAnMilk(int countEggs) => milk += countEggs;
        public int TakeMilk(int countEggs)
        {
            milk -= countEggs;
            return countEggs;
        }
        public int TakeMilk()
        {
            int takedMilk = milk;
            milk = 0;
            return takedMilk;
        }
        public void Say() => Console.WriteLine("Mow");
        public int Milk
        {
            get { return milk; }
            set { milk = value; }
        }
        public Cow(){        }
        public Cow(string name) => this.name = name;
        
    }
}
