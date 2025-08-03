namespace Fighters.Models.Weapons
{
    public class LuckyHammer : IWeapon
    {
        public double Damage => 3;

        public double CritChance => 0.6;

        public double CritDamageModifier => 1.5;

        public double LuckPoints => 10;

        public string Name => "Счастливый молот";
    }
}