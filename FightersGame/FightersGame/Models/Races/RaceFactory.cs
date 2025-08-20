namespace Fighters.Models.Races
{
    static class RaceFactory
    {
        public static IRace? Create( RaceType rType )
        {
            switch ( rType )
            {
                case RaceType.Human:
                    return new Human();

                case RaceType.Elf:
                    return new Elf();

                case RaceType.Dwarf:
                    return new Dwarf();

                default:
                    return null;
            }
        }

        public static void WriteRaceChoice() => Console.WriteLine( "1-Человек, \n2-Эльф, \n3-Дварф.\nВведите цифру..." );
    }
}