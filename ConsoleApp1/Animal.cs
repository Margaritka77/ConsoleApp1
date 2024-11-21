using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Animal
    {
        //свойства:
        //имя
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //уровень сытости
        protected int satiety = 10;
        public int Satiety
        {
            get { return satiety; }
            set { satiety = value; }
        }
        //здоровье
        protected int health = 100;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        //Функции:
        //кушать
        /// <summary>
        /// Функция увеличивает уровень сытости на 1
        /// </summary>
        public void Eat()
        {
            if (satiety < 10)
                satiety += 1;
        }
        /// <summary>
        /// Функция увеличивает уровень сытости на countFood
        /// </summary>
        /// <param name="countFood">Количество еды на которое увеличивается уровень сытости</param>
        public void Eat(int countFood)
        {
            if (satiety < 10 - countFood)
                satiety += countFood;
        }        
        public Animal()
        {

        }
        public Animal(int heal)
        {
            health =  heal;
        }
    }
}
