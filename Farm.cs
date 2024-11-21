using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Farm
    {
        //Свойство животные (для каждого животного) - массив 
        public List<Chicken> chickens;
        public List<Cow> cows;
        private string name;
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }
        //Свойство корм - массив чисел 
        public Farm()
        {
            chickens = new List<Chicken>();
            cows = new List<Cow>();
        }
        public Farm(string name)
        {
            this.name = name;
            chickens = new List<Chicken>();
            cows = new List<Cow>();
        }
    }
}
