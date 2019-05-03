using ConsoleApp5.Stuff;
using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //// app.run();

            //var listofsomething = new list<string>();

            //var poodle = new poodle("jon pierre la woof", 99, false, "salmon");
            //poodle.age = 2;
            //poodle.name = "foofoo";
            //poodle.isfurtangled = true;

            ////console.writeline(poodle.bark());

            //var yorkie = new yorkie("asher", 1, "brown and black");

            ////console.writeline(yorkie.bark());
            ////console.writeline(poodle.bark());
            //var frankenyorkie = new frankenyorkie("asher", 1, "brown and black");

            //var poodletwo = new poodle(frankenyorkie, true);
            //var dogs = new list<dogbase>();
            //dogs.add(yorkie);
            //dogs.add(poodle);

            //foreach (var dog in dogs)
            //{
            //   console.writeline($"i'm a dog, i bark like this: {dog.bark()}");
            //}

            var books = new List<BookBase>();
            books.Add(new HorrorBook());
            books.Add(new SciFi());
            books.Add(new Mystery());
            var meta = typeof(SciFi);
            foreach (var book in books)
            {
                Console.WriteLine(book.GetType());
            }
    
            Console.ReadLine();
        }
    }
}
