namespace Fighters.Models.Races
{
    public class Dwarf : IRace
    {
        public double Damage => 1.1;

        public double Health => 20;

        public double Armor => 1;

        public double Luck => 1;

        public string Name => "Дварф";
    }
}