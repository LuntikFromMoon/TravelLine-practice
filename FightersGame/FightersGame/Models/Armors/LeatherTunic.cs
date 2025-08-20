namespace Fighters.Models.Armors
{
    public class LeatherTunic : IArmor
    {
        public double Armor => 1;

        public double LuckPoints => 0.3;

        public string Name => "Кожаная броня";
    }
}