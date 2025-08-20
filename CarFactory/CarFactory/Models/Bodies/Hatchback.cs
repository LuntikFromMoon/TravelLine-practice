namespace CarFactory.Models.Bodies
{
    internal class Hatchback : IBody
    {
        public string Name => "Хэтчбек";

        public double CrossSectionalArea => 2.1;

        public double DragCoefficient => 0.32;
    }
}