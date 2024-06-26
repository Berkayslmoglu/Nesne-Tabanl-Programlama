﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
                
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            Console.WriteLine(" ");
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }
            Console.ReadLine();
        }
    }
}
