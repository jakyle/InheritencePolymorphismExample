using ConsoleApp5.Stuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class DogBase : AnimalBase
    {
        public DogBase(string name, int age, string color) : base()
        {
            Age = age;
            Name = name;
            Color = color;
        }

        public string Color { get; set; }  

        public virtual string Bark()
        {
            return "Woof!";
        } 

        protected string Howl()
        {
            return "Awooooo";
        }

        private void MakeMess()
        {

        }
    }
}
