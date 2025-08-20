namespace Fighters.Models.Armors
{
    static class ArmorFactory
    {
        public static IArmor? Create( ArmorType aType )
        {
            switch ( aType )
            {
                case ArmorType.NoArmor:
                    return new NoArmor();

                case ArmorType.LeatherTunic:
                    return new LeatherTunic();

                case ArmorType.IronChestplate:
                    return new IronChestplate();

                default:
                    return null;
            }
        }

        public static void WriteArmorChoice() => Console.WriteLine( "1-Без брони, \n2-Кожаная броня, \n3-Железные доспехи.\nВведите цифру..." );
    }
}