namespace Task2
{
    public class Subject
    {
        public Subject()
        {
            Name = default;
            Material = default;
            Volume = default;
        }

        public Subject(string name, Material material, double volume)
        {
            Name = name;
            Material = material;
            Volume = volume;
        }

        public string Name { get; set; }

        public Material Material { get; set; }

        public double Volume { get; set; }

        public double GetMass() => Material.Density * Volume;

        public override string ToString() => $"{Name};{Material};{Volume};{GetMass()}";
    }
}
