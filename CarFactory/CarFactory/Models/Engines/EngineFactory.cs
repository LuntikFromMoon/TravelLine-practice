namespace CarFactory.Models.Engines
{
    internal class EngineFactory
    {
        public static IEngine Create( EngineType eType )
        {
            switch ( eType )
            {
                case EngineType.Diesel:

                    return new Diesel();

                case EngineType.Hybrid:

                    return new Hybrid();

                case EngineType.Petrol:

                    return new Petrol();

                default:

                    throw new Exception( $"Выбранный тип не поддерживается программой. Вы ввели: {eType}" );
            }
        }

        public static void WriteEngineChoice()
        {
            Console.WriteLine( "1 - Дизельный, \n2 - Гибридный, \n3 - Бензиновый." );
        }
    }
}