using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoesPetShop
{
    class Animal
    {
        private string name;
        private string breed;
        private int age;
        private string gender;
        private string color;

        public Animal(string aName, string aBreed, int aAge, string aGender, string aColor)
        {
            name = aName;
            breed = aBreed;
            age = aAge;
            gender = aGender;
            color = aColor;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
