using System;

namespace Task3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("=== Task 3 ===\n");

            // #1 - Create an array with five non-empty objects
            var purchases = new Purchase[]
                {
                    new Purchase("Flash Card 4Gb", 27m, 4, DayOfWeek.Monday),
                    new Purchase("Cable USB to miniUSB", 8m, 5, DayOfWeek.Sunday),
                    new Purchase("Samsung A3 32Gb", 238m, 2, DayOfWeek.Friday),
                    new Purchase("Acer Aspire NP-Y18 4Gb GeForce 940MX", 1450m, 1, DayOfWeek.Wednesday),
                    new Purchase("Apple Watch", 845m, 2, DayOfWeek.Thursday),
                };

            // #2 - Print objects from array to console using ToString()
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // #3
            // Calculate the average cost of all purchases
            // Find the day on which the purchase with maximum cost was made
            decimal averageCost = default;
            Purchase purchaseWithMaxCost = purchases[0];

            foreach (var item in purchases)
            {
                averageCost += item.GetCost();

                if (item.GetCost() > purchaseWithMaxCost.GetCost())
                {
                    purchaseWithMaxCost = item;
                }
            }

            Console.WriteLine($"Average cost: {averageCost}");
            Console.WriteLine($"Day on which the purchase with maximum cost was made: {purchaseWithMaxCost.Day}");


            Console.WriteLine();

            // #4 Sort an array using the Sort() method of the Array class
            Array.Sort(purchases);

            // #5 Print objects from sorted array to console using ToString()
            foreach (var item in purchases)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
