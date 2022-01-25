using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu_
{
    internal class Pokemon
    {
        protected string name;
        protected double height;
        protected double weight;

        protected Gender gender;
        protected Category category;
        protected Abilities abilities;
        protected Bitmap image;
        protected Type type;
        protected Type weaknesses;

        public string getName()
        {
            return this.name;
        }
        public Bitmap getImage()
        {
            return this.image;
        }

    }
    public enum Gender
        {
            male,
            female
        }
    public enum Category
        {
            mounse
        }
    public enum Abilities
        {
            static_
        }
    public enum Type
        {
            electric, ground
        }
    
}
