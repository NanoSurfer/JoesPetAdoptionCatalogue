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
        private double age;
        private string gender;
        private string color;

        //Constructor for a pure bred animal
        public Animal(string aName, string aBreed, double aAge, string aGender, string aColor)
        {
            name = aName;
            breed = aBreed;
            age = aAge;
            gender = aGender;
            color = aColor;
        }

        //Constructor for a non pure bred animal
        public Animal(string aName, double aAge, string aGender, string aColor)
        {
            name = aName;
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

        public double Age
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

        public override string ToString()
        {
            if (breed == null)
            {
               return "Name: " + name.ToString() + "Age: " + age.ToString() + "Gender: "
                    + gender.ToString() + "Colour: " + color.ToString();
            }
            else
            {
               return " Name: " + name.ToString() + " Age: " + age.ToString() + " Breed: " + breed.ToString() + " Gender: "
                    + gender.ToString() + " Colour: " + color.ToString();
            }
        }
    }
}
