namespace Fighters.Models.Weapons
{
    static class WeaponFactory
    {
        public static IWeapon Create( WeaponType wType )
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
                    throw new Exception( $"Невалидный ввод. Вы ввели: {wType}" );
            }
        }
    }
}