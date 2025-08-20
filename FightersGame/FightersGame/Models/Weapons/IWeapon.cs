namespace Fighters.Models.Weapons
{
    public interface IWeapon
    {
        public double Damage { get; }
        public double CritChance { get; }
        public double CritDamageModifier { get; }
        public double LuckPoints { get; }
        public string Name { get; }
    }
}