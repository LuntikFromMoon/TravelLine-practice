namespace CarFactory.Models.Bodies
{
    internal class Coupe : IBody
    {
        public string Name => "Купе";

        public double CrossSectionalArea => 1.9;

        public double DragCoefficient => 0.26;
    }
}