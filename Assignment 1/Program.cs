﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Hero
    {
        static void main()
        {
            SuperHero mySuperHero = new SuperHero(12, 32, 56, "Dark Aegis");
            mySuperHero.showPowers();

            Console.WriteLine("Press any key to exit."); 
            Console.ReadKey();
        }

        //PRIVATE PROPERTIES
        private int strength;
        private int speed;
        private int health;

        //PUBLIC PROPERTIES
        public string name;


        Random ran = new Random();

        //CONSTRUCTOR
        public Hero(string name)
        {
            this.name = name;
            generateAbilities();
        }

        //PRIVATE METHOD
        //causes to generate ability
        private void generateAbilities()
        {
            this.strength = ran.Next(1, 100);
            this.speed = ran.Next(1, 100);
            this.health = ran.Next(1, 100);
        }

        //PUBLIC METHOD
        public void fight()
        {
            int damage = 0;
            if (hitAttempt())
            {
                damage = hitDamage();
                Console.WriteLine("Damage caused to the target: {0}", damage);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
        private bool hitAttempt()
        {
            double hitTime = ran.Next(1, 100);
            if (hitTime >= 1 && hitTime <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int hitDamage()
        {
            int damage = this.strength * ran.Next(1, 6);
            return damage;
        }
        public void generateRandomPowers()
        {
            Console.WriteLine("Strength: {0}", this.strength);
            Console.WriteLine("Speed: {0}", this.speed);
            Console.WriteLine("Health: {0}", this.health);
            Console.WriteLine("----------------------");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        //Implement 
        static void Main()
        {
            Hero hero = new Hero("Dark Aegis");
            hero.generateRandomPowers();
            hero.fight();
        }
    }
}
