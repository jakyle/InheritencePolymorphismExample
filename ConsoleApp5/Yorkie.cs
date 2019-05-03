using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Yorkie : DogBase
    {
        public Yorkie(string name, int age, string color) 
            : base(name, age, color)
        {
        }

        public override string Bark()
        {
            var baseBaseBark = base.Bark();
            return "Yipp";
        }

    }
}
