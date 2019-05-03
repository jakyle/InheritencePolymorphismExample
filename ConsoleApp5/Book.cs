using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public abstract class BookBase
    {
        public virtual string GetGenre()
        {
            return "book";
        }

        public int Pages { get; set; }
    }
}
