namespace Fighters.Models.Weapons
{
    public class Sword : IWeapon
    {
        public double Damage => 1.3;

        public double CritChance => 0.3;

        public double CritDamageModifier => 1.3;

        public double LuckPoints => 0;

        public string Name => "Меч";
    }
}