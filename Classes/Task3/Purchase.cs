using System;

namespace Task3
{
    public class Purchase : IComparable<Purchase>
    {
        public Purchase()
        {
            Name = default;
            Price = default;
            Quantity = default;
            Day = default;
        }

        public Purchase(string name, decimal price, int quantity, DayOfWeek day)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Day = day;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DayOfWeek Day { get; set; }

        public decimal GetCost() => Price * Quantity;

        public int CompareTo(Purchase purchase) => (int)(GetCost() - purchase.GetCost());

        public override string ToString() => $"{Name};{Price};{Quantity};{Day};{GetCost()}";
    }
}
