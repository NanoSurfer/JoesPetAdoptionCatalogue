using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoesPetShop
{
    class Cat : Animal
    {
        //Pure bred Cat constructor
        public Cat(string aName, string aBreed, double aAge, string aGender, string aColor)
            : base(aName, aBreed, aAge, aGender, aColor)
        {
        }

        //Non pure bred Cat constructor
        public Cat(string aName, double aAge, string aGender, string aColor)
            : base(aName, aAge, aGender, aColor)
        {
        }
    }
}
