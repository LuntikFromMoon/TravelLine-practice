namespace Fighters.Models.Armors
{
    static class ArmorFactory
    {
        public static IArmor Create( ArmorType aType )
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
                    throw new Exception( $"Невалидный ввод. Вы ввели: {aType}" );
            }
        }
    }
}