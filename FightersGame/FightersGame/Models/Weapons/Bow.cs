namespace Fighters.Models.Weapons
{
    public class Bow : IWeapon
    {
        public double Damage => 1;

        public double CritChance => 0.4;

        public double CritDamageModifier => 2.0;

        public double LuckPoints => 1;

        public string Name => "Лук";
    }
}