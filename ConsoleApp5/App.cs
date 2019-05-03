using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public static class App
    {
        public static void Run()
        {
            Console.WriteLine("Please enter the length and width of the room...");
            Console.Write("please enter the length:  ");
            

            var length = int.Parse(Console.ReadLine());

            Console.Write("please enter the width:  ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("please enter the height:  ");
            var height = int.Parse(Console.ReadLine());


            var room = new Room(length, width, height);

            Console.WriteLine($"room Area: {room.GetArea()}");
            Console.WriteLine($"room Perimeter: {room.GetPerimeter()}");
            Console.WriteLine($"room Volume: {room.GetVolume()}");

            Console.ReadLine();
        }
    }
}
