namespace Task2
{
    public class Material
    {
        public Material()
        {
            Name = default;
            Density = default;
        }

        public Material(string name, double density)
        {
            Name = name;
            Density = density;
        }

        public string Name { get; }

        public double Density { get; }

        public override string ToString() => $"{Name};{Density}";
    }
}
