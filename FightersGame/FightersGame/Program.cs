using Fighters.UI;

namespace Fighters
{
    public class Program
    {
        public static void Main( string[] args )
        {
            var ui = new UserInterface();
            ui.Play();
            Console.WriteLine( "Замечательная игра! Увидимся в следующий раз." );
        }
    }
}