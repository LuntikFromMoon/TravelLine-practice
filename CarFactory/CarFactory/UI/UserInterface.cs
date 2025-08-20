using CarFactory.Models.Bodies;
using CarFactory.Models.Cars;
using CarFactory.Models.Colors;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;

namespace CarFactory.UI
{
    internal class UserInterface
    {
        public void CreateCar()
        {
            string color = ReadColor();
            IBody body = ReadBody();
            IEngine engine = ReadEngine();
            ITransmission transmission = ReadTransmission();

            ICar userCar = new Car( color, body, engine, transmission );
            userCar.WriteInfo();
        }

        private string ReadColor()
        {
            while ( true )
            {
                Console.WriteLine( "Пожалуйста, выберите цвет вашего автомобиля:" );
                ColorFactory.WriteEngineChoice();
                string? color = Console.ReadLine();
                bool isParsed = Enum.TryParse( color, out Colors cType );
                if ( isParsed )
                {
                    color = ColorFactory.Create( cType );
                    if ( color != null )
                    {
                        return color;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private IBody ReadBody()
        {
            while ( true )
            {
                Console.WriteLine( "Выберите кузов:" );
                BodyFactory.WriteBodyChoice();
                string? bodyStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( bodyStr, out BodyType bType );
                if ( isParsed )
                {
                    IBody? body = BodyFactory.Create( bType );
                    if ( body != null )
                    {
                        return body;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private IEngine ReadEngine()
        {
            while ( true )
            {
                Console.WriteLine( "Выберите двигатель:" );
                EngineFactory.WriteEngineChoice();
                string? engineStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( engineStr, out EngineType eType );
                if ( isParsed )
                {
                    IEngine? engine = EngineFactory.Create( eType );
                    if ( engine != null )
                    {
                        return engine;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }

        private ITransmission ReadTransmission()
        {
            while ( true )
            {
                Console.WriteLine( "Выберите тип коробки передач:" );
                TransmissionFactory.WriteTransmissionChoice();
                string? transmissionStr = Console.ReadLine();
                bool isParsed = Enum.TryParse( transmissionStr, out TransmissionsType tType );
                if ( isParsed )
                {
                    ITransmission? transmission = TransmissionFactory.Create( tType );
                    if ( transmission != null )
                    {
                        return transmission;
                    }
                }

                Console.WriteLine( "Ваш выбор не поддерживается программой. Попробуйте ввести одну цифру из предложенных ещё раз." );
            }
        }
    }
}