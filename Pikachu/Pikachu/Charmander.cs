using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu_
{
    internal class Charmander
    {
        double height;
        double wright;

        Gender gender;
        Category category;
        Abilities abilities;
        Image image;
        Type type;
        Type weaknesses;

        enum Gender
        {
            male,
            female
        }
        enum Category
        {
            mounse
        }
        enum Abilities
        {
            static_
        }
        enum Type
        {
            electric, ground
        }
    }
}
