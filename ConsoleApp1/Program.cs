using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farm = new Farm("Алексиевское Ранчо");
            farm.chickens.Add(new Chicken("Лена"));
            farm.chickens.Add(new Chicken("Настя"));
            farm.chickens.Add(new Chicken("Вова"));
            farm.cows.Add(new Cow("Ярополк"));
            farm.cows.Add(new Cow("Казимир"));
            farm.cows.Add(new Cow("Владлен"));
            Random rnd = new Random();
            for (int i = 0; i < farm.cows.Count; i++)
            {
                farm.cows[i].Health = rnd.Next(1,100);
                farm.chickens[i].Health = rnd.Next(1, 100);
                farm.cows[i].Satiety = rnd.Next(1, 10);
                farm.chickens[i].Health = rnd.Next(1, 10);
                farm.chickens[i].Say();
                farm.cows[i].Say();
                farm.cows[i].Eat(2);
                farm.chickens[i].Eat(5);
                farm.cows[i].TakeMilk();
                farm.chickens[i].TakeEggs(1);
            }

        }
    }
}