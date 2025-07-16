static string ReadStringData( string message )
{
    Console.WriteLine( message );
    string data = Console.ReadLine();

    while ( string.IsNullOrEmpty( data ) )
    {
        Console.WriteLine( "Enter something to continue the order." );
        data = Console.ReadLine();
    }

    return data;
}

static bool ValidateInt( ref int number, string numberStr )
{
    try
    {
        number = Convert.ToInt32( numberStr );
    }
    catch ( Exception e )
    {
        Console.WriteLine( "Invalid value of the quantity. It must be a positive integer. Try again." );
        return false;
    }

    if ( number <= 0 )
    {
        Console.WriteLine( "The value must be greater than zero. Try again." );
        return false;
    }

    return true;
}

static int ReadProductQuantity( string message )
{
    Console.WriteLine( message );
    string quantityStr;

    int quantity = 0;
    bool validation = false;
    while ( !validation )
    {
        quantityStr = Console.ReadLine();
        validation = ValidateInt( ref quantity, quantityStr );
    }

    return quantity;
}

static void ConfirmDelivery( string productName, int quantity, string userName, string adress )
{
    while ( true )
    {
        Console.WriteLine( $"Hello, {userName}, you ordered {quantity} {productName} to the adress {adress}. Is it right?(y/n)" );
        Console.WriteLine( "y - yes, I accept the order." );
        Console.WriteLine( "n - no, it's wrong." );

        string agree = Console.ReadLine();

        if ( agree == "y" )
        {
            DateTime deliveryDate = DateTime.Now.AddDays( 3 );
            Console.WriteLine( $"{userName}! Your order {productName} in a quantity of {quantity} was accepted. Please expect delivery at {adress} by the {deliveryDate:dd.MM.yyyy}" );
            return;
        }
        else if ( agree == "n" )
        {
            Console.WriteLine( "Start the program again to enter your info correctly." );
            return;
        }
        else
        {
            Console.WriteLine( "Unknown command. Please try again." );
        }
    }
}

static bool StartNewOrder()
{
    Console.WriteLine( "Do you mant to create a new order?(y/n)" );
    Console.WriteLine( "y - yes" );
    Console.WriteLine( "n - no, I want to exit the program." );

    string agree = Console.ReadLine();

    if ( agree == "y" )
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool startTheOrder = true;

while ( startTheOrder )
{
    string productName = ReadStringData( "Hello, you have opened the delivery app.  Enter the name of the product you want to deliver." );
    int quantity = ReadProductQuantity( "Enter the quantity of the product" );
    string userName = ReadStringData( "Enter your name." );
    string adress = ReadStringData( "Enter the address where you want to deliver the product." );

    ConfirmDelivery( productName, quantity, userName, adress );

    startTheOrder = StartNewOrder();
}