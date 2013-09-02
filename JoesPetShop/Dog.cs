using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoesPetShop
{
    class Dog : Animal
    {
        private string dogCatagory; //Only dogs have this unique quality

        public Dog(string aName, string aBreed, int aAge, string aGender, string aColor, string aDogCatagory)
            : base(aName, aBreed, aAge, aGender, aColor)
        {
            dogCatagory = aDogCatagory;
        }

        public string DogCatagory
        {
            get { return dogCatagory; }
            set { dogCatagory = value; }
        }       
    }
}
