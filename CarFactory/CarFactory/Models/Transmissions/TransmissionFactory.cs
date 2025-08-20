namespace CarFactory.Models.Transmissions
{
    internal class TransmissionFactory
    {
        public static ITransmission Create( TransmissionsType tType )
        {
            switch ( tType )
            {
                case TransmissionsType.Auto:

                    return new Automatic();

                case TransmissionsType.Mechanical:

                    return new Mechanical();

                default:

                    throw new Exception( $"Выбранный тип не поддерживается программой. Вы ввели: {tType}" );
            }
        }

        public static void WriteTransmissionChoice()
        {
            Console.WriteLine( "1 - Автоматическая, \n2 - Механическая." );
        }
    }
}