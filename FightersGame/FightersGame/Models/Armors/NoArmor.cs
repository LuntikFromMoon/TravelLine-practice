namespace Fighters.Models.Armors
{
    public class NoArmor : IArmor
    {
        public double Armor => 0;

        public double LuckPoints => 0;

        public string Name => "Без брони";
    }
}
