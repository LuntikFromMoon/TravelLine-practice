using CarFactory.UI;

public class Program
{
    private static void Main( string[] args )
    {
        Console.WriteLine( "Начинается создание вашей конфигурации автомобиля." );
        UserInterface UI = new UserInterface();
        UI.CreateCar();
        Console.WriteLine( "Спасибо за использование нашего приложения для создания автомобиля!\n(Не гоняйте, пацаны, вы матерям ещё нужны...)" );
    }
}