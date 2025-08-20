using CarFactory.Models.Bodies;
using CarFactory.Models.Engines;
using CarFactory.Models.Transmissions;

namespace CarFactory.Models.Cars
{
    internal interface ICar
    {
        string Color { get; }

        IBody Body { get; }

        IEngine Engine { get; }

        ITransmission Transmission { get; }

        double CalcMaxSpeed();

        void WriteInfo();
    }
}
