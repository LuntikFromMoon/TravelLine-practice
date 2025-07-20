using Casino;

const string GameName = "" +
    " ####   ####   #####  #  #    #  ####" + "\n" +
    "#      #    # #       #  ##   # #    #" + "\n" +
    "#      #    # #       #  # #  # #    #" + "\n" +
    "#      ######  ####   #  #  # # #    #" + "\n" +
    "#      #    #      #  #  #   ## #    #" + "\n" +
    " ####  #    # #####   #  #    #  ####" + "\n";

const int Multiplier = 2;

PrintGameName( GameName );
int balance = InitializeTheBalance();
Operation? operation = Operation.Initial;
Random rand = new Random();

while ( ( operation != Operation.Exit ) & ( balance > 0 ) )
{
    PrintTheMenu();

    operation = ReadOperation();
    HandleOperation( operation, ref balance, Multiplier, ref rand );
}

if ( balance <= 0 )
{
    Console.WriteLine( $"Sorry, your balance is too small to make the bet. ({balance})" );
}

Console.WriteLine( "Thank you for playing. See you later!" );

static void PrintGameName( string gameName )
{
    Console.WriteLine( gameName );
}

static int InitializeTheBalance()
{
    Console.WriteLine( "Please enter your balance to start the game." );
    string? balanceStr = "";
    int balance = 0;
    bool validBalance = false;

    while ( !validBalance )
    {
        balanceStr = Console.ReadLine();
        validBalance = ValidateInt( balanceStr, ref balance );
    }

    return balance;
}

static bool ValidateInt( string? intStr, ref int resultInt )
{
    bool isValidBalance = int.TryParse( intStr, out resultInt );
    if ( !isValidBalance )
    {
        Console.WriteLine( $"Invalid value (required integer). You enetered: {intStr}. Try again." );
        return false;
    }

    return true;
}

static void PrintTheMenu()
{
    Console.WriteLine( "\nMenu\nTo play - 1\nTo check the balance - 2\nTo exit - 3\nWhat do you want to do now?" );
}

static Operation? ReadOperation()
{
    string? operationStr = Console.ReadLine();
    bool isParsed = Enum.TryParse( operationStr, out Operation operation );

    return isParsed ? operation : null;
}

static void HandleOperation( Operation? operation, ref int balance, int multiplier, ref Random rand )
{
    try
    {
        switch ( operation )
        {
            case Operation.Initial:
                return;
            case Operation.Play:
                balance = CountResult( balance, multiplier, ref rand );
                break;
            case Operation.CheckBalance:
                PrintBalance( balance );
                break;
            case Operation.Exit:
                break;
            default:
                throw new Exception( $"Unsupported operation. You entered: {operation}" );
        }
    }
    catch ( Exception e )
    {
        Console.WriteLine( $"You got an exception: {e}" );
        return;
    }

}

static void PrintBalance( int balance )
{
    Console.WriteLine( $"Your balance is {balance}" );
}

static int CountResult( int balance, int multiplier, ref Random rand )
{
    int bet = MakeTheBet( balance );
    balance -= bet;
    int randomNumb = GenerateCasinoNumber( rand );
    if ( randomNumb >= 18 )
    {
        balance += bet * ( 1 + multiplier * randomNumb % 17 );
        Console.WriteLine( $"Congrats! You won. Your balance now is {balance}" );
        return balance;
    }
    else
    {
        Console.WriteLine( $"Sorry, you lose. Better luck next time. Your balance now is {balance}" );
        return balance;
    }
}

static bool IsBetValid( ref int bet, string? betStr, int balance )
{
    if ( ValidateInt( betStr, ref bet ) )
    {
        if ( bet <= 0 | bet > balance )
        {
            Console.WriteLine( $"It is not possible to place the bet you entered. (It must be greater than 0 and less than or equal to the current balance, which is {balance}.)" );
            return false;
        }

        return true;
    }

    return false;
}

static int MakeTheBet( int balance )
{
    Console.WriteLine( "Please enter the bet." );
    int bet = 0;
    string? betStr = "";
    bool validBet = false;

    while ( !validBet )
    {
        betStr = Console.ReadLine();
        validBet = IsBetValid( ref bet, betStr, balance );
    }

    return bet;
}

static int GenerateCasinoNumber( Random rand )
{
    return rand.Next( 1, 21 );
}
