using Fighters.Models.Races;

namespace Fighters.Models.Fighters
{
    static class FighterFactory
    {
        public static IFighter? Create( FighterType fType, string name, IRace race )
        {
            switch ( fType )
            {
                case FighterType.Gladiator:
                    return new Gladiator( name, race );

                case FighterType.Hunter:
                    return new Hunter( name, race );

                case FighterType.Knight:
                    return new Knight( name, race );

                default:
                    return null;
            }
        }

        public static void WriteFightersChoice() => Console.WriteLine( "1-Гладиатор (больше хп), \n2-Охотник (больше дамаг), \n3-Рыцарь (больше защита).\nВведите цифру..." );
    }
}