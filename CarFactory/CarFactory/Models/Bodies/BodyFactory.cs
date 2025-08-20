namespace CarFactory.Models.Bodies
{
    internal class BodyFactory
    {
        public static IBody? Create( BodyType bType )
        {
            switch ( bType )
            {
                case BodyType.Coupe:

                    return new Coupe();

                case BodyType.Hatchback:

                    return new Hatchback();

                case BodyType.Sedan:

                    return new Sedan();

                case BodyType.Universal:

                    return new Universal();

                default:

                    return null;
            }
        }

        public static void WriteBodyChoice()
        {
            Console.WriteLine( "1 - Купе, \n2 - Хэтчбек, \n3 - Седан, \n4 - Универсал." );
        }
    }
}