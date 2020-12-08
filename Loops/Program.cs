using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 0; i <= 10; i++)
            //{
            //    //Console.WriteLine(i);

            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            var name = "Ricard Cusso";

            //for (var i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
