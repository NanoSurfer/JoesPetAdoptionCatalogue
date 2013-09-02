using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoesPetShop
{
    class Dog : Animal
    {
        private string dogCatagory; //Only dogs have this unique quality

        //Constructor for pure breed Dog
        public Dog(string aName, string aBreed, double aAge, string aGender, string aColor, string aDogCatagory)
            : base(aName, aBreed, aAge, aGender, aColor)
        {
            dogCatagory = aDogCatagory;
        }

        //Constructor for non pure breed Dog
        public Dog(string aName, double aAge, string aGender, string aColor)
            : base(aName, aAge, aGender, aColor)
        {
        }

        public string DogCatagory
        {
            get { return dogCatagory; }
            set { dogCatagory = value; }
        }

        public override string ToString()
        {
            if (dogCatagory == null)
            {
                return base.ToString() + "Catagory: none";
            }
            else
            {
                return base.ToString() + "Catagory: " + dogCatagory.ToString();
            }
        }
    }
}
