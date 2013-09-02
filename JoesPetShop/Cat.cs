using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoesPetShop
{
    class Cat : Animal
    {
        public Cat(string aName, string aBreed, int aAge, string aGender, string aColor)
            : base(aName, aBreed, aAge, aGender, aColor)
        {
        }
    }
}
