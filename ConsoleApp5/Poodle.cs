using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Poodle : DogBase
    {
        public Poodle(string name, int age, string color) : base(name, age, color)
        {
        }

        //public Poodle(string name, int age, bool isFurTangled, string color)
        //     : base(name, age, color)                                 
        //{
        //    Name = name;
        //    Age = age;
        //    Color = color;
        //    IsFurTangled = isFurTangled;
        //}

        //public Poodle(Yorkie yorkie, bool isfurTangled) 
        //    : base(yorkie.Name, yorkie.Age, yorkie.Color)
        //{
        //    IsFurTangled = isfurTangled;

        //}

        public bool IsFurTangled  { get; set; }
        
        public string MakeAwesomeNoise()
        {
            
            return Howl();
        }
    }
}
