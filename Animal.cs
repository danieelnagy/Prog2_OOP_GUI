using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace vetej
{
    abstract class Animal
    {
        protected int age;
        protected string name;
        protected string fav_food;
        protected string breed;
        protected bool hungry = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public string Fav_food
        {
            get { return fav_food; }
            set { fav_food = value; }
        }

        public bool Hungry
        {
            get { return hungry; }
            set { hungry = value; }
        }

        public Animal(string _name, int _age, string _fav_food, string _breed, bool _hungry)
        {
            name = _name;
            age = _age;
            fav_food = _fav_food;
            breed = _breed;
            hungry = _hungry;
        }

        public string Eat(string food)
        {
            if (food == fav_food)
            {
                Hungry = false;
                return "Ate its favorite food, not hungry for now\n";
            }
            else
            {
                Hungry = true;
                return "Didnt liked the food, still hungry\n";
            }
        }
        public abstract string Interact(Ball ball);
        public abstract void Hungry_Animal();

    }

    class Cat : Animal
    {
        public Cat(string _name, int _age, string _fav_food, string _breed, bool _hungry) : base(_name, _age, _fav_food, _breed, _hungry)
        {
            name = _name;
            age = _age;
            fav_food = _fav_food;
            breed = _breed;
            hungry = _hungry;

        }
        public override void Hungry_Animal()
        {
            Random rnd = new Random();
            int hunger = rnd.Next(100, 102); //33% chans
            if (hunger == 101)
            {
                Hungry = true;
            }
            else
            {
                Hungry = false;
            }
        }

        public override string Interact(Ball ball)
        {
            Hungry_Animal();
            if (Hungry == true)
            {
                return Name + " is hungry, wont play"; 
            }
            else
            {
                return Name + " had a good play time.";
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, breed);
        }
    }

    class Dog : Animal
    {
        protected int powerLevel; // denna var kommer att användes i lowerQuality metod
        public Dog(string _name, int _age, string _fav_food, string _breed, bool _hungry, int _powerLevel) : base(_name, _age, _fav_food, _breed, _hungry)
        {
            name = _name;
            age = _age;
            fav_food = _fav_food;
            breed = _breed;
            hungry = _hungry;
            powerLevel = _powerLevel;

        }
        public override void Hungry_Animal()
        {
            Random rnd = new Random();
            int hunger = rnd.Next(100, 102);
            if (hunger == 101)
            {
                Hungry = true;
            }
            else
            {
                Hungry = false;
            }
        }

        public override string Interact(Ball ball)
        {
            Hungry_Animal();
            if (Hungry == true)
            {
                return Name + " is hungry, wont play";
            }
            else
            {
                ball.LowerQuality(powerLevel); //skickar värden till parametern i Ball class --> metod
                return Name + " had a good time, and chewed on the " + ball.Color + " boll";
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1}", name, breed);
        }
    }

    class Puppy : Dog
    {
        protected double months;
        public Puppy(string _name, int _age, string _fav_food, string _breed, bool _hungry, int _powerLevel, double _months) : base(_name, _age, _fav_food, _breed, _hungry, _powerLevel)
        {
            name = _name;
            age = _age;
            fav_food = _fav_food;
            breed = _breed;
            hungry = _hungry;
            powerLevel = _powerLevel;
            months = _months;

        }
        public override void Hungry_Animal()
        {
            Random rnd = new Random();
            int hunger = rnd.Next(100, 102);
            if (hunger == 101)
            {
                Hungry = true;
            }
            else
            {
                Hungry = false;
            }
        }

        public override string Interact(Ball ball)
        {
            Hungry_Animal();
            if (Hungry == true)
            {
                return Name + " is hungry, wont play";
            }
            else
            {
                ball.LowerQuality(powerLevel);
                return Name + " had a good time, and chewed on the " + ball.Color + " boll";
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", name, breed);
        }
    }
}
