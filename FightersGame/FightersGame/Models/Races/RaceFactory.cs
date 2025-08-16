namespace Fighters.Models.Races
{
    static class RaceFactory
    {
        public static IRace Create( RaceType rType )
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
                    throw new Exception( $"Невалидный ввод. Вы ввели: {rType}" );
            }
        }
    }
}