namespace Fighters.Models.Races
{
    public class Human : IRace
    {
        public double Damage => 1;

        public double Health => 20;

        public double Armor => 0;

        public double Luck => 1;

        public string Name => "Человек";
    }
}