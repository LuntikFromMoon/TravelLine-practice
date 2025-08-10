namespace Casino
{
    internal class OperationsHandler
    {
        public int Balance { get; private set; }

        private const int _multiplier = 2;

        private Randomizer _randomizer;

        private int _bet = 0;

        public OperationsHandler( int balance )
        {
            Balance = balance;
            _randomizer = new Randomizer();
        }

        public void Handle( Operation? operation )
        {
            try
            {
                switch ( operation )
                {
                    case Operation.Initial:
                        return;
                    case Operation.Play:
                        Balance = CountResult();
                        break;
                    case Operation.CheckBalance:
                        Console.WriteLine( $"Your balance is {Balance}" );
                        break;
                    case Operation.Exit:
                        break;
                    default:
                        throw new Exception( $"Unsupported operation. You entered: {operation}" );
                }
            }
            catch ( Exception e )
            {
                Console.WriteLine( $"Error: {e.Message}" );

                return;
            }
        }

        private int CountResult()
        {
            _bet = MakeTheBet();
            Balance -= _bet;
            int randomNumb = _randomizer.GenerateRandomNumber( 1, 20 );
            if ( randomNumb >= 18 )
            {
                Balance += _bet * ( 1 + _multiplier * randomNumb % 17 );
                Console.WriteLine( $"Congrats! You won. Your balance now is {Balance}" );

                return Balance;
            }
            else
            {
                Console.WriteLine( $"Sorry, you lose. Better luck next time. Your balance now is {Balance}" );

                return Balance;
            }
        }

        private int MakeTheBet()
        {
            Console.WriteLine( "Please enter the bet." );
            while ( true )
            {
                string? betStr = Console.ReadLine();
                if ( InputValidator.ValidateInt( betStr, out int bet ) )
                {
                    if ( bet > 0 && bet <= Balance )
                    {
                        return bet;
                    }
                    else
                    {
                        Console.WriteLine( $"It is not possible to place the bet you entered. " +
                            $"(It must be greater than 0 and less than or equal to the current balance, which is {Balance}.)" );
                    }
                }
            }
        }
    }
}