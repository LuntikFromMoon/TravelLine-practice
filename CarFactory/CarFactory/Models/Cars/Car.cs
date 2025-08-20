using CarFactory.Models.Bodies;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;

namespace CarFactory.Models.Cars
{
    internal class Car : ICar
    {
        public Car( string color, IBody body, IEngine engine, ITransmission transmission )
        {
            Color = color;
            Body = body;
            Engine = engine;
            Transmission = transmission;
        }

        public string Color { get; }

        public IBody Body { get; }

        public IEngine Engine { get; }

        public ITransmission Transmission { get; }

        public double CalcMaxSpeed() => Math.Pow( Engine.Power * 735 / ( 0.5 * Body.DragCoefficient * Body.CrossSectionalArea * 1.29 ), 1.0 / 3.0 ) * 3.6;

        public void WriteInfo() => Console.WriteLine( $"Цвет: {Color},\nТип кузова: {Body.Name},\nТип двигателя: {Engine.Name},\nТип КПП: {Transmission.Name},\nКоличество передач: {Transmission.GearsAmount},\nМаксимальная скорость данной конфигурации: {CalcMaxSpeed():F2} км/ч." );
    }
}