namespace CarFactory.Models.Bodies
{
    internal class Sedan : IBody
    {
        public string Name => "Седан";

        public double CrossSectionalArea => 2.3;

        public double DragCoefficient => 0.29;
    }
}