namespace Fighters.Models.Races
{
    public class Elf : IRace
    {
        public double Damage => 0.8;

        public double Health => 18;

        public double Armor => 0;

        public double Luck => 3;

        public string Name => "Эльф";
    }
}