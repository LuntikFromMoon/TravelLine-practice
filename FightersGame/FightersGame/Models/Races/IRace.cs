namespace Fighters.Models.Races
{
    public interface IRace
    {
        public string Name { get; }
        public double Damage { get; }
        public double Health { get; }
        public double Armor { get; }
        public double Luck { get; }
    }
}