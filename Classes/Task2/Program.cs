using System;

namespace Task2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Task 2 ===\n");

            // #1 Create object Steel_Wire from steel with volume of 0.03m3
            var wire = new Subject("wire", new Material("steel", 7850), 0.03);

            // #2 Print the object to the console using ToString().
            Console.WriteLine(wire);

            // #3 Change the wire material to copper (density = 8500) and display its on the console (its mass)
            wire.Material = new Material("copper", 8500);
            Console.WriteLine(wire.GetMass());

            Console.ReadKey();
        }
    }
}
