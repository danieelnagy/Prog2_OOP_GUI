using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace vetej
{
    class PetOwner
    {
        internal List<Animal> pets = new List<Animal> //list av animal, CTOR=attributes
        {
            new Cat("Abby", 4, "Lax", "StrongCat", true),
            new Cat("Ellie", 13, "Fireflies", "SneakyCat", true),
            new Dog("Medi", 10, "Strawberry", "GoodDog", true, 2),
            new Dog("Daisy", 5, "Duck", "YorkieDog", true, 2),
            new Puppy("Daphne", 0, "Turkey", "Puppy", true, 1, 0.6), //finns säkert en bättre sätt konvertera age to months
            new Puppy("Joel", 0, "Beef", "Puppy", true, 1, 0.6)

        };

        internal List<Ball> balls = new List<Ball> //samma som animal
        {
            new Ball("Red", 10),
            new Ball("Blue", 6),
            new Ball("Green", 8),
            new Ball("Yellow", 2),
            new Ball("Black", 0),
            new Ball("White", 4)
        };

        internal List<Food> foods = new List<Food> // samma som animal
        {
            new Food("Lax"),
            new Food("Fireflies"),
            new Food("Strawberry"),
            new Food("Duck"),
            new Food("Turkey"),
            new Food("Beef")
        };

        public void SaveToTxt() //Jag kunde inte skriva fil C drive.
        {
            using (TextWriter tw = new StreamWriter(@"D:\\noteblablaagain.txt"))
            {
                tw.WriteLine("Food List: ");
                foreach (var i in foods)
                {
                    tw.WriteLine(string.Format("{0}", i.Type));
                }
                tw.WriteLine("\n");
                tw.WriteLine("Animal List:");
                foreach (var i in pets)
                {
                    tw.WriteLine(string.Format("{0}, {1}, {2}, {3}", i.Name, i.Age, i.Breed, i.Fav_food));
                }
                tw.WriteLine("\n");
                tw.WriteLine("Boll list:");
                foreach (var i in balls)
                {
                    tw.WriteLine(string.Format("{0}, {1}", i.Color, i.Quality));
                }
                tw.Close();
            }
            Console.WriteLine("Saved\n");
        }
        public string Fetch(int petIndex, int ballIndex)
        {
            string x = pets[petIndex].Interact(balls[ballIndex]);
            return x;
        }
        public string Feed(int petIndex, int foodIndex)
        {
            string asd = pets[petIndex].Eat(foods[foodIndex].Type);
            return asd;
        }
        public void Check_Food() //skriver ut en lista
        {
            foreach (var i in foods)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        public void List_Animals() // skriver ut en lista
        {
            foreach(var i in pets)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n");
        }
        public void List_Balls() // skriver ut en lista
        {
            int i = 0;
            foreach (var j in balls)
            {
                i++;
                Console.WriteLine(i + ": " + j);
            }
        }
    }
    class Ball
    {
        private string color;
        private int quality;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Ball(string _color, int _quality)
        {
            color = _color;
            quality = _quality;
        }

        public int LowerQuality(int power)
        {
            quality -= power; //värden av power varieras, beroende av anroparen
            return quality;

        }

        public override string ToString()
        {
            return string.Format("{0} ball", color);
        }

    }
}
