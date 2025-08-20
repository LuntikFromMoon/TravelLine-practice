namespace CarFactory.Models.Colors
{
    internal class ColorFactory
    {
        public static string? Create( Colors color )
        {
            switch ( color )
            {
                case Colors.Blue:

                    Console.BackgroundColor = ConsoleColor.Blue;
                    return "Синий";

                case Colors.Red:

                    Console.BackgroundColor = ConsoleColor.Red;
                    return "Красный";

                case Colors.Purple:

                    Console.BackgroundColor = ConsoleColor.Magenta;
                    return "Фиолетовый";

                default:

                    return null;
            }
        }

        public static void WriteEngineChoice()
        {
            Console.WriteLine( "1 - Синий, \n2 - Красный, \n3 - Фиолетовый." );
        }
    }
}