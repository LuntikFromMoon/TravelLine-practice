namespace Fighters.Models.Weapons
{
    static class WeaponFactory
    {
        public static IWeapon? Create( WeaponType wType )
        {
            switch ( wType )
            {
                case WeaponType.Fists:
                    return new Fists();

                case WeaponType.Bow:
                    return new Bow();

                case WeaponType.Sword:
                    return new Sword();

                case WeaponType.LuckyHammer:
                    return new LuckyHammer();

                default:
                    return null;
            }
        }

        public static void WriteWeaponChoice() => Console.WriteLine( "1-Кулаки, \n2-Лук, \n3-Меч, \n4-Счастливый молот. \nВведите цифру..." );
    }
}