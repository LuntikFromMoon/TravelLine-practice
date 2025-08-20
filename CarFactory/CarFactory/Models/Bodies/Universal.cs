namespace CarFactory.Models.Bodies
{
    internal class Universal : IBody
    {
        public string Name => "Универсал";

        public double CrossSectionalArea => 2.6;

        public double DragCoefficient => 0.36;
    }
}