using System;

namespace ConsoleApp1
{
    internal class Chicken : Animal
    {        
        private int eggs = 0;
        public void LayAnEggs() => eggs += 1;
        public void LayAnEggs(int countEggs) => eggs += countEggs;
        public int TakeEggs(int countEggs)
        {
            eggs -= countEggs;
            return countEggs;
        }
        public int TakeEggs()
        {
            int takedEggs = eggs;
            eggs = 0;
            return takedEggs;
        }
        public void Say() => Console.WriteLine("Kukareku");
        public int Eggs
        {
            get { return eggs; }
            set { eggs = value; }
        }
        public Chicken()
        {
        }
        public Chicken(string name)
        {
            this.name = name;
        }
    }
}
