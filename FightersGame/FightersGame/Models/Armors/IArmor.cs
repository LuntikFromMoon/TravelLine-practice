namespace Fighters.Models.Armors
{
    public interface IArmor
    {
        public double Armor { get; }
        public double LuckPoints { get; }

        public string Name { get; }
    }
}