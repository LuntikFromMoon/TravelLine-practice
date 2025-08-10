using Casino;

const string GameName = "" +
    " ####   ####   #####  #  #    #  ####" + "\n" +
    "#      #    # #       #  ##   # #    #" + "\n" +
    "#      #    # #       #  # #  # #    #" + "\n" +
    "#      ######  ####   #  #  # # #    #" + "\n" +
    "#      #    #      #  #  #   ## #    #" + "\n" +
    " ####  #    # #####   #  #    #  ####" + "\n";

PrintGameName( GameName );
OperationsHandler operationsHandler = new OperationsHandler( InitializeTheBalance() );
Operation? operation = Operation.Initial;

while ( ( operation != Operation.Exit ) && ( operationsHandler.Balance > 0 ) )
{
    PrintTheMenu();

    operation = ReadOperation();
    operationsHandler.Handle( operation );
}

if ( operationsHandler.Balance <= 0 )
{
    Console.WriteLine( $"Sorry, your balance is too small to make the bet. ({operationsHandler.Balance})" );
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
        validBalance = InputValidator.ValidateInt( balanceStr, out balance );
    }

    return balance;
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