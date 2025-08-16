namespace Casino
{
    internal class InputValidator
    {
        public static bool ValidateInt( string? intStr, out int resultInt )
        {
            bool isValidBalance = int.TryParse( intStr, out resultInt );
            if ( !isValidBalance )
            {
                Console.WriteLine( $"Invalid value (required integer). You enetered: {intStr}. Try again." );
                return false;
            }

            return true;
        }
    }
}