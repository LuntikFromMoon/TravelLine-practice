namespace Fighters.Models.Weapons
{
    public class Fists : IWeapon
    {
        public double Damage => 1;

        public double CritChance => 0.2;

        public double CritDamageModifier => 1.5;

        public double LuckPoints => 0;

        public string Name => "Кулаки";
    }
}